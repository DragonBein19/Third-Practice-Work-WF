using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdProgramingPractice
{
    public partial class NewGoalForm : Form
    {
        public NewGoalForm()
        {
            InitializeComponent();
        }

        private void GoalTaskLabel_Click(object sender, EventArgs e)
        {

        }

        public string ReturnName()
        {
            return NameTextBox.Text.ToString();
        }

        public float ReturnValue()
        {
            return Convert.ToInt16(GoalTextBox.Text);
        }
    }
}
