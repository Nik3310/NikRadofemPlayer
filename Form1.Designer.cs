
namespace NikRadofemPlayerWindows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTrackName = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnPlayPausePicture = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBoxSettings = new PictureBox();
            pictureBox6 = new PictureBox();
            btnDownload = new PictureBox();
            btnHistory = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            pictureBox7 = new PictureBox();
            btnDonate = new PictureBox();
            modernTrackBar1 = new ModernTrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPlayPausePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDownload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDonate).BeginInit();
            SuspendLayout();
            // 
            // lblTrackName
            // 
            lblTrackName.AutoSize = true;
            lblTrackName.BackColor = Color.Transparent;
            lblTrackName.Font = new Font("NEOPIXEL", 29F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTrackName.ForeColor = SystemColors.Control;
            lblTrackName.Location = new Point(107, 115);
            lblTrackName.Name = "lblTrackName";
            lblTrackName.Size = new Size(595, 47);
            lblTrackName.TabIndex = 1;
            lblTrackName.Text = "Нажмите кнопку для старта";
            lblTrackName.TextAlign = ContentAlignment.MiddleCenter;
            lblTrackName.Click += lblTrackName_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.tunein_icon;
            pictureBox1.Location = new Point(22, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.telegram_icon;
            pictureBox2.Location = new Point(67, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.portfolio_icon;
            pictureBox3.Location = new Point(110, 403);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnPlayPausePicture
            // 
            btnPlayPausePicture.BackColor = Color.Transparent;
            btnPlayPausePicture.Cursor = Cursors.Hand;
            btnPlayPausePicture.Image = (Image)resources.GetObject("btnPlayPausePicture.Image");
            btnPlayPausePicture.Location = new Point(369, 237);
            btnPlayPausePicture.Name = "btnPlayPausePicture";
            btnPlayPausePicture.Size = new Size(75, 75);
            btnPlayPausePicture.SizeMode = PictureBoxSizeMode.Zoom;
            btnPlayPausePicture.TabIndex = 6;
            btnPlayPausePicture.TabStop = false;
            btnPlayPausePicture.Click += btnPlayPausePicture_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.player_border;
            pictureBox4.Location = new Point(22, 69);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(756, 285);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(16, 16, 16);
            pictureBox5.Image = Properties.Resources.player_part1;
            pictureBox5.Location = new Point(22, 84);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(753, 112);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBoxSettings
            // 
            pictureBoxSettings.BackColor = Color.FromArgb(17, 17, 17);
            pictureBoxSettings.Cursor = Cursors.Hand;
            pictureBoxSettings.Image = Properties.Resources.settings_icon;
            pictureBoxSettings.Location = new Point(744, 403);
            pictureBoxSettings.Name = "pictureBoxSettings";
            pictureBoxSettings.Size = new Size(34, 35);
            pictureBoxSettings.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSettings.TabIndex = 9;
            pictureBoxSettings.TabStop = false;
            pictureBoxSettings.Click += pictureBoxSettings_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(12, 12, 12);
            pictureBox6.Image = Properties.Resources.logowithtext;
            pictureBox6.Location = new Point(22, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(267, 61);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Transparent;
            btnDownload.Cursor = Cursors.Hand;
            btnDownload.Image = Properties.Resources.player_buttonM3U;
            btnDownload.Location = new Point(631, 304);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(140, 35);
            btnDownload.SizeMode = PictureBoxSizeMode.Zoom;
            btnDownload.TabIndex = 11;
            btnDownload.TabStop = false;
            btnDownload.Click += pictureBox7_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(17, 17, 17);
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.Image = Properties.Resources.tracklist_icon;
            btnHistory.Location = new Point(703, 403);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(35, 35);
            btnHistory.SizeMode = PictureBoxSizeMode.Zoom;
            btnHistory.TabIndex = 12;
            btnHistory.TabStop = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "NikRadofem";
            notifyIcon1.Visible = true;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(17, 17, 17);
            pictureBox7.Location = new Point(-6, 392);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(814, 120);
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // btnDonate
            // 
            btnDonate.Cursor = Cursors.Hand;
            btnDonate.Image = Properties.Resources.donate_icon;
            btnDonate.Location = new Point(688, 12);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(100, 35);
            btnDonate.SizeMode = PictureBoxSizeMode.Zoom;
            btnDonate.TabIndex = 14;
            btnDonate.TabStop = false;
            btnDonate.Click += btnDonate_Click;
            // 
            // modernTrackBar1
            // 
            modernTrackBar1.Location = new Point(248, 202);
            modernTrackBar1.Maximum = 100;
            modernTrackBar1.Name = "modernTrackBar1";
            modernTrackBar1.ProgressColor = Color.Lime;
            modernTrackBar1.Size = new Size(314, 23);
            modernTrackBar1.TabIndex = 15;
            modernTrackBar1.Text = "modernTrackBar1";
            modernTrackBar1.ThumbColor = Color.White;
            modernTrackBar1.TrackColor = Color.FromArgb(64, 64, 64);
            modernTrackBar1.Value = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(modernTrackBar1);
            Controls.Add(btnDonate);
            Controls.Add(btnHistory);
            Controls.Add(btnDownload);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBoxSettings);
            Controls.Add(lblTrackName);
            Controls.Add(pictureBox5);
            Controls.Add(btnPlayPausePicture);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox7);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NikRadofem";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPlayPausePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDownload).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDonate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private Label lblTrackName;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox btnPlayPausePicture;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBoxSettings;
        private PictureBox pictureBox6;
        private PictureBox btnDownload;
        private PictureBox btnHistory;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox7;
        private PictureBox btnDonate;
        private ModernTrackBar modernTrackBar1;
    }
}
