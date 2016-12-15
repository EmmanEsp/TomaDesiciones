using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becas.Base_de_Datos
{
    public static class DatabaseConnection
    {
        private static string connectionString = "server=localhost; uid=root; pwd=; database=becas;";

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
    }
}
