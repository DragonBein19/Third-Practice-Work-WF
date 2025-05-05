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
        private string BudgetName;
        
        public NewBudgetForm()
        {
            InitializeComponent();
        }

        private void NewBudgetBotton_Click(object sender, EventArgs e)
        {
            BudgetName = NewBudgetTextBox.Text.ToString();
            this.Hide();
        }

        public string GetBudgetName()
        {
            return BudgetName;
        } 
    }
}
