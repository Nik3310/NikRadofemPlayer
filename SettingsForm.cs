using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NikRadofemPlayerWindows
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string version = Application.ProductVersion;
            if (version.Contains("+"))
            {
                version = version.Split('+')[0];
            }

            lblVersion.Text = "Версия программы: " + version;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
