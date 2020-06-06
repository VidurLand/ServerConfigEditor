using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServerConfigEditor
{
    public partial class FormServerConnector : Form
    {
        public FormServerConnector()
        {
            InitializeComponent();
        }

        private void FormServerConnector_Activated(object sender, EventArgs e)
        {
            RootPassword.Text = Properties.Settings.Default.UserPassword;
            ServerIP.Text = Properties.Settings.Default.ServerIP;
            ServerPort.Text = Properties.Settings.Default.PortIP.ToString();
            // сохраняем переменные
            Properties.Settings.Default.Save();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPassword = RootPassword.Text;
            Properties.Settings.Default.ServerIP = ServerIP.Text;
            Properties.Settings.Default.PortIP = Convert.ToInt32(ServerPort.Text);
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
