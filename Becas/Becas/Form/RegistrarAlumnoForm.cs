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

namespace Becas
{
    public partial class RegistrarAlumnoForm : System.Windows.Forms.Form
    {
        List<string> columnas;
        List<string> valores;
        Create crud = new Create();

        public RegistrarAlumnoForm()
        {
            InitializeComponent();
        }

        private void RegistrarAlumnoForm_Load(object sender, EventArgs e)
        {
            columnas = new List<string>();
            columnas.Add("nombre");
            columnas.Add("apellidoPaterno");
            columnas.Add("apellidoMaterno");
            columnas.Add("curp");
            columnas.Add("direccionCalle");
            columnas.Add("direccionNoExt");
            columnas.Add("direccionNoInt");
            columnas.Add("direccionColonia");
            columnas.Add("direccionCP");
            columnas.Add("genero");
            columnas.Add("email");
            columnas.Add("telefono");
        }

        private bool validarControles()
        {
            foreach (Control control in controlsPanel.Controls)
            {
                if (control is TextBox & control.Text == string.Empty)
                {
                    control.Select();
                    MessageBox.Show("Favor de llenar el campo.");
                    return false;
                }
                if (control is ComboBox & control.Text == string.Empty)
                {
                    control.Select();
                    MessageBox.Show("Favor de seleccionar un elemento.");
                    return false;
                }
            }
            return true;
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<string> getValues()
        {
            valores = new List<string>();

            foreach(string columna in columnas)
            {
                foreach (Control control in controlsPanel.Controls)
                {
                    string nombreControl = control.Name.Replace(control.GetType().ToString().Replace("System.Windows.Forms.", ""), "");

                    if (columna.ToString() == nombreControl)
                    {
                        if (control is TextBox)
                        {
                            valores.Add(control.Text);
                        }
                        else if (control is ComboBox)
                        {
                            ComboBox comboBoxIndex = (ComboBox)control;
                            valores.Add(Convert.ToString(comboBoxIndex.SelectedIndex + 1));
                        }
                    }
                }
            }
            
            return valores;
        }

        private void registrarButton_Click(object sender, EventArgs e)
        {
            if (validarControles())
            {                
                crud.Crear(columnas, getValues(), "alumno");
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            foreach(Control control in controlsPanel.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Text = "";

                }
            }
        }
    }
}
