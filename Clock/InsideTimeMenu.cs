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
    public partial class InsideTimeMenu : Form
    {
        public InsideTimeMenu()
        {
            InitializeComponent();
        }
        private void okey_Click(object sender, EventArgs e)
        {
            int takeHours, takeMinutes, takeSeconds; 
            try
            {
                takeHours = Convert.ToInt32(fieldHours.Text);     
            }
            catch (Exception error) 
            {
                fieldHours.Text = "";
                MessageBox.Show(this, "Была введена строка в поле <Часы>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                takeMinutes = Convert.ToInt32(fieldMinutes.Text);
            }
            catch (Exception error) 
            {
                fieldMinutes.Text = "";
                MessageBox.Show(this, "Была введена строка в поле <Минуты>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                takeSeconds = Convert.ToInt32(fieldSeconds.Text);
            }
            catch (Exception error) 
            {
                fieldSeconds.Text = "";
                MessageBox.Show(this, "Была введена строка в поле <Секунды>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (takeHours < 0)
            {
                fieldHours.Text = "";
                MessageBox.Show(this, "Было введено число часов, которое меньше нуля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (takeMinutes < 0)
            {
                takeHours += takeHours;
                fieldMinutes.Text = "";
                MessageBox.Show(this, "Было введено число минут, которое меньше нуля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (takeSeconds < 0)
            {
                fieldSeconds.Text = "";
                MessageBox.Show(this, "Было введено число секунд, которое меньше нуля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            takeMinutes += takeSeconds / 60;
            takeSeconds %= 60;
            takeHours += takeMinutes % 60;
            takeMinutes %= 60;
            takeHours %= 24;
            //this.SetHours = takeHours;
            //this.SetMinutes = takeMinutes;
            //this.SetMinutes = takeSeconds;
            MainForm mForms = new MainForm();
            mForms.Hours = takeHours;
            mForms.Minutes = takeMinutes;
            mForms.Seconds = takeSeconds;
            mForms.updateTime();
            this.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
