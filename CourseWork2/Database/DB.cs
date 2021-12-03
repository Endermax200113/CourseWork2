using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork2.Database
{
    public class DB
    {
        private SqlConnection _connection;

        public DB()
        {
#if DEBUG
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
#endif

#if !DEBUG
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
#endif
        }

        public void Connect()
        {
            _connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database\\Users\\Users.mdf;Integrated Security=True");

            if (IsAvailable())
                _connection.Open();
        }

        private bool IsAvailable()
        {
            try
            {
                _connection.Open();
                _connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("База данных сейчас недоступна", "Проблема с подключением БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void Disconnect()
        {
            _connection.Close();
        }


    }
}
