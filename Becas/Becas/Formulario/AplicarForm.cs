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

namespace Becas.Form
{
    public partial class AplicarForm : System.Windows.Forms.Form
    {
        public AplicarForm()
        {
            InitializeComponent();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {

        }

        private void AplicarForm_Load(object sender, EventArgs e)
        {

            Read read = new Read();
            List<string> items = read.getAllAlumnos("alumno");
            foreach(string item in items)
            {
                buscarTextBox.AutoCompleteCustomSource.Add(item);
            }
        }
    }
}
