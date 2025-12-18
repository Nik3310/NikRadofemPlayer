using System;
using System.Collections.Generic; // Важно! Нужно для работы List
using System.Windows.Forms;

namespace NikRadofemPlayerWindows // Убедись, что тут имя твоего проекта
{
    public partial class HistoryForm : Form
    {
        // Изменяем эту строку: добавляем (List<string> history)
        public HistoryForm(List<string> history)
        {
            InitializeComponent();

            // Заполняем список на экране данными, которые нам передали
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