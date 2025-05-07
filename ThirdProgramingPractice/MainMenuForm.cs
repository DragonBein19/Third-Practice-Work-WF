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

namespace ThirdProgramingPractice
{

    public partial class MainMenuForm : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommands_BudgetTable Budget = new MySqlCommands_BudgetTable();
        private int accountID;
        private string BudgetName;
        private int SelectedBudgetID;

        public MainMenuForm(int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
            FillBudgetListBox();
        }

        /// <summary>
        /// "The method opens a separate window to input the budget name. Once the budget name is provided,
        /// a list is created where the created budget is linked to the account. The list allows linking 
        /// multiple rows from the 'budget' table to a single row in the 'account' table."
        /// </summary>
        private void NewBudgetButton_Click(object sender, EventArgs e)
        {
            NewBudgetForm BudgetForm = new NewBudgetForm();
            MySqlCommands_Budgets BudgetsList = new MySqlCommands_Budgets();
            string BudgetName;

            BudgetForm.ShowDialog();
            BudgetName = BudgetForm.GetBudgetName();
            BudgetForm.Close();

            dataBase.OpenConnection();
            if (BudgetName != null || BudgetName != "")
            {
                Budget.CreateBudget(dataBase.GetConnection(), BudgetName);
                BudgetsList.AddBudgetsList(dataBase.GetConnection(), Budget.GetBudgetID(dataBase.GetConnection(), BudgetName), accountID);
            }
            dataBase.CloseConnection();
            BudgetsListBox.Items.Clear();
            FillBudgetListBox();
        }

        /// <summary>
        /// "The method displays the budget amount, expenses amount, and income amount."
        /// </summary>
        private void BudgetsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            MySQLCommands_IncomesAmount incomeaTable = new MySQLCommands_IncomesAmount();
            MySqlCommands_ExpensesAmount expensesaTable = new MySqlCommands_ExpensesAmount();

            string SelectedItem = BudgetsListBox.SelectedItem.ToString();
            BudgetName = SelectedItem;

            SelectedBudgetID = Budget.GetBudgetID(dataBase.GetConnection(), SelectedItem);

            AmountTextBox.Text = "Amount: " + Budget.GetBudgetAmount(dataBase.GetConnection(), SelectedItem).ToString();
            ExpensesTextBox.Text = "Expenses: " + expensesaTable.GetExpensesAmount(dataBase.GetConnection(), Budget.GetBudgetExpenses(dataBase.GetConnection(), SelectedBudgetID)).ToString();
            IncomeTextBox.Text = "Incomes: " + incomeaTable.GetIncomeAmount(dataBase.GetConnection(), Budget.GetBudgetIncome(dataBase.GetConnection(), SelectedBudgetID)).ToString();


            ExpensesListBox.Items.Clear();
            IncomeListBox.Items.Clear();
            FillExpensesIndcomeListBox(dataBase.GetConnection());

            dataBase.CloseConnection();
        }

        /// <summary>
        /// A method to populate the list with budget names linked to the account.
        /// </summary>
        private void FillBudgetListBox()
        {
            MySqlCommands_Budgets budgetsList = new MySqlCommands_Budgets();

            dataBase.OpenConnection();
            List<string> BudgetsListArray = budgetsList.GetBudgetsList(dataBase.GetConnection(), accountID);

            BudgetsListBox.Items.AddRange(BudgetsListArray.ToArray());

            dataBase.CloseConnection();
        }

        private void FillExpensesIndcomeListBox(MySqlConnection connection)
        {
            MySQLCommand_expensesList expensesList = new MySQLCommand_expensesList();
            MySqlCommands_incomeList incomeList = new MySqlCommands_incomeList();

            dataBase.OpenConnection();

            List<string> ExpensesListArray = expensesList.GetTansactionList(connection, SelectedBudgetID);
            List<string> IncomeListArray = incomeList.GetTransactionList(connection, SelectedBudgetID);
            ExpensesListBox.Items.AddRange(ExpensesListArray.ToArray());
            IncomeListBox.Items.AddRange(IncomeListArray.ToArray());

            dataBase.CloseConnection();
        }

        /// <summary>
        /// Provides access to the transaction creation window.
        /// </summary>
        private void CreateTransactionButton_Click(object sender, EventArgs e)
        {
            TransactionForm transaction = new TransactionForm(SelectedBudgetID);
            transaction.ShowDialog();
            transaction.Close();

            ExpensesListBox.Items.Clear();
            IncomeListBox.Items.Clear();
            FillExpensesIndcomeListBox(dataBase.GetConnection());
        }

        private void NewGoalButton_Click(object sender, EventArgs e)
        {
            NewGoalForm GoalForm = new NewGoalForm();
            GoalForm.ShowDialog();
            dataBase.OpenConnection();

            MySQLCommands_Goal goal = new MySQLCommands_Goal();
            goal.CreateGoal(dataBase.GetConnection(), GoalForm.ReturnName(), GoalForm.ReturnValue());

            dataBase.CloseConnection();
            GoalForm.Close();
        }
    }
}
