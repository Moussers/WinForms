using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Clock
{
    public partial class AlarmsForm : Form
    {
        private int numberAlarms { get; set; }
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
            readSettings();
        }
        private void readSettingsAlarmList()
        {
            DirectoryInfo directory = new DirectoryInfo($"{Application.ExecutablePath}");
            DirectoryInfo currentDir = directory.Parent.Parent.Parent;
            if (currentDir != null && currentDir.Exists)
            {
                Directory.SetCurrentDirectory(currentDir.FullName);
                try
                {
                    Alarm alarm = new Alarm();
                    StreamReader reader = new StreamReader("SettingsAlarmList.ini");
                    bool successRead = int.TryParse(reader.ReadLine(), out int alarms);
                    if(successRead)
                    {
                        numberAlarms = alarms;
                    }
                    for (int i = 0; i < numberAlarms; ++i)
                    {
                        if (
                            int.TryParse(reader.ReadLine(), out int hours) &&
                            int.TryParse(reader.ReadLine(), out int minutes) &&
                            int.TryParse(reader.ReadLine(), out int seconds)
                            )
                        {
                            alarm.Time = new TimeSpan(hours, minutes, seconds);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка чтения данных из файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        //    if (int.TryParse(reader.ReadLine(), out int year) &&
                        //        int.TryParse(reader.ReadLine(), out int month) &&
                        //        int.TryParse(reader.ReadLine(),out int day)
                        //        )
                        //    {
                        //        alarm.Date = new DateTime(year, month, day);
                        //    }
                        //    listBoxAlarms.Items.Add(alarm);    
                    }
                    }
                catch (Exception ex) 
                {
                    MessageBox.Show("File settings not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void readSettings()
        {
            IniFile ini = new IniFile(@System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\..\\..\\" + "Alarms.ini");
            listBoxAlarms.Items.Clear();
            int k = 0;
            while (ini.KeyExists("year", "Alarm " + k.ToString()))
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
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AlarmDialog alarm = new AlarmDialog();
            if (alarm.ShowDialog() == DialogResult.OK)
            {
                listBoxAlarms.Items.Add(new Alarm(alarm.Alarm));
            }
        }
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
                ini.Write("filename", al.Filename.ToString(), "Alarm " + i.ToString());
            }
        }
        public void SaveSettingsAlarms()
        {
            DirectoryInfo directory = new DirectoryInfo($"{Application.ExecutablePath}");
            DirectoryInfo currentDir = directory.Parent.Parent.Parent;
            if(currentDir != null && currentDir.Exists)
            {
                Directory.SetCurrentDirectory(currentDir.FullName);
                StreamWriter writer = new StreamWriter("SettingsAlarmList.ini");
                numberAlarms = listBoxAlarms.Items.Count;
                writer.WriteLine(numberAlarms);
                for(int i = 0; i < numberAlarms; ++i)
                {
                    Alarm alarm = listBoxAlarms.Items[i] as Alarm;
                    if (alarm != null)
                    {
                        writer.WriteLine(alarm.Date.Year.ToString());
                        writer.WriteLine(alarm.Date.Month.ToString());
                        writer.WriteLine(alarm.Date.Day.ToString());
                        writer.WriteLine(alarm.Date.Day.ToString());
                        writer.WriteLine(alarm.Time.Hours.ToString());
                        writer.WriteLine(alarm.Time.Minutes.ToString());
                        writer.WriteLine(alarm.Time.Seconds.ToString());
                        writer.WriteLine(alarm.Filename.ToString());
                    }
                }
                writer.Close();
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
