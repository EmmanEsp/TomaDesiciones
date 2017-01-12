using Becas.CRUD;
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
    public partial class ResultadosAlumnoForm : Form
    {
        private int id;
        public ResultadosAlumnoForm(int idAlumno)
        {
            InitializeComponent();
            id = idAlumno;
        }

        Read cRud = new Read();

        private void ResultadosAlumnoForm_Load(object sender, EventArgs e)
        {
            if(cRud.getResultado("solicitudBeca", id))
            {
                label1.Text = @"FELICIDADES, USTED OBTUVO LOS PUNTOS
NECESARIOS PARA LA BECA SOLICITADA";
            }
            else
            {
                label1.Text = @"LO SENTIMOS, USTED NO OBTUVO LA PUNTUACION
REQUERIDA PARA LA BECA SOLICITADA";
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
