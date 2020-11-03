using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    
    public partial class EnterNewUserWindow : Form
    {
        public event EventHandler<string> NewUserAddedEvent;

        public EnterNewUserWindow()
        {
            InitializeComponent();
        }

        private void NewUserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AcceptNewData_Click(object sender, EventArgs e)
        {
            NewUserAddedEvent?.Invoke(this, NewUserTextBox.Text);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
