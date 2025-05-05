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
    public partial class AuthorizationForm : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommands_account account = new MySqlCommands_account();       

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string QueryFindAccount = "SELECT * FROM `account` WHERE `Login` = @Login AND `Password` = @Password";

            dataBase.OpenConnection();
            try
            {
                MySqlCommand CheckAccountInDataBase = new MySqlCommand(QueryFindAccount, dataBase.GetConnection());

                CheckAccountInDataBase.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginTextBox.Text.ToString();
                CheckAccountInDataBase.Parameters.Add("@Password", MySqlDbType.VarChar).Value = PasswordTextBox.Text.ToString();

                using(MySqlDataReader reader = CheckAccountInDataBase.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        reader.Close();
                        this.Hide();
                        dataBase.OpenConnection();
                        account.Structure(LoginTextBox, PasswordTextBox);
                        MainMenuForm mainMenuForm = new MainMenuForm(account.SelectIDFromAccount(dataBase.GetConnection()));
                        dataBase.CloseConnection();
                        mainMenuForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Inccorect login or password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            dataBase.CloseConnection();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
