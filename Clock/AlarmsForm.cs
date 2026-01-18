using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class AlarmsForm : Form
    {
        //AlarmDialog alarm;
        public ListBox List { get => listBoxAlarms; }
        public AlarmsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point
                (
                    Screen.PrimaryScreen.Bounds.Width - this.Width - 25,
                    Screen.PrimaryScreen.Bounds.Height - this.Height - 560

                );
            IniFile ini = new IniFile(@System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\..\\..\\" + "Alarms.ini");
            listBoxAlarms.Items.Clear();
            int k = 0;
            while (ini.KeyExists("year","Alarm " + k.ToString()))
            {
                Alarm al = new Alarm();
                al.Time = new TimeSpan(Int32.Parse(ini.Read("hours", "Alarm " + k.ToString())), Int32.Parse(ini.Read("minutes", "Alarm " + k.ToString())), Int32.Parse(ini.Read("seconds", "Alarm " + k.ToString())));
                al.Date = new DateTime(Int32.Parse(ini.Read("year", "Alarm " + k.ToString())), Int32.Parse(ini.Read("month", "Alarm " + k.ToString())), Int32.Parse(ini.Read("day", "Alarm " + k.ToString())));
                if (al.Date.Year == 9999)
                    al.Date = DateTime.Now;
                al.Filename = ini.Read("filename", "Alarm " + k.ToString());
                listBoxAlarms.Items.Add(al);
                k = k + 1;
            }
            //alarm = new AlarmDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AlarmDialog alarm = new AlarmDialog();
            if (alarm.ShowDialog() == DialogResult.OK)
            {
                listBoxAlarms.Items.Add(new Alarm(alarm.Alarm));
            }
        }
        /*public void SaveSettingsAlarms()
        { 
            DirectoryInfo directory = new DirectoryInfo(Application.ExecutablePath);
            DirectoryInfo currentDir = directory.Parent.Parent.Parent;
            if (currentDir != null && currentDir.Exists)
            {
                Directory.SetCurrentDirectory(currentDir.FullName);
                StreamWriter writer = new StreamWriter("Alarms.ini");
                writer.WriteLine(this.Location.X);
                writer.WriteLine(this.Location.Y);
                //writer.WriteLine(listBoxAlarms.SelectedItem.ToString());
                writer.Close();
            }
        }*/
        public void SaveSettingsAlarm()
        {
            IniFile ini = new IniFile(@System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\..\\..\\" + "Alarms.ini");
            for (int i = 0; i < listBoxAlarms.Items.Count; i++)
            {
                Alarm al = listBoxAlarms.Items[i] as Alarm;
                ini.Write("year", al.Date.Year.ToString(), "Alarm " + i.ToString());
                ini.Write("month", al.Date.Month.ToString(), "Alarm " + i.ToString());
                ini.Write("day", al.Date.Day.ToString(), "Alarm " + i.ToString());
                ini.Write("hours", al.Time.Hours.ToString(), "Alarm " + i.ToString());
                ini.Write("minutes", al.Time.Minutes.ToString(), "Alarm " + i.ToString());
                ini.Write("seconds", al.Time.Seconds.ToString(), "Alarm " + i.ToString());
                ini.Write("filename", al.Filename, "Alarm " + i.ToString());
            }
        }
        private void listBoxAlarms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxAlarms.Items.Count > 0 && listBoxAlarms.SelectedItems != null)
            {
                AlarmDialog alarm = new AlarmDialog(listBoxAlarms.SelectedItem as Alarm);
                alarm.ShowDialog();
                listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = new Alarm(alarm.Alarm);
            }
            else
            {
                buttonAdd_Click(sender, e);
            }
        }
    }
}
