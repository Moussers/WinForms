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
    public partial class AlarmClock : Form
    {
        private string FileName { get; set; }
        private bool PlaySong { get; set; }
        private string Execution { get; set; }
        private System.Timers.Timer timer;
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Days { get; set; }
        public int Months { get; set; }
        public int Years { get; set; }
        public bool TurnOf { get; set; }
        WMPLib.WindowsMediaPlayer winPlayer;
        public AlarmClock()
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
            TurnOf = true;
        }
        private void InicializationMusicFile()
        {
            FileName = @"C:\\Users\\Sand\\source\\repos\\WinForms\\Clock\\Standart music\\Standart music in phone.mp3";
        }
        private void alarmClock_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs  e) 
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute 
                && currentTime.Second == userTime.Second && currentTime.Day == userTime.Day 
                && currentTime.Month == userTime.Month)
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
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblStatus.Text = "Запущен";
            lblStatus.BackColor = Color.Red;
            DateTime userTime = dateTimePicker.Value;
            Seconds = userTime.Second;
            Minutes = userTime.Minute;
            Hours = userTime.Hour;
            Days = userTime.Day;
            Months = userTime.Month;
            Years = userTime.Year;
            TurnOf = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "Остановлен";
            lblStatus.BackColor = SystemColors.Control;
            TurnOf = false;
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
