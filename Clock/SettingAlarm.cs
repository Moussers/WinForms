using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class SettingsAlarm : Form
    {
        string FileName { get; set; }
        private bool PlaySong { get; set; }
        private string Execution { get; set; }
        private System.Timers.Timer timer;
        private int Hours { get; set; }
        private int Minutes { get; set; }
        private int Seconds { get; set; }
        WMPLib.WindowsMediaPlayer winPlayer;
        public SettingsAlarm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point
                (
                Screen.PrimaryScreen.Bounds.Width - this.Width - 500,
                50
                );
            winPlayer = new WMPLib.WindowsMediaPlayer();
            InicializationMusicFile();
        }
        private void InicializationMusicFile()
        {
            FileName = @"C:\\Users\\Sand\\source\\repos\\WinForms\\Clock\\Standart music\\Standart music in phone.mp3";
        }
        private void SettingsAlarm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs  e) 
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second && currentTime.Day == userTime.Day)
            {
                timer.Stop();
                UpdateLabel update = UpdateDataLabel;
                if (lblStatus.InvokeRequired)
                {
                    Invoke(update, lblStatus, "Стоп");
                    winPlayer.URL = FileName;
                    winPlayer.settings.volume = 100;
                    winPlayer.controls.play();
                    PlaySong = true;
                    if (MessageBox.Show("Будильник звонит", "Сообщение", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        winPlayer.controls.stop();
                        lblStatus.Text = "Выключен";
                        lblStatus.BackColor = SystemColors.Control;
                    }
                }
            }
        }

        delegate void UpdateLabel(Label lbl, string value);
        void UpdateDataLabel(Label lbl, string value) 
        {
            lbl.Text = value;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblStatus.Text = "Запущен";
            lblStatus.BackColor = Color.Red;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "Остановлен";
            lblStatus.BackColor = SystemColors.Control;
        }

        private void btnChoiceMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = openFile.FileName;
                Execution = Path.GetExtension(FileName);
                if (Execution != ".mp3")
                {
                    MessageBox.Show("Файл должен иметь формат расширение mp3", "Предупреждение", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    lblPathToFile.Text = FileName.Substring(0, 14) + "...";
                }
            }
        }
    }
}
