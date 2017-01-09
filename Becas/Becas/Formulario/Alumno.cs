using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becas.Formulario
{
    class Alumno
    {
        #region private shit
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

        #endregion

        public void setNombre(string value)
        {
            Nombre = value;
        }

        public void setValues(List<string> values)
        {
            Nombre = values[0];
            ApellidoPaterno = values[1];
            ApellidoMaterno = values[2];
            Curp = values[3];
            DireccionCalle = values[4];
            DireccionNoExt = values[5];
            DireccionNoInt = values[6];
            DireccionColonia = values[7];
            DireccionCP = values[8];
            Genero = values[9];
            Email = values[10];
            Telefono = values[11];
            Password = values[12];
            
        }

    }
}
