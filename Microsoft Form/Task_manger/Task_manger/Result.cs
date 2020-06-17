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
    public partial class ResultTask : Form
    {
        public ResultTask()
        {
            InitializeComponent();
        }

        private void labelTask_Click(object sender, EventArgs e)
        {

        }

        private void ResultTask_Load(object sender, EventArgs e)
        {

        }

        private void buttonShowresult_Click(object sender, EventArgs e)
        {
            var ET = new EnterTasks();

            labelResult1.Text = ET.TaskT;
            labelResult2.Text = ET.DurationD;
            labelResult3.Text = ET.DescriptionD;
        }
    }
}
