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

        private void buttonNewAlarm_Click(object sender, EventArgs e)
        {
            alarmClock = new AlarmClock();
            alarmClock.ShowDialog();
            dictAlarms.Add(ID, alarmClock);
        }
    }
}
