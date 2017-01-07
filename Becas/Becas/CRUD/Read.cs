using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Becas.Database;
using MySql.Data.MySqlClient;

namespace Becas.CRUD
{
    class Read : DatabaseConnection
    {
        public List<string> getEntidad(string tabla, int clave)
        {
            try
            {
                bool id = true;
                List<string> entidad = new List<string>();
                string query = "SELECT * FROM " + tabla + " WHERE id = " + clave;
                MySqlCommand command = new MySqlCommand(query, openConnection());
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return null;
                }
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (id)
                        { id = false; }
                        else
                        {
                            entidad.Add(reader[i].ToString());
                        }
                    }
                }
                closeConnection();
                return entidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
                return null;
            }
        }

        public List<string> getAllEntidades(string tabla)
        {
            try
            {
                bool id = true;
                List<string> entidad = new List<string>();
                string query = "SELECT * FROM " + tabla;
                MySqlCommand command = new MySqlCommand(query, openConnection());
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return null;
                }
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (id)
                        { id = false; }
                        else
                        {
                            entidad.Add(reader[i].ToString());
                        }
                    }
                }
                closeConnection();
                return entidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
                return null;
            }
        }

        public List<string> getAllAlumnos(string tabla)
        {
            try
            {
                List<string> entidad = new List<string>();
                string query = "SELECT * FROM " + tabla;
                MySqlCommand command = new MySqlCommand(query, openConnection());
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return null;
                }
                while (reader.Read())
                {
                    entidad.Add(reader["id"].ToString());
                    entidad.Add(reader["nombre"].ToString());
                    entidad.Add(reader["curp"].ToString());
                }

                closeConnection();
                return entidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeConnection();
                return null;
            }
        }

    }
}
