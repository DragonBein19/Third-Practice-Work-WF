using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ThirdProgramingPractice.DB
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;uid=root;password=root;database=fri_db");

        public MySqlConnection GetConnection() { return connection; }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
         
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
