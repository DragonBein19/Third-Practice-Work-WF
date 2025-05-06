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
        public RegistrationForm()
        {
            InitializeComponent();
            ErrorMassageLabel.Text = " ";
        }

        /// <summary>
        /// Method triggered after clicking the registration button. It performs validation to ensure 
        /// there are no empty fields and that the entered passwords match. Then, new data is created 
        /// in the "account", "user info", and "user profile" tables. After that, the foreign keys in 
        /// the "account" table are filled in.
        /// </summary>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
        MySqlCommands_accountTable accountTable = new MySqlCommands_accountTable();
        MySqlCommands_UserInfoTable userInfoTable = new MySqlCommands_UserInfoTable();
        MySqlCommands_UserProfileTable userProfileTable = new MySqlCommands_UserProfileTable();

        DataBase dataBase = new DataBase();

            if (NameTextBox.Text.ToString() != "" &&
                SurnameTextBox.Text.ToString() != "" &&
                EmailTextBox.Text.ToString() != "" &&
                PhoneNumberTextBox.Text.ToString() != "" &&
                HomeAdressTextBox.Text.ToString() != "" &&
                LoginTextBox.Text.ToString() != "" &&
                PasswordTextBox.Text.ToString() != "" &&
                RepeadPaswordTextBox.Text.ToString() != "")
            {
                if (RepeadPaswordTextBox.Text.ToString() == PasswordTextBox.Text.ToString())
                {
                    ErrorMassageLabel.Text = " ";

                    dataBase.OpenConnection();

                    accountTable.CreateAccount(dataBase.GetConnection(), LoginTextBox.Text.ToString(), PasswordTextBox.Text.ToString());
                    userInfoTable.CreateUserInfo(dataBase.GetConnection(), EmailTextBox.Text.ToString(), PhoneNumberTextBox.Text.ToString(), HomeAdressTextBox.Text.ToString());
                    userProfileTable.CreateUserProfile(dataBase.GetConnection(), NameTextBox.Text.ToString(), SurnameTextBox.Text.ToString());
                    accountTable.UpdateAccoutFK(
                                                    dataBase.GetConnection(),
                                                    userProfileTable.SelectUserProfileID(dataBase.GetConnection(), NameTextBox.Text.ToString(), SurnameTextBox.Text.ToString()),
                                                    userInfoTable.SelectUserInfoID(dataBase.GetConnection(), EmailTextBox.Text.ToString(), PhoneNumberTextBox.Text.ToString(), HomeAdressTextBox.Text.ToString()),
                                                    LoginTextBox.Text.ToString(),
                                                    PasswordTextBox.Text.ToString()
                                                );

                    MessageBox.Show("Account sucssesful create");
                }
                else
                {
                    ErrorMassageLabel.Text = "Passwords must be same";
                    ErrorMassageLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                ErrorMassageLabel.Text = "All labels must be fill";
                ErrorMassageLabel.ForeColor = Color.Red;
            }
            dataBase.CloseConnection();
        }
    }
}
