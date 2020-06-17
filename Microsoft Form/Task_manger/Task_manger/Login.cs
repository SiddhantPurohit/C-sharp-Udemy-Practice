using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_manger
{
    public partial class Login : Form
    {
        private string ID;
        private string Password;

        public Login()
        {
            InitializeComponent();
        }

        public void textUserId_TextChanged(object sender, EventArgs e)
        {
            ID = textUserId.Text;
        }

        public void textPassword_TextChanged(object sender, EventArgs e)
        {
            Password = textPassword.Text;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(ID == "S123" && Password == "1234")
            {
                EnterTasks ET = new EnterTasks();
                ET.Show();
            }
            else if(ID == "SSS" && Password == "1234")
            {
                ResultTask R = new ResultTask();
                R.Show();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password");
            }
        }
    }
}
