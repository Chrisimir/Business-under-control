using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Business_under_control
{
    class Database : Conections
    {
        MySqlConnection connection;
        string user;
        string database;
        string password;
        string connectStr;

        // TODO: Insert real data in parameters
        public Database() : base("localhost", 69, new DateTime())
        {
            user = "";
            database = "";
            // Loads password from a txt so it isn't visible in the code
            password = base.GetPassword("dbpass");

            connectStr = "server=" + direction +
                        ";user=" + user +
                        ";database=" + database +
                        ";port=" + port +
                        ";password=" + password;
            connection = new MySqlConnection(connectStr);
        }

        public void Sync()
        {
            string syncFetchQ = ""; // TODO: Add correct query 
            string syncPushQ = ""; // TODO: Add correct query 

            Fetch(new MySqlCommand(syncFetchQ));
            Push(new MySqlCommand(syncPushQ));

            // Manages new alerts from data
            new AlertManager();
        }

        List<string> Fetch(MySqlCommand command)
        {
            List<string> fetchedResult = new List<string>();
            try
            {
                connection.Open();
                MySqlDataReader fetched = command.ExecuteReader();
                while (fetched.Read())
                {
                    foreach (var result in fetched)
                    {
                        fetchedResult.Add(result.ToString());
                    }
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return fetchedResult;
        }

        void Push(MySqlCommand command)
        {
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
