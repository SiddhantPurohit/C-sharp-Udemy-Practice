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
    public partial class EnterTasks : Form
    {
        public string TaskT;
        public string DurationD;
        public string DescriptionD;
        public EnterTasks()
        {
            InitializeComponent();
        }

        private void textTask_TextChanged(object sender, EventArgs e)
        {
            TaskT = textTask.Text;
        }

        private void textDuration_TextChanged(object sender, EventArgs e)
        {
            DurationD = textDuration.Text;
        }

        private void textDescription_TextChanged(object sender, EventArgs e)
        {
            DescriptionD = textDescription.Text;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entered Sucessfully");
            var L = new Login();
            L.Show();
        }
    }
}
