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
    public partial class ResultadosForm : Form
    {
        public ResultadosForm()
        {
            InitializeComponent();
        }
        Read cRud = new Read();

        private void ResultadosForm_Load(object sender, EventArgs e)
        {
            getResultados(ResultadosDataGridView);
            filtroComboBox.SelectedIndex = 0;
        }

        private void getResultados(DataGridView results)
        {
            cRud.getAllValues("solicitudBeca", results, filtroComboBox.SelectedIndex);
            ResultadosDataGridView.Columns[0].Visible = false;
            ResultadosDataGridView.Columns[1].Visible = false;
           
        }

        private void filtroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getResultados(ResultadosDataGridView);
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
