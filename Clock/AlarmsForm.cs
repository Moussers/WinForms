using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public void SaveSettingsAlarms()
        { 
            DirectoryInfo directory = new DirectoryInfo(Application.ExecutablePath);
            DirectoryInfo currentDir = directory.Parent.Parent.Parent;
            if (currentDir != null && currentDir.Exists)
            {
                Directory.SetCurrentDirectory(currentDir.FullName);
                StreamWriter writer = new StreamWriter("SavingSettingsAlarms.ini");
                writer.WriteLine(this.Location.X);
                writer.WriteLine(this.Location.Y);
                writer.WriteLine(listBoxAlarms.SelectedItem.ToString());
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
