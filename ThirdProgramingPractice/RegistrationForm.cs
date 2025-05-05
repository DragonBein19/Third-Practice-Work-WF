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
    public partial class RegistrationForm : Form
    {
        private DataBase dataBase = new DataBase();
        private MySqlCommands_account mySqlCommands_Account = new MySqlCommands_account();
        private MySqlCommands_UserInfo mySqlCommands_UserInfo = new MySqlCommands_UserInfo();
        private MySqlCommands_UserProfile mySqlCommands_UserProfile = new MySqlCommands_UserProfile();
        private int AccountID;
        
        public RegistrationForm()
        {
            InitializeComponent();
            ErrorMassageLabel.Text = " ";
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.ToString() != "" &&
                SurnameTextBox.Text.ToString() != "" &&
                EmailTextBox.Text.ToString() != "" &&
                PhoneNumberTextBox.Text.ToString() != "" &&
                HomeAdressTextBox.Text.ToString() != "" &&
                LoginTextBox.Text.ToString() != "" &&
                PasswordTextBox.Text.ToString() != "" &&
                RepeadPaswordTextBox.Text.ToString() != "")
            {
                if (RepeadPaswordTextBox.Text.ToString() == PasswordTextBox.Text.ToString() &&
                    RepeadPaswordTextBox.Text.ToString() != "" &&
                    PasswordTextBox.Text.ToString() != "")
                {
                    ErrorMassageLabel.Text = " ";
                    DataDispatch();

                    dataBase.OpenConnection();

                    mySqlCommands_Account.InsertAccount(dataBase.GetConnection());
                    mySqlCommands_UserInfo.InsertUserInfoTable(dataBase.GetConnection());
                    mySqlCommands_UserProfile.InsertUserProfileTable(dataBase.GetConnection());
                    mySqlCommands_Account.UpdateAccoutFK(
                        dataBase.GetConnection(),
                        mySqlCommands_UserProfile.SelectUserProfileID(dataBase.GetConnection()),
                        mySqlCommands_UserInfo.SelectUserInfoID(dataBase.GetConnection()));

                    MessageBox.Show("Congratulatio!!! All good!!!");
                }
                else
                {
                    ErrorMassageLabel.Text = "Passwords must be same";
                }
            }
            else
            {
                ErrorMassageLabel.Text = "All labels must be fill";
            }
            dataBase.CloseConnection();
        }

        private void DataDispatch()
        {
            mySqlCommands_Account.Structure(LoginTextBox, PasswordTextBox);
            mySqlCommands_UserInfo.Structure(EmailTextBox, PhoneNumberTextBox, HomeAdressTextBox);
            mySqlCommands_UserProfile.Structure(NameTextBox, SurnameTextBox);
        }
    }
}
