using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB
{
    /// <summary>
    /// This class is intended for working with the "account" table.
    /// </summary>
    internal class MySqlCommands_accountTable
    {

        /// <summary>
        /// This method is responsible for creating a new row in the "account" table, saving the login and password.
        /// </summary>
        /// <param name="connection">Current database connection.</param>
        public void CreateAccount(MySqlConnection connection, string Login, string Password)
        {
            string QueryIserntAccount = "INSERT INTO `account` (`Login`,`Password`) VALUES (@Login, @Password)";

            try
            {
                MySqlCommand InsertAccount = new MySqlCommand(QueryIserntAccount, connection);

                InsertAccount.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login;
                InsertAccount.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password;

                InsertAccount.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Method that adds foreign keys to the "user info" and "user profile" tables.
        /// </summary>
        /// <param name="connection">Current database connection.</param>
        /// <param name="UserProfileID">The variable "UserProfileID" is used to store the "ID" from the "user profile" table.</param>
        /// <param name="UserInfoID">The variable "UserInfoID" is used to store the "ID" from the "user info" table.</param>
        public void UpdateAccoutFK(MySqlConnection connection, int UserProfileID, int UserInfoID, string Login, string Password)
        {
            try
            {
                string QueryUpdateAccount = "UPDATE `account` SET `Profile_ID` = @Profile_ID, `UserInfo_ID` = @UserInfo_ID WHERE `ID` = @ID";

                MySqlCommand UpdateFK = new MySqlCommand(QueryUpdateAccount, connection);
            
                UpdateFK.Parameters.Add("@ID", MySqlDbType.Int16).Value = SelectAccountID(connection, Login, Password);
                UpdateFK.Parameters.Add("@Profile_ID", MySqlDbType.Int16).Value = UserProfileID;
                UpdateFK.Parameters.Add("@UserInfo_ID", MySqlDbType.Int16).Value = UserInfoID;           

                UpdateFK.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }                       
        }

        /// <summary>
        /// Method intended to retrieve the user's ID from the "account" table using the entered login and password.
        /// </summary>
        /// <param name="connection">Current database connection.</param>
        /// <param name="Login">Variable for storing the entered login.</param>
        /// <param name="Password">Variable for storing the entered password.</param>
        /// <returns>Returned account "ID".</returns>
        public int SelectAccountID(MySqlConnection connection, string Login, string Password)
        {
            string QuerySelectAccountID = "SELECT `ID` FROM `account` WHERE `Login` = @Login AND `Password` = @Password";
            int AccountID = 0;

            try
            {
                MySqlCommand SelectID = new MySqlCommand(QuerySelectAccountID, connection);
                SelectID.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login;
                SelectID.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password;

                using (MySqlDataReader reader = SelectID.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        AccountID = Convert.ToInt16(reader["ID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }

            return AccountID;
        }
    }
}
