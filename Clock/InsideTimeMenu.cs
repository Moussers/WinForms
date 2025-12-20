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
                errorField.Text = "Была введена строка в поле <Часы>";
                return;
            }
            try
            {
                takeMinutes = Convert.ToInt32(fieldMinutes.Text);
            }
            catch (Exception error) 
            {
                fieldMinutes.Text = "";
                errorField.Text = "Была введена строка в поле <Минуты>";
                return;
            }
            try
            {
                takeSeconds = Convert.ToInt32(fieldSeconds.Text);
            }
            catch (Exception error) 
            {
                fieldSeconds.Text = "";
                errorField.Text = "Была введена строка в поле <Секунды>";
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

            MainForm mForm = new MainForm();
            //mForm.
        }
    }
}
