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
            ErrorForm errorForm = new ErrorForm();
            int takeHours, takeMinutes, takeSeconds; 
            try
            {
                takeHours = Convert.ToInt32(fieldHours.Text);     
            }
            catch (Exception error) 
            {
                fieldHours.Text = "";
                errorForm.strMessError.Text = "Была введена строка в поле <Часы>";
                errorForm.Show();
                return;
            }
            try
            {
                takeMinutes = Convert.ToInt32(fieldMinutes.Text);
            }
            catch (Exception error) 
            {
                fieldMinutes.Text = "";
                //message = "Была введена строка в поле <Минуты>";
                errorForm.strMessError.Text = "Была введена строка в поле <Минуты>";
                errorForm.Show();
                return;
            }
            try
            {
                takeSeconds = Convert.ToInt32(fieldSeconds.Text);
            }
            catch (Exception error) 
            {
                fieldSeconds.Text = "";
                //message = "Была введена строка в поле <Секунды>";
                errorForm.strMessError.Text = "Была введена строка в поле <Секунды>"; 
                errorForm.Show();
                return;
            }
            if (takeHours < 0)
            {
                fieldHours.Text = "";
                //message = "Было введено число, которое меньше нуля";
                errorForm.strMessError.Text = "Было введено число часов, которое меньше нуля";
                errorForm.Show();
                return;
            }
            if (takeMinutes < 0)
            {
                takeHours += takeHours;
                fieldMinutes.Text = "";
                //message = "Было введено число минут, которое меньше нуля";
                errorForm.strMessError.Text = "Было введено число минут, которое меньше нуля";
                errorForm.Show();
                return;
            }
            if (takeSeconds < 0)
            {
                fieldSeconds.Text = "";
                //message = "Было введено число секунд, которое меньше нуля";
                errorForm.strMessError.Text = "Было введено число секунд, которое меньше нуля";
                errorForm.Show();
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
