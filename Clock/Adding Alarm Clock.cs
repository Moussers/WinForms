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
            ID = 0;
        }
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
                AlarmList.Items.Clear();
                AlarmList.Items.Add("Будильников нет.");
            }
            AlarmList.Items.Clear();                       //при работе обращаемся к listBox как в Dising
            foreach (AlarmClock alarm in dictAlarms.Values) 
            {
                AlarmList.Items.Add($"{alarm.Hours}:{alarm.Minutes}:{alarm.Seconds}");
            }
        }

        private void buttonChangeAlarm_Click(object sender, EventArgs e)
        {
            int index = AlarmList.SelectedIndex;
            if (CheckErrors(dictAlarms, index)) 
            {
                dictAlarms[index].ShowDialog();
                UpdatedListBox();
            }
            return;
        }
        private void buttonDeleteAlarm_Click(object sender, EventArgs e)
        {
            int index = AlarmList.SelectedIndex;
            if (CheckErrors(dictAlarms, index))
            {
                
            }
            return;
        }
        private bool CheckErrors(Dictionary<int, AlarmClock> dict, int index)
        {
            if (dictAlarms.Count == 0)
            {
                MessageBox.Show("В списке нету будильников!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (index == -1)
            {
                MessageBox.Show("Выбирите будильник", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
