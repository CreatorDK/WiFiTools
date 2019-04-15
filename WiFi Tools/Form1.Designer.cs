namespace WiFi_Tools
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_SSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Signal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Channel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Security = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HasProfile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_list_view = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.подключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоподключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.забытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox_connect = new System.Windows.Forms.GroupBox();
            this.checkBox_autoconnect = new System.Windows.Forms.CheckBox();
            this.comboBox_connect_after = new System.Windows.Forms.ComboBox();
            this.label_connect_after = new System.Windows.Forms.Label();
            this.groupBox_current_connection = new System.Windows.Forms.GroupBox();
            this.button_autoconnect = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_SSID = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label_autoconnect = new System.Windows.Forms.Label();
            this.statusStrip_main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon_main = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_autorefresh = new System.Windows.Forms.Timer(this.components);
            this.timer_check_ap_status = new System.Windows.Forms.Timer(this.components);
            this.отключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip_list_view.SuspendLayout();
            this.groupBox_connect.SuspendLayout();
            this.groupBox_current_connection.SuspendLayout();
            this.statusStrip_main.SuspendLayout();
            this.contextMenuStrip_notify.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_SSID,
            this.columnHeader_Signal,
            this.columnHeader_Channel,
            this.columnHeader_Security,
            this.columnHeader_HasProfile});
            this.listView1.ContextMenuStrip = this.contextMenuStrip_list_view;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(731, 604);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // columnHeader_SSID
            // 
            this.columnHeader_SSID.Text = "SSID";
            this.columnHeader_SSID.Width = 180;
            // 
            // columnHeader_Signal
            // 
            this.columnHeader_Signal.Text = "Сигнал";
            this.columnHeader_Signal.Width = 80;
            // 
            // columnHeader_Channel
            // 
            this.columnHeader_Channel.Text = "Канал";
            this.columnHeader_Channel.Width = 80;
            // 
            // columnHeader_Security
            // 
            this.columnHeader_Security.Text = "Защита";
            this.columnHeader_Security.Width = 100;
            // 
            // columnHeader_HasProfile
            // 
            this.columnHeader_HasProfile.Text = "Профиль";
            this.columnHeader_HasProfile.Width = 100;
            // 
            // contextMenuStrip_list_view
            // 
            this.contextMenuStrip_list_view.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_list_view.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьсяToolStripMenuItem,
            this.отключитьсяToolStripMenuItem,
            this.автоподключениеToolStripMenuItem,
            this.забытьToolStripMenuItem});
            this.contextMenuStrip_list_view.Name = "contextMenuStrip1";
            this.contextMenuStrip_list_view.Size = new System.Drawing.Size(211, 128);
            this.contextMenuStrip_list_view.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_list_view_Opening);
            // 
            // подключитьсяToolStripMenuItem
            // 
            this.подключитьсяToolStripMenuItem.Name = "подключитьсяToolStripMenuItem";
            this.подключитьсяToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.подключитьсяToolStripMenuItem.Text = "Подключиться";
            this.подключитьсяToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяToolStripMenuItem_Click);
            // 
            // автоподключениеToolStripMenuItem
            // 
            this.автоподключениеToolStripMenuItem.Name = "автоподключениеToolStripMenuItem";
            this.автоподключениеToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.автоподключениеToolStripMenuItem.Text = "Автоподключение";
            this.автоподключениеToolStripMenuItem.Click += new System.EventHandler(this.автоподключениеToolStripMenuItem_Click);
            // 
            // забытьToolStripMenuItem
            // 
            this.забытьToolStripMenuItem.Name = "забытьToolStripMenuItem";
            this.забытьToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.забытьToolStripMenuItem.Text = "Забыть ТД";
            this.забытьToolStripMenuItem.Click += new System.EventHandler(this.забытьToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(753, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(753, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Настройки";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox_connect
            // 
            this.groupBox_connect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox_connect.Controls.Add(this.button2);
            this.groupBox_connect.Controls.Add(this.checkBox_autoconnect);
            this.groupBox_connect.Controls.Add(this.comboBox_connect_after);
            this.groupBox_connect.Controls.Add(this.label_connect_after);
            this.groupBox_connect.Location = new System.Drawing.Point(753, 407);
            this.groupBox_connect.Name = "groupBox_connect";
            this.groupBox_connect.Size = new System.Drawing.Size(277, 210);
            this.groupBox_connect.TabIndex = 4;
            this.groupBox_connect.TabStop = false;
            this.groupBox_connect.Text = "Автоподключение";
            // 
            // checkBox_autoconnect
            // 
            this.checkBox_autoconnect.AutoSize = true;
            this.checkBox_autoconnect.Enabled = false;
            this.checkBox_autoconnect.Location = new System.Drawing.Point(8, 26);
            this.checkBox_autoconnect.Name = "checkBox_autoconnect";
            this.checkBox_autoconnect.Size = new System.Drawing.Size(150, 21);
            this.checkBox_autoconnect.TabIndex = 8;
            this.checkBox_autoconnect.Text = "Автоподключение";
            this.checkBox_autoconnect.UseVisualStyleBackColor = true;
            this.checkBox_autoconnect.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox_connect_after
            // 
            this.comboBox_connect_after.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_connect_after.FormattingEnabled = true;
            this.comboBox_connect_after.Items.AddRange(new object[] {
            "5 с",
            "10 с",
            "15 с",
            "30 с",
            "1 м",
            "5 м",
            "10 м",
            "15 м",
            "30 м"});
            this.comboBox_connect_after.Location = new System.Drawing.Point(148, 51);
            this.comboBox_connect_after.Name = "comboBox_connect_after";
            this.comboBox_connect_after.Size = new System.Drawing.Size(125, 24);
            this.comboBox_connect_after.TabIndex = 7;
            this.comboBox_connect_after.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_connect_after
            // 
            this.label_connect_after.AutoSize = true;
            this.label_connect_after.Location = new System.Drawing.Point(6, 55);
            this.label_connect_after.Name = "label_connect_after";
            this.label_connect_after.Size = new System.Drawing.Size(136, 17);
            this.label_connect_after.TabIndex = 5;
            this.label_connect_after.Text = "Подключать после:";
            // 
            // groupBox_current_connection
            // 
            this.groupBox_current_connection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox_current_connection.Controls.Add(this.button_autoconnect);
            this.groupBox_current_connection.Controls.Add(this.button5);
            this.groupBox_current_connection.Controls.Add(this.label8);
            this.groupBox_current_connection.Controls.Add(this.label7);
            this.groupBox_current_connection.Controls.Add(this.label6);
            this.groupBox_current_connection.Controls.Add(this.label5);
            this.groupBox_current_connection.Controls.Add(this.label4);
            this.groupBox_current_connection.Controls.Add(this.label3);
            this.groupBox_current_connection.Controls.Add(this.label2);
            this.groupBox_current_connection.Controls.Add(this.label1);
            this.groupBox_current_connection.Controls.Add(this.label_SSID);
            this.groupBox_current_connection.Location = new System.Drawing.Point(753, 142);
            this.groupBox_current_connection.Name = "groupBox_current_connection";
            this.groupBox_current_connection.Size = new System.Drawing.Size(277, 259);
            this.groupBox_current_connection.TabIndex = 5;
            this.groupBox_current_connection.TabStop = false;
            this.groupBox_current_connection.Text = "Текущее подключение";
            // 
            // button_autoconnect
            // 
            this.button_autoconnect.Location = new System.Drawing.Point(141, 216);
            this.button_autoconnect.Name = "button_autoconnect";
            this.button_autoconnect.Size = new System.Drawing.Size(130, 37);
            this.button_autoconnect.TabIndex = 13;
            this.button_autoconnect.Text = "Авт. Подкл.";
            this.button_autoconnect.UseVisualStyleBackColor = true;
            this.button_autoconnect.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 37);
            this.button5.TabIndex = 8;
            this.button5.Text = "Отключиться";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Состояние:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Задержка на подключение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Принудительное подключение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Шифрование:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип защиты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Защита:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Канал:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сигнал:";
            // 
            // label_SSID
            // 
            this.label_SSID.AutoSize = true;
            this.label_SSID.Location = new System.Drawing.Point(7, 22);
            this.label_SSID.Margin = new System.Windows.Forms.Padding(10);
            this.label_SSID.Name = "label_SSID";
            this.label_SSID.Size = new System.Drawing.Size(43, 17);
            this.label_SSID.TabIndex = 4;
            this.label_SSID.Text = "SSID:";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.Location = new System.Drawing.Point(753, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(277, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Журнал";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_autoconnect
            // 
            this.label_autoconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_autoconnect.AutoSize = true;
            this.label_autoconnect.BackColor = System.Drawing.Color.Chartreuse;
            this.label_autoconnect.Location = new System.Drawing.Point(13, 625);
            this.label_autoconnect.Name = "label_autoconnect";
            this.label_autoconnect.Size = new System.Drawing.Size(242, 17);
            this.label_autoconnect.TabIndex = 9;
            this.label_autoconnect.Text = "Автоподключение к точке доступа:";
            // 
            // statusStrip_main
            // 
            this.statusStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip_main.Location = new System.Drawing.Point(0, 648);
            this.statusStrip_main.Name = "statusStrip_main";
            this.statusStrip_main.Size = new System.Drawing.Size(1042, 25);
            this.statusStrip_main.TabIndex = 11;
            this.statusStrip_main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 20);
            this.toolStripStatusLabel1.Text = "Подключено к";
            // 
            // notifyIcon_main
            // 
            this.notifyIcon_main.ContextMenuStrip = this.contextMenuStrip_notify;
            this.notifyIcon_main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_main.Icon")));
            this.notifyIcon_main.Text = "WiFi Tools";
            this.notifyIcon_main.Visible = true;
            this.notifyIcon_main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip_notify
            // 
            this.contextMenuStrip_notify.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip_notify.Name = "contextMenuStrip_notify";
            this.contextMenuStrip_notify.Size = new System.Drawing.Size(143, 52);
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.показатьToolStripMenuItem.Text = "Показать";
            this.показатьToolStripMenuItem.Click += new System.EventHandler(this.показатьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // timer_autorefresh
            // 
            this.timer_autorefresh.Interval = 5000;
            this.timer_autorefresh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_check_ap_status
            // 
            this.timer_check_ap_status.Interval = 1000;
            this.timer_check_ap_status.Tick += new System.EventHandler(this.timer_check_ap_status_Tick);
            // 
            // отключитьсяToolStripMenuItem
            // 
            this.отключитьсяToolStripMenuItem.Name = "отключитьсяToolStripMenuItem";
            this.отключитьсяToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.отключитьсяToolStripMenuItem.Text = "Отключиться";
            this.отключитьсяToolStripMenuItem.Click += new System.EventHandler(this.отключитьсяToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Status";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 673);
            this.Controls.Add(this.statusStrip_main);
            this.Controls.Add(this.label_autoconnect);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox_current_connection);
            this.Controls.Add(this.groupBox_connect);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1060, 720);
            this.Name = "Form1";
            this.Text = "WiFi Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip_list_view.ResumeLayout(false);
            this.groupBox_connect.ResumeLayout(false);
            this.groupBox_connect.PerformLayout();
            this.groupBox_current_connection.ResumeLayout(false);
            this.groupBox_current_connection.PerformLayout();
            this.statusStrip_main.ResumeLayout(false);
            this.statusStrip_main.PerformLayout();
            this.contextMenuStrip_notify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox_connect;
        private System.Windows.Forms.GroupBox groupBox_current_connection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_SSID;
        private System.Windows.Forms.ColumnHeader columnHeader_SSID;
        private System.Windows.Forms.ColumnHeader columnHeader_Signal;
        private System.Windows.Forms.ColumnHeader columnHeader_Channel;
        private System.Windows.Forms.ColumnHeader columnHeader_Security;
        private System.Windows.Forms.ColumnHeader columnHeader_HasProfile;
        private System.Windows.Forms.ComboBox comboBox_connect_after;
        private System.Windows.Forms.Label label_connect_after;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_autoconnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_list_view;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.StatusStrip statusStrip_main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon_main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_notify;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.Timer timer_autorefresh;
        private System.Windows.Forms.Button button_autoconnect;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоподключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem забытьToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_autoconnect;
        private System.Windows.Forms.Timer timer_check_ap_status;
        private System.Windows.Forms.ToolStripMenuItem отключитьсяToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

