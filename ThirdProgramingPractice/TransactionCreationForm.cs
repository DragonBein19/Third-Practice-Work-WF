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
    public partial class TransactionCreationForm : Form
    {
        public TransactionCreationForm()
        {
            InitializeComponent();
        }

        private void CreateTransactionButton_Click(object sender, EventArgs e)
        {
            if(TransactionNameTextBox.Text.ToString() == "" && AmountTextBox.Text.ToString() == "")
            {

            }
        }
    }
}
