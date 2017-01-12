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
    public partial class PerfilForm : System.Windows.Forms.Form
    {
        Alumno student = new Alumno();
        List<string> columnas;
        List<string> valores;
        Update crUd = new Update();
        Read cRud = new Read();

        public PerfilForm(Alumno userData)
        {
            InitializeComponent();
            student = userData;
            setData();
        }

        private void setData()
        {
            nombreTextBox.Text = student.Nombre;
            apellidoPaternoTextBox.Text = student.ApellidoPaterno;
            apellidoMaternoTextBox.Text = student.ApellidoMaterno;
            generoComboBox.SelectedIndex = Convert.ToInt32(student.Genero)-1;
            curpTextBox.Text = student.Curp;
            emailTextBox.Text = student.Email;
            telefonoTextBox.Text = student.Telefono;
            direccionCalleTextBox.Text = student.DireccionCalle;
            direccionNoExtTextBox.Text = student.DireccionNoExt;
            direccionNoIntTextBox.Text = student.DireccionNoInt;
            direccionCPTextBox.Text = student.DireccionCP;
            direccionColoniaTextBox.Text = student.DireccionColonia;
        }

        private void informaciónPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direccionCPTextBox.Enabled = true;
            direccionNoIntTextBox.Enabled = true;
            direccionColoniaTextBox.Enabled = true;
            direccionNoExtTextBox.Enabled = true;
            direccionCalleTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            updateButton.Visible = true;
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarControles(controlsPanel))
                {
                    updateButton.Visible = false;
                    crUd.updateEntidad(columnas, getValues(), "alumno", student.Id);
                    lockControls();
                    student.setValues(cRud.getEntidad("alumno", Convert.ToInt32(student.Id)));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool validarControles(Panel controles)
        {
            errorProvider.Clear();
            bool continuar = true;
            foreach (Control control in controles.Controls)
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

            foreach (string columna in columnas)
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

        private void PerfilForm_Load(object sender, EventArgs e)
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

        private void lockControls()
        {
            foreach (Control control in controlsPanel.Controls)
            {
                control.Enabled = false;
            }
        }

        private void modificarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contraseñaPanel.Visible = true;
            actualizarButton.Visible = true;
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            if (validarControles(contraseñaPanel))
            {
                if (anteriorTextBox.Text == student.Password)
                {
                    if(passwordTextBox.Text == confirmarTextBox.Text)
                    {
                        crUd.updatePassword(confirmarTextBox.Text, student.Id);
                        anteriorTextBox.Clear();
                        passwordTextBox.Clear();
                        confirmarTextBox.Clear();
                        actualizarButton.Visible = false;
                        contraseñaPanel.Visible = false;
                        student.setValues(cRud.getEntidad("alumno", Convert.ToInt32(student.Id)));
                    }
                    else
                    {
                        errorProvider.SetError(confirmarTextBox, "Contraseñas no coinciden");
                        errorProvider.SetError(passwordTextBox, "Contraseñas no coinciden");
                    }
                }
                else { errorProvider.SetError(anteriorTextBox, "Contraseña Incorrecta"); }
            }
        }
    }
}
