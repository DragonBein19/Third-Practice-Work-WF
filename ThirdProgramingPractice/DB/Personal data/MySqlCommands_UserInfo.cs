using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB
{
    /// <summary>
    /// This class is responsible for interacting with the "user info" table.
    /// </summary>
    internal class MySqlCommands_UserInfoTable
    {
        /// <summary>
        /// The method creates a new row in the "user info" table and contains all the user's personal information.
        /// </summary>
        /// <param name="connection">Current database connection.</param>
        public void CreateUserInfo(MySqlConnection connection, string Email, string PhoneNumber, string HomeAdress)
        {
            string Query = "INSERT INTO `user info` (`Email`,`PhoneNumber`,`HomeAdress`,`RegData`) VALUES (@Email, @PhoneNumber, @HomeAdress, @RegData)";

            try
            {
                MySqlCommand InsertUserInfo = new MySqlCommand(Query, connection);

                InsertUserInfo.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
                InsertUserInfo.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = PhoneNumber;
                InsertUserInfo.Parameters.Add("@HomeAdress", MySqlDbType.VarChar).Value = HomeAdress;
                InsertUserInfo.Parameters.Add("@RegData", MySqlDbType.Date).Value = DateTime.Now.ToString("dd.MM.yy");

                InsertUserInfo.ExecuteNonQuery();

                MessageBox.Show("Information about user successfully saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommands_UserInfoTable class. \nMethod CreateUserInfo().\n Error message: " + ex.Message);
            }
        }

        /// <summary>
        /// Method that returns the "ID" from the "user info" table.
        /// </summary>
        /// <param name="connection">Current database connection.</param>
        /// <returns>returned "ID" from table "user info".</returns>
        public int SelectUserInfoID(MySqlConnection connection, string Email, string PhoneNumber, string HomeAdress)
        {
            string QuerySelectUserInfoID = "SELECT `ID` FROM `user info` WHERE `Email` = @Email AND `PhoneNumber` = @PhoneNumber AND `HomeAdress` = @HomeAdress";
            int UserInfo_ID = 0;

            try
            {
                MySqlCommand SelectID = new MySqlCommand(QuerySelectUserInfoID, connection);
                SelectID.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
                SelectID.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = PhoneNumber;
                SelectID.Parameters.Add("@HomeAdress", MySqlDbType.VarChar).Value = HomeAdress;

                using (MySqlDataReader reader = SelectID.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UserInfo_ID = Convert.ToInt16(reader["ID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return UserInfo_ID;
        }
    }
}
