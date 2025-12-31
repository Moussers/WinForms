using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class SettingsAlarm : Form
    {
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
                try
                {

                }
                catch (Exception ex) { };
                UpdateLabel update = UpdateDataLabel;
                if(lblStatus.InvokeRequired)
                Invoke(update, lblStatus, "Stop");
                MessageBox.Show("Ring ring ring...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lblStatus.Text = "Runing";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "Stop";
        }
    }
}
