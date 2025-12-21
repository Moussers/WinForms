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
            ErrorForm errorForm = new ErrorForm();
            int takeHours, takeMinutes, takeSeconds; 
            try
            {
                takeHours = Convert.ToInt32(fieldHours.Text);     
            }
            catch (Exception error) 
            {
                fieldHours.Text = "";
                //errorField.Text = "Была введена строка в поле <Часы>";
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
                errorForm.Show();
                return;
            }
            if (takeHours < 0)
            {
                fieldHours.Text = "";
                errorField.Text = "Было введено больше 23 или меньше нуля";
                return;
            }
            if (takeMinutes < 0)
            {
                takeHours += takeHours;
                fieldMinutes.Text = "";
                errorField.Text = "Было введено число минут, которое меньше нуля";
                return;
            }
            if (takeSeconds < 0)
            {
                fieldSeconds.Text = "";
                errorField.Text = "Было введено число минут, которое меньше нуля";
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
