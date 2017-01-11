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
    public partial class TestForm : System.Windows.Forms.Form
    {
        public TestForm(Alumno dataUser)
        {
            InitializeComponent();
            student = dataUser;
        }

        List<string> columnas;
        List<string> valores;
        Alumno student;

        private void TestForm_Load(object sender, EventArgs e)
        {
            columnas = new List<string>();
            columnas.Add("idBeca");
            columnas.Add("idAlumno");
            columnas.Add("puntos");
        }

        private bool validarControles()
        {
            errorProvider.Clear();
            bool continuar = true;
            foreach (Control control in controlsPanel.Controls)
            {
                if (control is TextBox & control.Text == string.Empty)
                {
                    control.Select();
                    errorProvider.SetError(control, "Favor de llenar el campo");
                    continuar = false;
                }
                if (control is ComboBox & control.Text == string.Empty)
                {
                    control.Select();
                    errorProvider.SetError(control, "Favor de seleccionar un elemento");
                    continuar = false;
                }
            }
            if (continuar) { return true; }
            else { return false; }
        }

        private List<string> getValues()
        {
            valores = new List<string>();

            valores.Add("0");
            valores.Add(student.Id);
            int puntos = 0;

            foreach(Control control in controlsPanel.Controls)
            {
                if (control is TextBox)
                {
                    puntos += Convert.ToInt32(control.Text);
                }
                if (control is ComboBox)
                {
                    ComboBox nuevo = (ComboBox)control;
                    puntos += Convert.ToInt32(nuevo.SelectedIndex)+1;
                }
            }

            valores.Add(Convert.ToString(puntos));
            return valores;
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            if (validarControles())
            {
                Create crud = new Create();
                crud.Crear(columnas, getValues(), "solicitudBeca");
            }
        }
    }
}