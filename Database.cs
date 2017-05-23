// Chris Lund Schober

using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Business_under_control
{
    /*
     * Database - Manages the Database conection.
     */
    class Database : Connection
    {
        MySqlConnection connection;
        string user;
        string database;
        string password;
        string connectStr;

        public Database() :
            base("europe-60.banahosting.com", 3306, DateTime.Now)
        {
            user = "cmosmqez_BUC";
            database = "cmosmqez_stockDB";
            // Loads password from a txt so it isn't visible in the code
            password = base.GetPassword("dbpass");

            connectStr =
                @"SERVER='" + direction + "';" +
                @"DATABASE='" + database + "';" +
                @"UID='"+ user + "';" +
                @"PASSWORD='" + password + "'";

            connection = new MySqlConnection(connectStr);
        }

        public void Sync()
        {
            string syncFetchQ = @"select * from suppliers"; // TODO: Add correct query 
            string syncPushQ = ""; // TODO: Add correct query 

            // TODO: Change
            foreach (DataRow row in Fetch(syncFetchQ).Rows)
            {
                System.Diagnostics.Debug.WriteLine(row["name"].ToString());
            };
            //Push(syncPushQ);

            // Manages new alerts from data
            new AlertManager();
        }

        DataTable Fetch(string queryString)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = queryString;

            try
            {
                MySqlDataReader sqlReader;
                connection.Open();
                sqlReader = command.ExecuteReader();
                DataTable fetchedTable = new DataTable();
                fetchedTable.Load(sqlReader);

                return fetchedTable;
            }
            catch (Exception)
            {
                throw;
            }
        }

        void Push(string queryString)
        {
            try
            {
                connection.Open();
                //command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
