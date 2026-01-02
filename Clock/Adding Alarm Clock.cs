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
    public partial class AddingAlarm : Form
    {
        private static int ID { get; set; }
        private Dictionary<int, AlarmClock> dictAlarms;
        private AlarmClock alarmClock;
        public AddingAlarm()
        {
            InitializeComponent();
            dictAlarms = new Dictionary<int, AlarmClock>();
        }
        //public override ToString()
        //{
        //    return "HH:mm:ss y" ;
        //}
        private void buttonNewAlarm_Click(object sender, EventArgs e)
        {
            alarmClock = new AlarmClock();
            alarmClock.ShowDialog();
            if (alarmClock.TurnOf)
            {
                dictAlarms.Add(ID, alarmClock);
                ID++;
                UpdatedListBox();
            }
        }
        private void UpdatedListBox() 
        {
            if(dictAlarms.Count == 0) 
            {
                AlarmLists.Items.Clear();
                AlarmLists.Items.Add("Будильников нет.");
            }
            AlarmLists.Items.Clear();                       //при работе обращаемся к listBox как в Dising
            foreach (AlarmClock alarm in dictAlarms.Values) 
            {
                AlarmLists.Items.Add($"{alarm.Hours}:{alarm.Minutes}:{alarm.Seconds}");
            }
        }
    }
}
