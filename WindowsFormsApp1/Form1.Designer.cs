namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axMsRdpClient81 = new AxMSTSCLib.AxMsRdpClient8();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxIp = new System.Windows.Forms.ComboBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient81)).BeginInit();
            this.SuspendLayout();
            // 
            // axMsRdpClient81
            // 
            this.axMsRdpClient81.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMsRdpClient81.Enabled = true;
            this.axMsRdpClient81.Location = new System.Drawing.Point(0, 0);
            this.axMsRdpClient81.Name = "axMsRdpClient81";
            this.axMsRdpClient81.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMsRdpClient81.OcxState")));
            this.axMsRdpClient81.Size = new System.Drawing.Size(1920, 1080);
            this.axMsRdpClient81.TabIndex = 0;
            // 
            // button_connect
            // 
            this.button_connect.FlatAppearance.BorderSize = 0;
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_connect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_connect.Location = new System.Drawing.Point(151, 1000);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(133, 23);
            this.button_connect.TabIndex = 1;
            this.button_connect.TabStop = false;
            this.button_connect.Text = "Подключиться";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.BackColor = System.Drawing.SystemColors.Menu;
            this.button_disconnect.FlatAppearance.BorderSize = 0;
            this.button_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_disconnect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_disconnect.Location = new System.Drawing.Point(12, 1000);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(133, 23);
            this.button_disconnect.TabIndex = 2;
            this.button_disconnect.TabStop = false;
            this.button_disconnect.Text = "Отключиться";
            this.button_disconnect.UseVisualStyleBackColor = false;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_exit
            // 
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_exit.Location = new System.Drawing.Point(1775, 1000);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(133, 23);
            this.button_exit.TabIndex = 3;
            this.button_exit.TabStop = false;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1920, 187);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxIp
            // 
            this.comboBoxIp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxIp.FormattingEnabled = true;
            this.comboBoxIp.Items.AddRange(new object[] {
            "192.168.0.109",
            "192.168.0.150"});
            this.comboBoxIp.Location = new System.Drawing.Point(151, 969);
            this.comboBoxIp.Name = "comboBoxIp";
            this.comboBoxIp.Size = new System.Drawing.Size(133, 24);
            this.comboBoxIp.TabIndex = 5;
            // 
            // textBox_login
            // 
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(12, 970);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(133, 24);
            this.textBox_login.TabIndex = 6;
            this.textBox_login.Text = "kip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.comboBoxIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.axMsRdpClient81);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RDP Connector";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.axMsRdpClient81)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient8 axMsRdpClient81;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIp;
        private System.Windows.Forms.TextBox textBox_login;
    }
}

