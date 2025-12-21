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
        public int SetHours { get; private set; }
        public int SetMinutes { get; private set; }
        public int SetSeconds { get; private set; }
        public InsideTimeMenu()
        {
            InitializeComponent();
        }
        private void okey_Click(object sender, EventArgs e)
        {
            string message;
            int takeHours, takeMinutes, takeSeconds; 
            try
            {
                takeHours = Convert.ToInt32(fieldHours.Text);     
            }
            catch (Exception error) 
            {
                fieldHours.Text = "";
                //errorField.Text = "Была введена строка в поле <Часы>";
                message = "Была введена строка в поле <Часы>";
                ErrorForm errorForm = new ErrorForm(message);
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
                //errorField.Text = "Была введена строка в поле <Минуты>";
                message = "Была введена строка в поле <Минуты>";
                ErrorForm errorForm = new ErrorForm(message);
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
                //errorField.Text = "Была введена строка в поле <Секунды>";
                message = "Была введена строка в поле <Секунды>";
                ErrorForm errorForm = new ErrorForm(message);
                errorForm.Show();
                return;
            }
            if (takeHours < 0)
            {
                fieldHours.Text = "";
                message = "Было введено число, которое меньше нуля";
                ErrorForm errorForm = new ErrorForm(message);
                errorForm.Show();
                return;
            }
            if (takeMinutes < 0)
            {
                takeHours += takeHours;
                fieldMinutes.Text = "";
                message = "Было введено число минут, которое меньше нуля";
                ErrorForm errorForm = new ErrorForm(message);
                errorForm.Show();
                return;
            }
            if (takeSeconds < 0)
            {
                fieldSeconds.Text = "";
                message = "Было введено число секунд, которое меньше нуля";
                ErrorForm errorForm = new ErrorForm(message);
                errorForm.Show();
                return;
            }
            takeMinutes += takeSeconds / 60;
            takeSeconds %= 60;
            takeHours += takeMinutes % 60;
            takeMinutes %= 60;
            takeHours %= 24;
            this.SetHours = takeHours;
            this.SetMinutes = takeMinutes;
            this.SetMinutes = takeSeconds;
            MainForm mForms = new MainForm();
            mForms.updateTime();
            this.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
