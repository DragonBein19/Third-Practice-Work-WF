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
    internal class MySqlCommands_account
    {
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;

        public void Structure(TextBox LoginTextBox, TextBox PasswordTextBox)
        {
            this.LoginTextBox = LoginTextBox;
            this.PasswordTextBox = PasswordTextBox;
        }

        public void InsertAccount(MySqlConnection connection)
        {
            string QueryIserntAccount = "INSERT INTO `account` (`Login`,`Password`) VALUES (@Login, @Password)";

            try
            {
                MySqlCommand InsertAccount = new MySqlCommand(QueryIserntAccount, connection);

                InsertAccount.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginTextBox.Text.ToString();
                InsertAccount.Parameters.Add("@Password", MySqlDbType.VarChar).Value = PasswordTextBox.Text.ToString();

                InsertAccount.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void UpdateAccoutFK(MySqlConnection connection, int UserProfileID, int UserInfoID)
        {
            try
            {
                string QueryUpdateAccount = "UPDATE `account` SET `Profile_ID` = @Profile_ID, `UserInfo_ID` = @UserInfo_ID WHERE `ID` = @ID";

                MySqlCommand UpdateFK = new MySqlCommand(QueryUpdateAccount, connection);
            
                UpdateFK.Parameters.Add("@ID", MySqlDbType.Int16).Value = SelectIDFromAccount(connection);
                UpdateFK.Parameters.Add("@Profile_ID", MySqlDbType.Int16).Value = UserProfileID;
                UpdateFK.Parameters.Add("@UserInfo_ID", MySqlDbType.Int16).Value = UserInfoID;           

                UpdateFK.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }                       
        }

        public int SelectIDFromAccount(MySqlConnection connection)
        {
            string QuerySelectAccountID = "SELECT `ID` FROM `account` WHERE `Login` = @Login";
            int AccountID = 0;

            try
            {
                MySqlCommand SelectID = new MySqlCommand(QuerySelectAccountID, connection);
                SelectID.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginTextBox.Text.ToString();

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
