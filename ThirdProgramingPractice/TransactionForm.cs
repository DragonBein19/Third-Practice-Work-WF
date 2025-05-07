using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdProgramingPractice.DB;
using ThirdProgramingPractice.DB.Budget;
using ThirdProgramingPractice.DB.Transaction;

namespace ThirdProgramingPractice
{
    public partial class TransactionForm : Form
    {
        private MySqlCommand_transaction transaction = new MySqlCommand_transaction();
        private MySqlCommands_BudgetTable budget = new MySqlCommands_BudgetTable();
        private MySQLCommand_expensesList expenseseList = new MySQLCommand_expensesList();
        private MySqlCommands_incomeList incomeList = new MySqlCommands_incomeList();

        private DataBase dataBase = new DataBase();

        private int TransactionType;
        private int BudgetID;

        public TransactionForm(int BudgetID)
        {
            this.BudgetID = BudgetID;
            InitializeComponent();
        }

        private void CreateTransactionButton_Click(object sender, EventArgs e)
        {
            if (TransactionNameTextBox.Text.ToString() != "" && AmountTextBox.Text.ToString() != "" && IncomeExpensesCheck() == true)
            {
                try
                {
                    Convert.ToDouble(AmountTextBox.Text);

                    dataBase.OpenConnection();

                    transaction.CreateTransaction(dataBase.GetConnection(), TransactionNameTextBox.Text.ToString(), Convert.ToInt16(AmountTextBox.Text));
                    int TransactionID = transaction.GetTransactionID(dataBase.GetConnection(), TransactionNameTextBox.Text.ToString());

                    if(TransactionType == 0)
                    {
                        expenseseList.InsertNewTransactionInList(dataBase.GetConnection(), budget.GetBudgetExpenses(dataBase.GetConnection(), BudgetID), transaction.GetTransactionID(dataBase.GetConnection(), TransactionNameTextBox.Text.ToString()));
                    }
                    else if (TransactionType == 1)
                    {
                        incomeList.InsertNewTransactionInList(dataBase.GetConnection(), budget.GetBudgetIncome(dataBase.GetConnection(), BudgetID), transaction.GetTransactionID(dataBase.GetConnection(), TransactionNameTextBox.Text.ToString()));
                    }

                    dataBase.CloseConnection();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Amount table must be number");
                }
            }
            else
            {
                MessageBox.Show("Simething box is empty!!!");
            }
        }

        private bool IncomeExpensesCheck()
        {
            if (IncomeRadioButton.Checked == true || ExpensesRadioButton.Checked == true)
            {
                if(IncomeRadioButton.Checked == true)
                {
                    TransactionType = 1;
                }
                else if(ExpensesRadioButton.Checked == true)
                {
                    TransactionType = 0;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
