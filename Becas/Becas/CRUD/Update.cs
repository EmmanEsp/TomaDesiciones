using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Becas.Database;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Becas.CRUD
{
    class Update : DatabaseConnection
    {
        public bool updateEntidad(List<string> columns, List<string> values, string tabla, string clave)
        {
            try
            {
                string query = "UPDATE " + tabla + " SET ";
                for (int i = 0; i <= columns.Count - 1; i++)
                {
                    query = query + columns[i] + "=?" + columns[i] + ", ";
                }
                query = query.Substring(0, query.Length - 2) + " WHERE id = " + clave;
                MySqlCommand command = new MySqlCommand(query, openConnection());
                for (int i = 0; i <= columns.Count - 1; i++)
                {
                    command.Parameters.AddWithValue("?" + columns[i], values[i]);
                }
                command.ExecuteNonQuery();
                closeConnection();
                MessageBox.Show("Actualizado con éxito!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }


        public bool updatePassword(string nuevapass, string id)
        {
            try
            {
                string query = "UPDATE alumno SET password='" + nuevapass + "' where id=" + Convert.ToInt32(id) +";";
                MySqlCommand command = new MySqlCommand(query, openConnection());
                command.ExecuteNonQuery();
                closeConnection();
                MessageBox.Show("Actualizado con éxito!");
                return true;
            }
            catch (Exception)
            { return false; }
        }
    }
}
