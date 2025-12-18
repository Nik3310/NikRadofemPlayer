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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Просто закрываем окно настроек
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Получаем версию прямо из сборки программы (которая указана в свойствах проекта)
            string version = Application.ProductVersion;

            lblVersion.Text = "Версия программы: " + version;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
