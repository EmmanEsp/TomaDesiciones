using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Becas.Base_de_Datos;

namespace Becas
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void aplicarButton_Click(object sender, EventArgs e)
        {

        }

        private void registrarAlumnoButton_Click(object sender, EventArgs e)
        {
            RegistrarAlumnoForm rgal = new RegistrarAlumnoForm();
            rgal.ShowDialog();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
