using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Becas.CRUD;

namespace Becas.Formulario
{
    public partial class AplicarForm : System.Windows.Forms.Form
    {

        Read read = new Read();
        Alumno student = new Alumno();

        public AplicarForm(Alumno userData)
        {
            InitializeComponent();
            student = userData;
            setData();
        }

        private void setData()
        {
            nombreLabel.Text = student.Nombre;
            if (read.getEntidad("solicitudBeca", Convert.ToInt32(student.Id)) != null) {
                statusLabel.Text = "Test realizado.";
            } else{
                statusLabel.Text = "Test sin realizar.";                
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {

        }

        private void AplicarForm_Load(object sender, EventArgs e)
        {

        }

        private void aplicarButton_Click(object sender, EventArgs e)
        {
            if (read.getEntidad("solicitudBeca", Convert.ToInt32(student.Id)) != null)
            {
                MessageBox.Show("Test ya se realizo.");
            }
            else
            {
                TestForm test = new TestForm(student);
                test.ShowDialog();
                setData();
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
