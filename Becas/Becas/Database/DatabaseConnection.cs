using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Becas.Database
{
    public class DatabaseConnection
    {
        private static string connectionString = "server=localhost; uid=root; pwd=1234; database=becas;";

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }

            set
            {
                connectionString = value;
            }
        }

        public MySqlConnection conexionBD;

        public MySqlConnection openConnection()
        {
            try
            {
                conexionBD = new MySqlConnection();
                conexionBD.ConnectionString = connectionString;
                conexionBD.Open();
                if (conexionBD != null)
                {
                    return conexionBD;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public void closeConnection()
        {
            try
            {
                if (conexionBD.State == System.Data.ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

    }
}
