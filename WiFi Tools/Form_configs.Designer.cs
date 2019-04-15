namespace WiFi_Tools
{
    partial class Form_configs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_configs));
            this.groupBox_connect = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_connect_after = new System.Windows.Forms.Label();
            this.checkBox_connect_force = new System.Windows.Forms.CheckBox();
            this.button_show_pwd = new System.Windows.Forms.Button();
            this.checkBox_remember_pwd = new System.Windows.Forms.CheckBox();
            this.label_pwd_set = new System.Windows.Forms.Label();
            this.textBox_pwd_set = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.groupBox_connect.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_connect
            // 
            this.groupBox_connect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox_connect.Controls.Add(this.comboBox1);
            this.groupBox_connect.Controls.Add(this.button2);
            this.groupBox_connect.Controls.Add(this.label_connect_after);
            this.groupBox_connect.Controls.Add(this.checkBox_connect_force);
            this.groupBox_connect.Controls.Add(this.button_show_pwd);
            this.groupBox_connect.Controls.Add(this.checkBox_remember_pwd);
            this.groupBox_connect.Controls.Add(this.label_pwd_set);
            this.groupBox_connect.Controls.Add(this.textBox_pwd_set);
            this.groupBox_connect.Controls.Add(this.button_connect);
            this.groupBox_connect.Location = new System.Drawing.Point(12, 12);
            this.groupBox_connect.Name = "groupBox_connect";
            this.groupBox_connect.Size = new System.Drawing.Size(277, 210);
            this.groupBox_connect.TabIndex = 5;
            this.groupBox_connect.TabStop = false;
            this.groupBox_connect.Text = "Автоподключение";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5 с",
            "10 с",
            "30 с",
            "1 м",
            "2 м",
            "5 м",
            "15 м",
            "30 м"});
            this.comboBox1.Location = new System.Drawing.Point(146, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_connect_after
            // 
            this.label_connect_after.AutoSize = true;
            this.label_connect_after.Location = new System.Drawing.Point(4, 141);
            this.label_connect_after.Name = "label_connect_after";
            this.label_connect_after.Size = new System.Drawing.Size(136, 17);
            this.label_connect_after.TabIndex = 5;
            this.label_connect_after.Text = "Подключать после:";
            // 
            // checkBox_connect_force
            // 
            this.checkBox_connect_force.AutoSize = true;
            this.checkBox_connect_force.Location = new System.Drawing.Point(7, 108);
            this.checkBox_connect_force.Name = "checkBox_connect_force";
            this.checkBox_connect_force.Size = new System.Drawing.Size(216, 21);
            this.checkBox_connect_force.TabIndex = 4;
            this.checkBox_connect_force.Text = "Подключать принудительно";
            this.checkBox_connect_force.UseVisualStyleBackColor = true;
            // 
            // button_show_pwd
            // 
            this.button_show_pwd.Image = global::WiFi_Tools.Properties.Resources.ShowPWD_small_small;
            this.button_show_pwd.Location = new System.Drawing.Point(230, 48);
            this.button_show_pwd.Name = "button_show_pwd";
            this.button_show_pwd.Size = new System.Drawing.Size(41, 27);
            this.button_show_pwd.TabIndex = 3;
            this.button_show_pwd.UseVisualStyleBackColor = true;
            // 
            // checkBox_remember_pwd
            // 
            this.checkBox_remember_pwd.AutoSize = true;
            this.checkBox_remember_pwd.Location = new System.Drawing.Point(7, 81);
            this.checkBox_remember_pwd.Name = "checkBox_remember_pwd";
            this.checkBox_remember_pwd.Size = new System.Drawing.Size(150, 21);
            this.checkBox_remember_pwd.TabIndex = 2;
            this.checkBox_remember_pwd.Text = "Сохранить пароль";
            this.checkBox_remember_pwd.UseVisualStyleBackColor = true;
            // 
            // label_pwd_set
            // 
            this.label_pwd_set.AutoSize = true;
            this.label_pwd_set.Location = new System.Drawing.Point(6, 28);
            this.label_pwd_set.Name = "label_pwd_set";
            this.label_pwd_set.Size = new System.Drawing.Size(61, 17);
            this.label_pwd_set.TabIndex = 1;
            this.label_pwd_set.Text = "Пароль:";
            // 
            // textBox_pwd_set
            // 
            this.textBox_pwd_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pwd_set.Location = new System.Drawing.Point(7, 48);
            this.textBox_pwd_set.Name = "textBox_pwd_set";
            this.textBox_pwd_set.Size = new System.Drawing.Size(217, 27);
            this.textBox_pwd_set.TabIndex = 0;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(141, 167);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(130, 37);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Подключиться";
            this.button_connect.UseVisualStyleBackColor = true;
            // 
            // Form_configs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_configs";
            this.Text = "Настройки";
            this.groupBox_connect.ResumeLayout(false);
            this.groupBox_connect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_connect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_connect_after;
        private System.Windows.Forms.CheckBox checkBox_connect_force;
        private System.Windows.Forms.Button button_show_pwd;
        private System.Windows.Forms.CheckBox checkBox_remember_pwd;
        private System.Windows.Forms.Label label_pwd_set;
        private System.Windows.Forms.TextBox textBox_pwd_set;
        private System.Windows.Forms.Button button_connect;
    }
}