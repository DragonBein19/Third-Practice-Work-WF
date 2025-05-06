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

namespace ThirdProgramingPractice
{
    public partial class MainMenuForm : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommands_Budget Budget = new MySqlCommands_Budget();
        private int accountID;

        public MainMenuForm(int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
            FillListBox();
        }

        private void NewBudgetButton_Click(object sender, EventArgs e)
        {
            NewBudgetForm newBudgetForm = new NewBudgetForm();
            string BudgetName = null;

            newBudgetForm.ShowDialog();
            BudgetName = newBudgetForm.GetBudgetName();

            dataBase.OpenConnection();
            if (BudgetName != null || BudgetName != "")
            {
                newBudgetForm.Close();
                Budget.CreateBudget(dataBase.GetConnection(), BudgetName);
                Budget.AddBudgetsList(dataBase.GetConnection(), BudgetName, accountID);
                MessageBox.Show(BudgetName);
            }
            dataBase.CloseConnection();
            BudgetsListBox.Items.Clear();
            FillListBox();
        }

        private void BudgetsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            string SelectedItem = BudgetsListBox.SelectedItem.ToString();
            AmountTextBox.Text = "Amount: " + Budget.GetBudgetAmount(dataBase.GetConnection(), SelectedItem).ToString();

            ExpensesTextBox.Text = "Expenses: " + Budget.GetExpensesAmount(dataBase.GetConnection(), Budget.GetBudgetExpenses(dataBase.GetConnection(), SelectedItem)).ToString();

            IncomeTextBox.Text = "Incomes: " + Budget.GetIncomeAmount(dataBase.GetConnection(), Budget.GetBudgetIncome(dataBase.GetConnection(), SelectedItem)).ToString();

            dataBase.CloseConnection();
        }

        private void FillListBox()
        {
            dataBase.OpenConnection();
            List<string> BudgetsListArray = Budget.GetBudgetsList(dataBase.GetConnection(), accountID);

            BudgetsListBox.Items.AddRange(BudgetsListArray.ToArray());

            dataBase.CloseConnection();
        }

        private void BudgetNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpensesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
