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
        string Execution { get; set; }
        System.Timers.Timer timer;
        private int Hours { get; set; }
        private int Minutes { get; set; }
        private int Seconds { get; set; }
        public SettingsAlarm()
        {
            InitializeComponent();
        }

        private void SettingsAlarm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            lblCurretnTime.Text = DateTime.Now.ToLongTimeString();
            lblCurrentDate.Text = DateTime.Now.ToLongDateString();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs  e) 
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                UpdateLabel update = UpdateDataLabel;
                if(lblStatus.InvokeRequired)
                Invoke(update, lblStatus, "Стоп");
                MessageBox.Show("Будильник звонит", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lblStatus.BackColor = Color.White;
        }

        private void btnChoiceMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "Аудиофайл ()";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = openFile.FileName;
                Execution = Path.GetExtension(FileName);
                if (Execution != ".mp3")
                {
                    MessageBox.Show("Файл должен иметь формат расширение mp3", "Предупреждение", MessageBoxButtons.OK);
                    return;
                }
                lblPathToFile.Text = FileName.Substring(0, 14) + "...";
            }
        }
    }
}
