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
    public partial class StrErrorForm : Form
    {
        private string infoMessage;

        public StrErrorForm(string strError)
        {
            InitializeComponent();
            Message = strError;
        }
        public string Message 
        {
            get { return infoMessage; } 
            private set { infoMessage = value; }
        }
        private void okey_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StrErrorForm_Load(object sender, EventArgs e)
        {
            strMessError.Text = Message;
        }
    }
}
