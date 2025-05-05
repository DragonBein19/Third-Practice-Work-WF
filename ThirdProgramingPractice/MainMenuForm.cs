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
        NewBudgetForm newBudgetForm = new NewBudgetForm();
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
        }

        private void BudgetsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillListBox()
        {
            dataBase.OpenConnection();
            string[] BudgetsListArray = Budget.GetBudgetsList(dataBase.GetConnection(), accountID);

            BudgetsListBox.Items.AddRange(BudgetsListArray);

            dataBase.CloseConnection();
        }
    }
}
