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
        private DataGridView dataGrid;
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            SetVisibility(false);
        }
        void SetVisibility(bool visible) 
        {
            cbShowDate.Visible = visible;
            cbShowWeekday.Visible = visible;
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
            if (cbShowWeekday.Checked) 
            {
                labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
            }
            notifyIcon.Text = labelTime.Text;
        }
        private void btnHideControls_Click(object sender, EventArgs e)
        {
            SetVisibility(tsmiShowControls.Checked = false);
        }

        //private void labelTime_MouseHover(object sender, EventArgs e)
        //{
        //    SetVisibility(true);
        //}

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (!TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void tsmiTopmost_Click(object sender, EventArgs e) => this.TopMost = tsmiTopmost.Checked;

        private void tsmiShowControls_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility((sender as ToolStripMenuItem).Checked);
            //Sender - это отправитель события (Control, который прислал событие).
            //Если на элемент окна (Control) воздействует пользователь при помощи клавиатуры или мыши,
            //этот Control отправляет событие своему родителю, 
            //а родитель может обрабатывать, или не обрабатывать это событие.
        }

        private void tsmiShowDate_CheckedChanged(object sender, EventArgs e) => cbShowDate.Checked = tsmiShowDate.Checked;

        private void cbShowDate_CheckedChanged(object sender, EventArgs e) => tsmiShowDate.Checked = cbShowDate.Checked;

        private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e) => cbShowWeekday.Checked = tsmiShowWeekday.Checked;

        private void cbShowWeekday_CheckedChanged(object sender, EventArgs e) => tsmiShowWeekday.Checked = cbShowWeekday.Checked;

        private void tsmiQuit_Click(object sender, EventArgs e) => this.Close();

        private void tsmiRedFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void tsmiBrownFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Brown;
        }
        private void tsmiOrangeFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Orange;
        }

        private void tsmiYellowFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Yellow;
        }

        private void tsmiGreenFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Green;
        }
        private void tsmiGreyFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Gray;
        }
        private void tsmiBlueArea_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Blue;
        }
        private void tsmiLightBlueFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.LightBlue;
        }

        private void tsmiDarkBlueFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkBlue;
        }

        private void tsmiVioletFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Violet;
        }

        private void tsmiBlackFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void tsmiPinkFont_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Pink;
        }

        private void tsmiRedArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        private void tsmiWhiteColor_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
        }
        private void tsmiBrownArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
        }

        private void tsmiOrangeArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void tsmiYellowArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void tsmiGreenArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
        private void tsmiGreyArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
        private void tmsiLightBlueArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void tsmiDarkBlueArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
        }

        private void tsmiVioletArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Violet;
        }

        private void tsmiBlackArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void tsmiBlueArea_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void tsmiWhiteArea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

    }
}
