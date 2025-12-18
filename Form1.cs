using NAudio.Wave; 
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikRadofemPlayerWindows
{
    public partial class Form1 : Form
    {
        // Player
        private IWavePlayer waveOut;
        private MediaFoundationReader audioFileReader;
        private bool isPlaying = false;
        private const string StreamUrl = "https://live.nikradofem.online/live";
        private const string StatsUrl = "https://live.nikradofem.online/status-json.xsl";

        // History
        private List<string> trackHistory = new List<string>();
        private string lastTrackName = "";
        public Form1()
        {
            InitializeComponent();
            try
            {
                FontHelper.LoadFont("NikRadofemPlayerWindows.Fonts.NEOPIXEL.ttf");
                lblTrackName.Font = FontHelper.GetFont(28f, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить шрифт: " + ex.Message);
            }

            // --- DISAIN ---

            // 1. TrackName
            lblTrackName.Parent = pictureBox5;
            lblTrackName.BackColor = Color.Transparent;
            lblTrackName.AutoSize = false;
            lblTrackName.Size = pictureBox5.Size;
            lblTrackName.Location = new Point(0, 0);
            lblTrackName.TextAlign = ContentAlignment.MiddleCenter;

            // 2. TrackBar
            modernTrackBar1.Parent = pictureBox4;
            modernTrackBar1.BackColor = Color.FromArgb(16, 16, 16);
            modernTrackBar1.TrackColor = Color.FromArgb(60, 60, 60);
            modernTrackBar1.ProgressColor = Color.FromArgb(0, 255, 0);
            modernTrackBar1.Height = 30;
            modernTrackBar1.Scroll += ModernTrackBar1_Scroll;
            modernTrackBar1.Value = NikRadofemPlayerWindows.Properties.Settings.Default.UserVolume;

            // 3. Play button
            btnPlayPausePicture.Parent = pictureBox4;
            btnPlayPausePicture.BackColor = Color.Transparent;
            btnPlayPausePicture.BringToFront();

            // Place
            modernTrackBar1.Location = new Point(
                (pictureBox4.Width - modernTrackBar1.Width) / 2,
                pictureBox5.Bottom - 60
            );

            btnPlayPausePicture.Location = new Point(
                (pictureBox4.Width - btnPlayPausePicture.Width) / 2,
                modernTrackBar1.Bottom + 10
                );

            // Timer
            timer1.Interval = 5000;
            timer1.Tick += Timer1_Tick;

            // Volume saves
            int savedVolume = NikRadofemPlayerWindows.Properties.Settings.Default.UserVolume;
            modernTrackBar1.Value = savedVolume;
        }

        private void PlayRadio()
        {
            try
            {
                audioFileReader = new MediaFoundationReader(StreamUrl);
                waveOut = new WaveOutEvent();
                waveOut.Init(audioFileReader);

                if (modernTrackBar1 != null)
                    waveOut.Volume = modernTrackBar1.Value / 100f;

                waveOut.Play();
                isPlaying = true;

                btnPlayPausePicture.Image =
                NikRadofemPlayerWindows.Properties.Resources.pause_icon;

                // Memory TrackName reset
                lastTrackName = "";

                // Loading
                lblTrackName.Text = "Загрузка...";

                timer1.Start();
                GetTrackName();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void StopRadio()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }

            isPlaying = false;

            btnPlayPausePicture.Image =
            NikRadofemPlayerWindows.Properties.Resources.play_icon;

            lblTrackName.Text = "Радио выключено";
            timer1.Stop();
        }

        // TrackName restore
        private async void Timer1_Tick(object sender, EventArgs e)
        {
            await GetTrackName();
        }
        private async Task GetTrackName()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonResponse = await client.GetStringAsync(StatsUrl);
                    using (JsonDocument doc = JsonDocument.Parse(jsonResponse))
                    {
                        var root = doc.RootElement;
                        if (root.TryGetProperty("icestats", out var icestats))
                        {
                            if (icestats.TryGetProperty("source", out var source))
                            {
                                JsonElement currentSource;
                                if (source.ValueKind == JsonValueKind.Array)
                                    currentSource = source[0];
                                else
                                    currentSource = source;

                                if (currentSource.TryGetProperty("title", out var titleElement))
                                {
                                    string currentTitle = titleElement.GetString();

                                    if (!string.IsNullOrEmpty(currentTitle) && currentTitle != lastTrackName)
                                    {
                                        if (!string.IsNullOrEmpty(lastTrackName) && lastTrackName != "Загрузка...")
                                        {
                                            string time = DateTime.Now.ToString("HH:mm");
                                            trackHistory.Insert(0, $"[{time}] {lastTrackName}");

                                            if (trackHistory.Count > 20)
                                            {
                                                trackHistory.RemoveAt(trackHistory.Count - 1);
                                            }
                                        }
                                        lastTrackName = currentTitle;
                                        lblTrackName.Text = currentTitle;
                                        notifyIcon1.ShowBalloonTip(3000, "Сейчас играет:", currentTitle, ToolTipIcon.Info);
                                    }
                                    else if (string.IsNullOrEmpty(currentTitle))
                                    {
                                        lblTrackName.Text = "Нет данных";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            NikRadofemPlayerWindows.Properties.Settings.Default.UserVolume = modernTrackBar1.Value;
            NikRadofemPlayerWindows.Properties.Settings.Default.Save();

            StopRadio();
            base.OnFormClosing(e);
        }

        private void ModernTrackBar1_Scroll(object sender, EventArgs e)
        {
            NikRadofemPlayerWindows.Properties.Settings.Default.UserVolume = modernTrackBar1.Value;
            NikRadofemPlayerWindows.Properties.Settings.Default.Save();

            if (waveOut != null)
            {
                waveOut.Volume = modernTrackBar1.Value / 100f;
            }
        }

        private void lblTrackName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://tunein.com/radio/NikRadofem-s346252/";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть ссылку: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/Nik3310_Offical";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть ссылку: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string url = "https://aboutnikkk.carrd.co/";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть ссылку: " + ex.Message);
            }
        }

        private void btnPlayPausePicture_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                StopRadio();
            }
            else
            {
                PlayRadio();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsWindow = new SettingsForm();
            settingsWindow.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Плейлист (*.m3u)|*.m3u"; // Only save .m3u file
                saveDialog.FileName = "NikRadofem.m3u";       // Defalt name for .m3u
                saveDialog.Title = "Сохранить плейлист радио";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string m3uContent = "#EXTM3U\n" +
                                            "#EXTINF:-1,NikRadofem Radio\n" +
                                            StreamUrl;
                        System.IO.File.WriteAllText(saveDialog.FileName, m3uContent);

                        MessageBox.Show("Файл успешно сохранен!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyWindow = new HistoryForm(trackHistory);
            historyWindow.ShowDialog();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            string url = "https://www.donationalerts.com/r/nik33105";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть ссылку: " + ex.Message);
            }
        }
    }
}