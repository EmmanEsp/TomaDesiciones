﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Becas.Database;
using Becas.Form;

namespace Becas
{
    public partial class PrincipalForm : System.Windows.Forms.Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void aplicarButton_Click(object sender, EventArgs e)
        {
            AplicarForm apl = new AplicarForm();
            apl.ShowDialog();
        }

        private void registrarAlumnoButton_Click(object sender, EventArgs e)
        {
            RegistrarAlumnoForm rgal = new RegistrarAlumnoForm();
            rgal.ShowDialog();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
