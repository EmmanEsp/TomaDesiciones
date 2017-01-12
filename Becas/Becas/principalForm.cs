using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Becas.Database;
using Becas.Formulario;

namespace Becas
{
    public partial class PrincipalForm : System.Windows.Forms.Form
    {
        Alumno student = new Alumno();
        Usuario user = new Usuario();
        private bool admin;
        public PrincipalForm(List<string> userData, bool admins)
        {
            InitializeComponent();
            if (userData.Count > 3)
            {
                student.setValues(userData);
            }
            else{ user.setValues(userData); }

            admin = admins;
        }

        private void aplicarButton_Click(object sender, EventArgs e)
        {
            AplicarForm apl = new AplicarForm(student);
            apl.ShowDialog();
        }

        private void registrarAlumnoButton_Click(object sender, EventArgs e)
        {
            RegistrarAlumnoForm rgal = new RegistrarAlumnoForm();
            rgal.ShowDialog();
            
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            if (admin)
            {
                aplicarButton.Visible = false;
                perfilButton.Visible = false;

            }
            else
            {
                registrarAlumnoButton.Visible = false;
                aplicarButton.Location = new Point(40, 64);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void perfilButton_Click(object sender, EventArgs e)
        {
            PerfilForm prfm = new PerfilForm(student);
            prfm.ShowDialog();
        }

        private void adminKgada(bool admin)
        {

        }

        private void resultadosButton_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                ResultadosForm rform = new ResultadosForm();
                rform.ShowDialog();
            }
            else
            {
                ResultadosAlumnoForm raform = new ResultadosAlumnoForm(Convert.ToInt32(student.Id));
                raform.ShowDialog();
            }
        }
    }
}
