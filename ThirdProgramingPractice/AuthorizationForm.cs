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
    /// <summary>
    ///  Class responsible for the functionality of the form. It handles user authentication using login 
    ///  and password to interact with the "account" table and allows navigation to the user registration 
    ///  window.
    /// </summary>
    public partial class AuthorizationForm : Form
    {      
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Method responsible for user authentication. Using the entered "login" and "password", the method
        /// retrieves the "ID" from the "account" table and checks: if the "ID" is 0, it means there is 
        /// no user with such login or password. If the "ID" is not 0, it means a user with that "ID" 
        /// exists. The user's "ID" is then saved and passed to the "MainMenuForm" class.
        /// </summary>
        private void SignInButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlCommands_accountTable account = new MySqlCommands_accountTable();

            dataBase.OpenConnection();

            int accountID = account.SelectAccountID(dataBase.GetConnection(), LoginTextBox.Text.ToString(), PasswordTextBox.Text.ToString());

            try
            {
                if (accountID != 0)
                {
                    this.Hide();
                    MainMenuForm mainMenuForm = new MainMenuForm(accountID);
                    dataBase.CloseConnection();
                    mainMenuForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Inccorect login or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            dataBase.CloseConnection();
        }

        /// <summary>
        /// Method that opens the registration window while hiding the login window. When the registration 
        /// window is closed, the login window will be shown again.
        /// </summary>
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            this.Show();
        }
    }
}
