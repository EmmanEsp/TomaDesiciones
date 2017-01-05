using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Becas
{
    public partial class RegistrarAlumnoForm : Form
    {
        public RegistrarAlumnoForm()
        {
            InitializeComponent();
        }

        private void RegistrarAlumnoForm_Load(object sender, EventArgs e)
        {

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
