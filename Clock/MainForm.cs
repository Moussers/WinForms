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
    public partial class MainForm : Form
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        public MainForm()
        {            
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point
                (
                Screen.PrimaryScreen.Bounds.X,
                Screen.PrimaryScreen.Bounds.Y
                );
            this.MouseClick += ContextMenu_MouseClick;
        }
        public int Hours
        {
            set { _hours = value; }
            private get { return _hours; }
        }
        public int Minutes 
        {
            set { _minutes = value; }
            private get { return _minutes; }
        }
        public int Seconds 
        {
            set { _seconds = value; }
            private get { return _seconds; }
        }
        public void updateTime() 
        {
            DateTime dateTime = new DateTime
                (
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day,
                    Hours,
                    Minutes,
                    Seconds
                );
            labelTime.Text = dateTime.ToString("hh:mm:ss tt");
        }
        void SetVisible(bool visible) 
        {
            cbShowDate.Visible = visible;
            cbShowWeekDay.Visible = visible;
            btnHideControls.Visible = visible;
            this.ShowInTaskbar = visible;
            this.FormBorderStyle = visible ? FormBorderStyle.FixedSingle: FormBorderStyle.None;
            this.TransparencyKey = visible ? Color.Empty: this.BackColor;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString
                (
                "hh:mm:ss tt",
                System.Globalization.CultureInfo.InvariantCulture
                );
            if (cbShowDate.Checked) 
            {
                labelTime.Text += "\n";
                labelTime.Text += DateTime.Now.ToString("yyyy.MM.dd");
            }
            if (cbShowWeekDay.Checked) 
            {
                labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
            }
            notifyIcon.Text = labelTime.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetVisible(false);
        }

        private void labelTime_MouseHover(object sender, EventArgs e)
        {
            SetVisible(true);
        }
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
        }
        private void startTime_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void stopTime_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void restartMenu_Click(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }
        private void ContextMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {
                ContextMenu.Show(this, e.Location);
            }
        }
        private void SetTime_Click(object sender, EventArgs e)
        {
            InsideTimeMenu timeMenu = new InsideTimeMenu();
            if (timeMenu.ShowDialog() == DialogResult.OK) 
            {
                timeMenu.Show();
            } 
        }
        private void closePopUpMenu_Click(object sender, EventArgs e)
        {
            ContextMenu.Close();
        }
    }
}
