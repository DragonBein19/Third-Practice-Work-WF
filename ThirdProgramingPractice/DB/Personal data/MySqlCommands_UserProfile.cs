using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ThirdProgramingPractice.DB
{
    /// <summary>
    /// Class for interacting with the "user profile" table.
    /// </summary>    
    internal class MySqlCommands_UserProfileTable
    {
        /// <summary>
        /// A new row is created in the "user profile" table using the entered first name and last name.
        /// </summary>
        /// <param name="connection">Current database connection.</param>
        public void CreateUserProfile(MySqlConnection connection, string Name, string Surname)
        {
            string Query = "INSERT INTO `user profile` (`Name`,`Surname`) VALUES (@Name, @Surname)";

            try
            {
                MySqlCommand InsertUserProfile = new MySqlCommand(Query, connection);

                InsertUserProfile.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                InsertUserProfile.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = Surname;

                InsertUserProfile.ExecuteNonQuery();

                MessageBox.Show("User profile successfully saved!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommands_UserProfileTable class.\nMethod CreateUserProfile()\nError message: " + ex.Message);
            }
        }

        /// <summary>
        /// Returns the "ID" from the "user profile" table based on specific parameters.
        /// </summary>
        /// <param name="connection">Current database connection.</param>
        /// <returns>Returned "ID" from table "user profile"</returns>
        public int SelectUserProfileID(MySqlConnection connection, string Name, string Surname)
        {
            string QuerySelectUserInfoID = "SELECT `ID` FROM `user profile` WHERE `Name` = @Name AND `Surname` = @Surname";
            int UserProfile_ID = 0;

            try
            {
                MySqlCommand SelectID = new MySqlCommand(QuerySelectUserInfoID, connection);
                SelectID.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                SelectID.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = Surname;

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
                MessageBox.Show("Error in MySqlCommands_UserProfileTable class.\nMethod SelectUserProfileID()\nError message: " + ex.Message);
            }
            return UserProfile_ID;
        }
    }
}
