using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becas.Formulario
{
    public class Alumno
    {
        #region private shit
        private string id;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string curp;
        private string direccionCalle;
        private string direccionNoExt;
        private string direccionNoInt;
        private string direccionColonia;
        private string direccionCP;
        private string genero;
        private string email;
        private string telefono;
        private string password;
        #endregion

        #region Public shit
        public string DireccionCP
        {
            get
            {
                return direccionCP;
            }

            set
            {
                direccionCP = value;
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }

            set
            {
                apellidoPaterno = value;
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }

            set
            {
                apellidoMaterno = value;
            }
        }

        public string Curp
        {
            get
            {
                return curp;
            }

            set
            {
                curp = value;
            }
        }

        public string DireccionNoExt
        {
            get
            {
                return direccionNoExt;
            }

            set
            {
                direccionNoExt = value;
            }
        }

        public string DireccionNoInt
        {
            get
            {
                return direccionNoInt;
            }

            set
            {
                direccionNoInt = value;
            }
        }

        public string DireccionColonia
        {
            get
            {
                return direccionColonia;
            }

            set
            {
                direccionColonia = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string DireccionCalle
        {
            get
            {
                return direccionCalle;
            }

            set
            {
                direccionCalle = value;
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

        #endregion

        public void setNombre(string value)
        {
            Nombre = value;
        }

        public void setValues(List<string> values)
        {
            Id = values[0];
            Nombre = values[1];
            ApellidoPaterno = values[2];
            ApellidoMaterno = values[3];
            Curp = values[4];
            DireccionCalle = values[5];
            DireccionNoExt = values[6];
            DireccionNoInt = values[7];
            DireccionColonia = values[8];
            DireccionCP = values[9];
            Genero = values[10];
            Email = values[11];
            Telefono = values[12];
            Password = values[13];
            
        }

    }
}
