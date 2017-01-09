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
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarControles())
                {
                    Read read = new Read();
                    List<string> items = null;
                    if (userTextBox.TextLength == 13)
                    {
                        items = read.getEntidadw2Parameters("alumno", "curp", userTextBox.Text,
                                                                        "password", passwordTextBox.Text, false);

                    }
                    else
                    {
                        items = read.getEntidadw2Parameters("usuario", "id", userTextBox.Text,
                                                                        "password", passwordTextBox.Text, false);
                    }
                    if (items == null)
                    {
                        MessageBox.Show("Usuario/Contraseña Invalidos");
                        userTextBox.Focus();
                    }
                    else
                    {
                        PrincipalForm principal = new PrincipalForm(items);
                        Hide();
                        principal.Show();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
    }
}
