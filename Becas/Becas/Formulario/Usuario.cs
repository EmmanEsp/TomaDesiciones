using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becas.Formulario
{
    class Usuario
    {
        #region private shit
        private string id;
        private string descripcion;
        private string password;
        #endregion

        #region public shit
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        #endregion

        public void setValues(List<string> values)
        {
            Id = values[0];
            Descripcion = values[1];
            Password = values[2];
        }
    }
}
