using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB
{
    internal class MySqlCommands_UserInfo
    {
        private TextBox EmailTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox HomeAdressTextBox;

        public void Structure(TextBox EmailTextBox, TextBox PhoneNumberTextBox, TextBox HomeAdressTextBox)
        {
            this.EmailTextBox = EmailTextBox;
            this.PhoneNumberTextBox = PhoneNumberTextBox;
            this.HomeAdressTextBox = HomeAdressTextBox;
        }

        public void InsertUserInfoTable(MySqlConnection connection)
        {
            string QueryInsertUserInfo =
                    "INSERT INTO `user info` (`Email`,`PhoneNumber`,`HomeAdress`,`RegData`) " +
                    "VALUES (@Email, @PhoneNumber, @HomeAdress, @RegData)";
            try
            {
                MySqlCommand InsertUserInfo = new MySqlCommand(QueryInsertUserInfo, connection);

                InsertUserInfo.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailTextBox.Text.ToString();
                InsertUserInfo.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = PhoneNumberTextBox.Text.ToString();
                InsertUserInfo.Parameters.Add("@HomeAdress", MySqlDbType.VarChar).Value = HomeAdressTextBox.Text.ToString();
                InsertUserInfo.Parameters.Add("@RegData", MySqlDbType.Date).Value = DateTime.Now.ToString("dd.MM.yy");

                InsertUserInfo.ExecuteNonQuery();

                MessageBox.Show("Information about user successfully saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public int SelectUserInfoID(MySqlConnection connection)
        {
            string QuerySelectUserInfoID = "SELECT `ID` FROM `user info` WHERE `Email` = @Email AND `PhoneNumber` = @PhoneNumber AND `HomeAdress` = @HomeAdress";
            int UserInfo_ID = 0;

            try
            {
                MySqlCommand SelectID = new MySqlCommand(QuerySelectUserInfoID, connection);
                SelectID.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailTextBox.Text.ToString();
                SelectID.Parameters.Add("@PhoneNumber", MySqlDbType.VarChar).Value = PhoneNumberTextBox.Text.ToString();
                SelectID.Parameters.Add("@HomeAdress", MySqlDbType.VarChar).Value = HomeAdressTextBox.Text.ToString();

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
