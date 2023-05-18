using AxMSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_connect_Click(object sender, EventArgs e)
        {
            axMsRdpClient81.ColorDepth = 16;
            axMsRdpClient81.DesktopWidth = 1920;
            axMsRdpClient81.DesktopHeight = 1080;

            axMsRdpClient81.Server = comboBoxIp.GetItemText(comboBoxIp.SelectedItem);
            axMsRdpClient81.UserName = textBox_login.Text.ToString();
            axMsRdpClient81.AdvancedSettings7.EnableCredSspSupport = true;

            axMsRdpClient81.Connect();

            label1.Visible = false;
            button_connect.Visible = false;
            comboBoxIp.Visible = false;
            textBox_login.Visible = false;
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            if(axMsRdpClient81.Connected.ToString() == "1")
            {
                axMsRdpClient81.Disconnect();

                label1.Visible = true;
                button_connect.Visible = true;
                comboBoxIp.Visible = true;
                textBox_login.Visible = true;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (axMsRdpClient81.Connected.ToString() == "0")
            {
                Application.Exit();
            } 
            else if (axMsRdpClient81.Connected.ToString() == "1")
            {
                axMsRdpClient81.Disconnect();
                Application.Exit();
            }
        }
    }
}
