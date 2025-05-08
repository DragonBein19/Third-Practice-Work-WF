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
    public partial class NewBudgetForm : Form
    {       
        public NewBudgetForm()
        {
            InitializeComponent();
        }

        private void NewBudgetBotton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string GetBudgetName()
        {
            return NewBudgetTextBox.Text.ToString(); ;
        }
    }
}
