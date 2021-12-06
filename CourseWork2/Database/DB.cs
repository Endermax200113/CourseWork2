using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CourseWork2.Database
{
    public class DB
    {
        private MySqlConnection _connection;

        public bool Connect(string database)
        {
            _connection = new MySqlConnection($"server=localhost;port=3306;username=root;password=root;database={database}");

            if (_connection.State == ConnectionState.Closed)
            {
                try
                {
                    _connection.Open();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Невозможно подключиться к базе данных, так как сервер был отключён", "Сервер отключён", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            return true;
        }

        public void Disconnect()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }

        public void ExecuteCommand(MySqlCommand cmd)
        {
            cmd.Connection = _connection;
            cmd.ExecuteNonQuery();
        }

        public DataTable Select(MySqlCommand cmd)
        {
            cmd.Connection = _connection;

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            return dt;
        }
    }
}
