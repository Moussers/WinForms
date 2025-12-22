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
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        void SetVisible(bool visible) 
        {
            cbShowDate.Visible = visible;
            cbShowWeelDay.Visible = visible;
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
            if (cbShowWeelDay.Checked) 
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

        private void showWeekdayeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
