using MySql.Data.MySqlClient;
using System.Data;


namespace vlute_course_manager
{
    internal class MySQLConnect
    {
        readonly private string HOST = "localhost";
        readonly private int PORT = 3306;
        private string USERNAME = "trancon";
        private string PASSWORD = "Anhnam9ce*";
        private string DATABASE_NAME = "vlute_course_manager";

        private static MySqlConnection _connection;

        public MySQLConnect()
        {
            if (_connection == null)
            {
                _connection = new MySqlConnection(
                    $"server={this.HOST};port={this.PORT};user={this.USERNAME};" +
                    $"pwd={this.PASSWORD};database={this.DATABASE_NAME};" +
                    $"AllowUserVariables=True;"
                );
            }
        }

        public DataTable selectQuery(string query)
        {
            _connection.Open();

            MySqlCommand mySqlCommand = new MySqlCommand(query, _connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            _connection.Close();

            return dataTable;
        }

        public DataRow selectQueryOne(string query)
        {
            DataTable result = this.selectQuery(query);

            return result.Rows[0];
        }

        public int query(string query)
        {
            MySqlCommand mysqlCommand = new MySqlCommand(query, _connection);
            _connection.Open();

            int appliedColumnCount = mysqlCommand.ExecuteNonQuery();

            _connection.Close();

            return appliedColumnCount;
        }
    }
}
