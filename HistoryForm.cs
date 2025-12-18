using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NikRadofemPlayerWindows
{
    public partial class HistoryForm : Form
    {
        public HistoryForm(List<string> history)
        {
            InitializeComponent();

            foreach (string track in history)
            {
                listBoxHistory.Items.Add(track);
            }

            // Если история пуста
            if (listBoxHistory.Items.Count == 0)
            {
                listBoxHistory.Items.Add("История пока пуста...");
            }
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}