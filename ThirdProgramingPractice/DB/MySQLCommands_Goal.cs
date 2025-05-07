using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB
{
    internal class MySQLCommands_Goal
    {
        
        /// <summary>
        /// Method witch created new row in table "goal" with variables "Name" and "Amount".
        /// </summary>
        /// <param name="connection">Currently data base connection.</param>
        /// <param name="Name">Variable "Name".</param>
        /// <param name="Amount">Variable "Amount".</param>
        public void CreateGoal(MySqlConnection connection, string Name, float Amount)
        {
            string Query = "INSERT iNTO `goal` (`Name`, `Amount`) VALUES (@Name, @Amount)";

            try
            {
                MySqlCommand CreateNewGoal = new MySqlCommand(Query, connection);

                CreateNewGoal.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                CreateNewGoal.Parameters.Add("@Amount", MySqlDbType.Float).Value = Amount;

                CreateNewGoal.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySQLCommands_Goal class.\nMethod CreateGoal.\nError message: " + ex.Message);
            }
        }
    }
}
