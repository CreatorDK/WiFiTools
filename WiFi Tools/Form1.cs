using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWifi;
using System.Threading;

namespace WiFi_Tools
{
    public partial class Form1 : Form
    {
        public string current_ap;
        public string current_ap_temp;
        public string autoconnect_ap;
        int timer_time;
        int time_to_connect;
        Wifi wifi = null;
        Thread thread;
        public Form1()
        {
            wifi = new Wifi();
            InitializeComponent();
            ShowAPList();
            timer_autorefresh.Start();
            Logger.WriteLine("Программа запущена");
            autoconnect_ap = "";
        }

        private void ConnectToAPThread()
        {
            thread = new Thread(ConnectToAP);
            thread.Start();
        }

        private void CheckAPStatusThread()
        {
            thread = new Thread(CheckAPStatus);
            thread.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_connect_after.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.WriteLine("Завершение работы программы");
        }

        private string BoolResultToRussian(bool inbool)
        {
            if (inbool)
            {
                return "Да";
            }
            else
            {
                return "Нет";
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon_main.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon_main.Visible = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon_main.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAPList();
        }

        private void ShowAPList()
        {
            List<AccessPoint> aps = wifi.GetAccessPoints();
            listView1.Items.Clear();
            bool connected = false;

            foreach (AccessPoint ap in aps)
            {
                //string[] row = { ap.Name, ap.SignalStrength.ToString(), "-", ap.IsSecure.ToString(), ap.HasProfile.ToString() };
                //var item = new ListViewItem(row);
                //listView1.Items.Add(item);

                ListViewItem item = new ListViewItem(ap.Name);
                item.SubItems.Add(ap.SignalStrength.ToString());
                item.SubItems.Add("-");
                item.SubItems.Add(BoolResultToRussian(ap.IsSecure));
                item.SubItems.Add(BoolResultToRussian(ap.HasProfile));       
                listView1.Items.Add(item);

                if(ap.IsConnected)
                {
                    toolStripStatusLabel1.Text = "Подключено к: " + ap.Name;
                    current_ap = ap.Name;
                    connected = true;
                }
            }

            if (!connected)
            {
                toolStripStatusLabel1.Text = "Не подкючено";
            }
        }

        private void RefreshAPList()
        {
            List<AccessPoint> aps = wifi.GetAccessPoints();
            bool connected = false;

            foreach (AccessPoint ap in aps)
            {
                foreach (ListViewItem itm in listView1.Items)
                {
                    if (ap.Name == itm.SubItems[0].Text)
                    {
                        itm.SubItems[1].Text = ap.SignalStrength.ToString();
                        itm.SubItems[3].Text = BoolResultToRussian(ap.IsSecure);
                        itm.SubItems[4].Text = BoolResultToRussian(ap.HasProfile);
                    }
                }

                if (ap.IsConnected)
                {
                    toolStripStatusLabel1.Text = "Подключено к: " + ap.Name;
                    current_ap = ap.Name;
                    connected = true;
                }
            }

            if (!connected)
            {
                if (current_ap != "")
                {
                    current_ap_temp = current_ap;
                    Logger.WriteLine("Отключено от точки доступа: " + current_ap);
                    current_ap = "";
                }
                toolStripStatusLabel1.Text = "Не подкючено";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshAPList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_jornal frm_grnl = new Form_jornal();
            frm_grnl.ShowDialog();
        }



        private void забытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip_list_view_Opening(object sender, CancelEventArgs e)
        {
            //bool AP_Has_Profile;
            
            if(listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].SubItems[4].Text == "Да")
                {
                    забытьToolStripMenuItem.Visible = true;
                    автоподключениеToolStripMenuItem.Visible = true;
                }
                else
                {
                    забытьToolStripMenuItem.Visible = false;
                    автоподключениеToolStripMenuItem.Visible = false;
                }

                if(listView1.SelectedItems[0].SubItems[0].Text == current_ap)
                {
                    подключитьсяToolStripMenuItem.Visible = false;
                    отключитьсяToolStripMenuItem.Visible = true;
                }
                else
                {
                    подключитьсяToolStripMenuItem.Visible = true;
                    отключитьсяToolStripMenuItem.Visible = false;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void автоподключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                autoconnect_ap = listView1.SelectedItems[0].Text.ToString();
                label_autoconnect.Text = "Автоподключение к точке доступа: " + autoconnect_ap;
                checkBox_autoconnect.Enabled = true;
                checkBox_autoconnect.Checked = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                autoconnect_ap = listView1.SelectedItems[0].Text.ToString();
                label_autoconnect.Text = "Автоподключение к точке доступа: " + autoconnect_ap;
                checkBox_autoconnect.Enabled = true;
                checkBox_autoconnect.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_autoconnect.Checked)
            {
                timer_check_ap_status.Start();
            }
            else
            {
                timer_check_ap_status.Stop();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].SubItems[4].Text == "Да")
                {
                    button_autoconnect.Enabled = true;
                }
                else
                {
                    button_autoconnect.Enabled = false;
                }
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void timer_check_ap_status_Tick(object sender, EventArgs e)
        {
            timer_time += 1;
            if (timer_time>=time_to_connect)
            {
                timer_time = 0;
                CheckAPStatusThread();
            }
        }

        private void CheckAPStatus()
        {
            List<AccessPoint> aps = wifi.GetAccessPoints();

            foreach (AccessPoint ap in aps)
            {
                if (ap.Name == autoconnect_ap)
                {
                    if (!ap.IsConnected)
                    {
                        AuthRequest auth_reguest = new AuthRequest(ap);
                        try
                        {
                            ap.Connect(auth_reguest);
                            toolStripStatusLabel1.Text = "Автоматическое подключение к точке доступа: " + ap.Name;
                            Logger.WriteLine("Автоматическое подключение к точке доступа: " + ap.Name);
                        }

                        catch
                        {

                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_connect_after.Text)
            {
                case "5 с":
                    time_to_connect = 5;
                    return;
                case "10 с":
                    time_to_connect = 10;
                    return;
                case "15 с":
                    time_to_connect = 15;
                    return;
                case "30 с":
                    time_to_connect = 30;
                    return;
                case "1 м":
                    time_to_connect = 60;
                    return;
                case "5 м":
                    time_to_connect = 300;
                    return;
                case "10 м":
                    time_to_connect = 600;
                    return;
                case "15 м":
                    time_to_connect = 900;
                    return;
                case "30 м":
                    time_to_connect = 1800;
                    return;
            }
             
        }

        private void отключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ручное отключение от точки доступа: " + current_ap;
            Logger.WriteLine("Ручное отключение от точки доступа: " + current_ap);
            wifi.Disconnect();
            current_ap = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wifi.ConnectionStatus.ToString(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectToAPThread();
        }

        private void ConnectToAP()
        {
            List<AccessPoint> aps = wifi.GetAccessPoints();

            foreach (AccessPoint ap in aps)
            {
                if (ap.Name == listView1.SelectedItems[0].SubItems[0].Text)
                {
                    AuthRequest auth_reguest = new AuthRequest(ap);
                    try
                    {
                        ap.Connect(auth_reguest);
                        toolStripStatusLabel1.Text = "Ручное подключение к точке доступа: " + ap.Name;
                        Logger.WriteLine("Ручное подключение к точке доступа: " + ap.Name);
                    }

                    catch
                    {

                    }
                }
            }
        }


    }
}
