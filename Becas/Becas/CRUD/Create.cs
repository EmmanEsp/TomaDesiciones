using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Becas.Database;

namespace Becas.CRUD
{
    class Create : DatabaseConnection
    {
        public bool Crear(List<string> columnas, List<string> valores, string tabla){
            try
            {              
                string query = "INSERT INTO " + tabla + "(";
                foreach (string str in columnas)
                {
                    query = query + str + ", ";
                }
                query = query.Substring(0, query.Length - 2) + ") VALUES (";
                foreach (string str in columnas)
                {
                    query = query + "?" + str + ", ";
                }
                query = query.Substring(0, query.Length - 2) + ")";

                MySqlCommand command = new MySqlCommand(query, openConnection());
                for (int i = 0; i <= columnas.Count - 1; i++)
                {

                    command.Parameters.AddWithValue("?" + columnas[i], valores[i]);
                }

                command.ExecuteNonQuery();

                closeConnection();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                closeConnection();
                return false;
            }
        }
    }
}
