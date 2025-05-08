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

    public partial class MainMenuForm : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommands_BudgetTable Budget = new MySqlCommands_BudgetTable();
        private int accountID, SelectedTransactionID, SelectedGoalID;
        private int SelectedBudgetID;

        public MainMenuForm(int accountID)
        {
            InitializeComponent();

            this.accountID = accountID;
            FillBudgetListBox();
            dataBase.OpenConnection();
            FillGoalsListBox(dataBase.GetConnection());
            dataBase.CloseConnection();
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
            BudgetsListBox.Items.Clear();
            FillBudgetListBox();
            dataBase.CloseConnection();
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
            BudgetNameLabel.Text = SelectedItem;

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

        /// <summary>
        /// The method responsible for displaying income and expenses.
        /// </summary>
        /// <param name="connection">Currently data base connection</param>
        private void FillExpensesIndcomeListBox(MySqlConnection connection)
        {
            MySQLCommand_expensesList expensesList = new MySQLCommand_expensesList();
            MySqlCommands_incomeList incomeList = new MySqlCommands_incomeList();

            dataBase.OpenConnection();
            List<string> ExpensesListArray = expensesList.GetTansactionList(connection, SelectedBudgetID);
            List<string> IncomeListArray = incomeList.GetTransactionList(connection, SelectedBudgetID);
            dataBase.CloseConnection();

            ExpensesListBox.Items.AddRange(ExpensesListArray.ToArray());
            IncomeListBox.Items.AddRange(IncomeListArray.ToArray());
        }

        private void FillGoalsListBox(MySqlConnection connection)
        {
            MySQLCommands_GoalsList goallist = new MySQLCommands_GoalsList();
            List<string> GoalsList = goallist.GetGoalsList(connection, accountID);

            GoalsListBox.Items.AddRange(GoalsList.ToArray());
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

            dataBase.OpenConnection();
            FillExpensesIndcomeListBox(dataBase.GetConnection());
            dataBase.CloseConnection();
        }

        /// <summary>
        /// The method is responsible for creating a new row in the "goals_list" table and linking 
        /// the newly created goal to the account.
        /// </summary>
        private void NewGoalButton_Click(object sender, EventArgs e)
        {
            NewGoalForm GoalForm = new NewGoalForm();
            GoalForm.ShowDialog();
            dataBase.OpenConnection();

            MySQLCommands_Goal goal = new MySQLCommands_Goal();
            goal.CreateGoal(dataBase.GetConnection(), GoalForm.ReturnName(), GoalForm.ReturnValue());
            goal.SetInGoalList(dataBase.GetConnection(), accountID, goal.GetCreatedID(dataBase.GetConnection()));

            GoalsListBox.Items.Clear();
            FillGoalsListBox(dataBase.GetConnection());

            dataBase.CloseConnection();
            GoalForm.Close();
        }

        private void IncomeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommands_incomeList incomeIDList = new MySqlCommands_incomeList();
            MySqlCommand_transaction transaction = new MySqlCommand_transaction();
            List<int> IncomeIDList = new List<int>();

            dataBase.OpenConnection();

            IncomeIDList = incomeIDList.GetTransctionIDList(dataBase.GetConnection(), SelectedBudgetID);

            for (int i = 0; i < IncomeIDList.Count; i++)
            {
                if (IncomeListBox.Text.ToString() == transaction.GetTransactionName(dataBase.GetConnection(), Convert.ToInt16(IncomeIDList[i])))
                {
                    TransactionNameTextBox.Text = transaction.GetTransactionName(dataBase.GetConnection(), Convert.ToInt16(IncomeIDList[i]));
                    TransactionAmountTextBox.Text = transaction.GetTransactionAmount(dataBase.GetConnection(), Convert.ToInt16(IncomeIDList[i])).ToString();
                    DescriptionTextBox.Text = transaction.GetTransactionDescription(dataBase.GetConnection(), Convert.ToInt16(IncomeIDList[i]));
                    TransactionDateLabel.Text = "Transaction Date: " + transaction.GetTransactionDate(dataBase.GetConnection(), Convert.ToInt16(IncomeIDList[i])).ToString();

                    SelectedTransactionID = Convert.ToInt16(IncomeIDList[i]);
                }
            }

            dataBase.CloseConnection();
        }

        private void ExpensesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySQLCommand_expensesList expensesIDList = new MySQLCommand_expensesList();
            MySqlCommand_transaction transaction = new MySqlCommand_transaction();
            List<int> ExpensesIDList = new List<int>();
            List<string> ExpensesIDListS = new List<string>();

            dataBase.OpenConnection();

            ExpensesIDList = expensesIDList.GetTransctionIDList(dataBase.GetConnection(), SelectedBudgetID);

            for (int i = 0; i < ExpensesIDList.Count; i++)
            {
                if (ExpensesListBox.Text.ToString() == transaction.GetTransactionName(dataBase.GetConnection(), Convert.ToInt16(ExpensesIDList[i])))
                {
                    TransactionNameTextBox.Text = transaction.GetTransactionName(dataBase.GetConnection(), Convert.ToInt16(ExpensesIDList[i]));
                    TransactionAmountTextBox.Text = transaction.GetTransactionAmount(dataBase.GetConnection(), Convert.ToInt16(ExpensesIDList[i])).ToString();
                    DescriptionTextBox.Text = transaction.GetTransactionDescription(dataBase.GetConnection(), Convert.ToInt16(ExpensesIDList[i]));
                    TransactionDateLabel.Text = "Transaction Date: " + transaction.GetTransactionDate(dataBase.GetConnection(), Convert.ToInt16(ExpensesIDList[i])).ToString();

                    SelectedTransactionID = Convert.ToInt16(ExpensesIDList[i]);
                }
            }

            dataBase.CloseConnection();
        }

        private void GoalsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySQLCommands_GoalsList goalsList = new MySQLCommands_GoalsList();
            MySQLCommands_Goal goal = new MySQLCommands_Goal();

            dataBase.OpenConnection();
            List<int> GoalID = goalsList.GiveGoalsIdList(dataBase.GetConnection(), accountID);

            for (int i = 0; i < GoalID.Count; i++)
            {
                if (GoalsListBox.Text.ToString() == goal.GetGoalName(dataBase.GetConnection(), GoalID[i]).ToString())
                {
                    GoalNameTextBox.Text = goal.GetGoalName(dataBase.GetConnection(), GoalID[i]).ToString();
                    GoalTaskTextBox.Text = goal.GetGoalTask(dataBase.GetConnection(), GoalID[i]).ToString();
                    ProgressTextBox.Text = goal.GetGoalCurrency(dataBase.GetConnection(), GoalID[i]).ToString();

                    SelectedGoalID = Convert.ToInt16(GoalID[i]);
                }
            }

            dataBase.CloseConnection();
        }

        private void TransactionUpadateButton_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            MySqlCommand_transaction transaction = new MySqlCommand_transaction();
            transaction.UpdateTransaction(dataBase.GetConnection(), TransactionNameTextBox.Text.ToString(), Convert.ToInt16(TransactionAmountTextBox.Text), DescriptionTextBox.Text.ToString(), SelectedTransactionID);

            IncomeListBox.Items.Clear();
            ExpensesListBox.Items.Clear();
            FillExpensesIndcomeListBox(dataBase.GetConnection());
            dataBase.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            MySQLCommands_Goal Goal = new MySQLCommands_Goal();
            Goal.UpdateGoal(dataBase.GetConnection(), GoalNameTextBox.Text.ToString(), Convert.ToDouble(GoalTaskTextBox.Text), Convert.ToDouble(ProgressTextBox.Text), SelectedGoalID);

            GoalsListBox.Items.Clear();
            FillGoalsListBox(dataBase.GetConnection());
            dataBase.CloseConnection();
        }
    }
}
