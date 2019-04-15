using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WiFi_Tools
{
    public partial class Form_jornal : Form
    {
        public Form_jornal()
        {
            InitializeComponent();
        }

        private void Form_jornal_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(Logger.GetFullTextFileName());
        }
    }
}
