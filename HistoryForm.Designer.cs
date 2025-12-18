namespace NikRadofemPlayerWindows
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            listBoxHistory = new ListBox();
            SuspendLayout();
            // 
            // listBoxHistory
            // 
            listBoxHistory.BackColor = Color.FromArgb(18, 18, 18);
            listBoxHistory.BorderStyle = BorderStyle.None;
            listBoxHistory.Font = new Font("Inter 28pt 28pt Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBoxHistory.ForeColor = SystemColors.Control;
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.Location = new Point(12, 6);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(776, 437);
            listBoxHistory.TabIndex = 0;
            listBoxHistory.SelectedIndexChanged += listBoxHistory_SelectedIndexChanged;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxHistory);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HistoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "История треков";
            Load += HistoryForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxHistory;
    }
}