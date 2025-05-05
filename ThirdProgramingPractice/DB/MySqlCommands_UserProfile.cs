using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ThirdProgramingPractice.DB
{
    internal class MySqlCommands_UserProfile
    {
        private TextBox NameTextBox;
        private TextBox SurnameTextBox;

        public void Structure(TextBox NameTextBox, TextBox SurnameTextBox)
        {
            this.NameTextBox = NameTextBox;
            this.SurnameTextBox = SurnameTextBox;
        }

        public void InsertUserProfileTable(MySqlConnection connection)
        {
            string QueryInsertUserProfile = "INSERT INTO `user profile` (`Name`,`Surname`) VALUES (@Name, @Surname)";

            try
            {
                MySqlCommand CommandIsertUserProfile = new MySqlCommand(QueryInsertUserProfile, connection);

                CommandIsertUserProfile.Parameters.Add("@Name", MySqlDbType.VarChar).Value = NameTextBox.Text.ToString();
                CommandIsertUserProfile.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = SurnameTextBox.Text.ToString();

                CommandIsertUserProfile.ExecuteNonQuery();

                MessageBox.Show("User profile successfully saved!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public int SelectUserProfileID(MySqlConnection connection)
        {
            string QuerySelectUserInfoID = "SELECT `ID` FROM `user profile` WHERE `Name` = @Name AND `Surname` = @Surname";
            int UserProfile_ID = 0;

            try
            {
                MySqlCommand SelectID = new MySqlCommand(QuerySelectUserInfoID, connection);
                SelectID.Parameters.Add("@Name", MySqlDbType.VarChar).Value = NameTextBox.Text.ToString();
                SelectID.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = SurnameTextBox.Text.ToString();

                using (MySqlDataReader reader = SelectID.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UserProfile_ID = Convert.ToInt16(reader["ID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return UserProfile_ID;
        }
    }
}
