namespace Becas
{
    partial class RegistrarAlumnoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarButton = new System.Windows.Forms.Button();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.direccionNoIntTextBox = new System.Windows.Forms.TextBox();
            this.direccionCPTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.direccionColoniaTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.direccionNoExtTextBox = new System.Windows.Forms.TextBox();
            this.direccionCalleTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.curpTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apellidoPaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMaternoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // registrarButton
            // 
            this.registrarButton.Location = new System.Drawing.Point(574, 233);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(98, 43);
            this.registrarButton.TabIndex = 28;
            this.registrarButton.Text = "Registrar";
            this.registrarButton.UseVisualStyleBackColor = true;
            this.registrarButton.Click += new System.EventHandler(this.registrarButton_Click);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.generoComboBox);
            this.controlsPanel.Controls.Add(this.label13);
            this.controlsPanel.Controls.Add(this.direccionNoIntTextBox);
            this.controlsPanel.Controls.Add(this.direccionCPTextBox);
            this.controlsPanel.Controls.Add(this.label12);
            this.controlsPanel.Controls.Add(this.label11);
            this.controlsPanel.Controls.Add(this.direccionColoniaTextBox);
            this.controlsPanel.Controls.Add(this.label10);
            this.controlsPanel.Controls.Add(this.label9);
            this.controlsPanel.Controls.Add(this.label8);
            this.controlsPanel.Controls.Add(this.direccionNoExtTextBox);
            this.controlsPanel.Controls.Add(this.direccionCalleTextBox);
            this.controlsPanel.Controls.Add(this.telefonoTextBox);
            this.controlsPanel.Controls.Add(this.label7);
            this.controlsPanel.Controls.Add(this.label6);
            this.controlsPanel.Controls.Add(this.emailTextBox);
            this.controlsPanel.Controls.Add(this.curpTextBox);
            this.controlsPanel.Controls.Add(this.label4);
            this.controlsPanel.Controls.Add(this.label3);
            this.controlsPanel.Controls.Add(this.label2);
            this.controlsPanel.Controls.Add(this.apellidoPaternoTextBox);
            this.controlsPanel.Controls.Add(this.apellidoMaternoTextBox);
            this.controlsPanel.Controls.Add(this.nombreTextBox);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Location = new System.Drawing.Point(0, 27);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(698, 200);
            this.controlsPanel.TabIndex = 29;
            // 
            // generoComboBox
            // 
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Items.AddRange(new object[] {
            "Masculin",
            "Femenino"});
            this.generoComboBox.Location = new System.Drawing.Point(109, 126);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(82, 21);
            this.generoComboBox.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Genero";
            // 
            // direccionNoIntTextBox
            // 
            this.direccionNoIntTextBox.Location = new System.Drawing.Point(589, 112);
            this.direccionNoIntTextBox.Name = "direccionNoIntTextBox";
            this.direccionNoIntTextBox.Size = new System.Drawing.Size(76, 20);
            this.direccionNoIntTextBox.TabIndex = 44;
            // 
            // direccionCPTextBox
            // 
            this.direccionCPTextBox.Location = new System.Drawing.Point(109, 160);
            this.direccionCPTextBox.Name = "direccionCPTextBox";
            this.direccionCPTextBox.Size = new System.Drawing.Size(126, 20);
            this.direccionCPTextBox.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Código Postal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Colonia";
            // 
            // direccionColoniaTextBox
            // 
            this.direccionColoniaTextBox.Location = new System.Drawing.Point(437, 138);
            this.direccionColoniaTextBox.Name = "direccionColoniaTextBox";
            this.direccionColoniaTextBox.Size = new System.Drawing.Size(228, 20);
            this.direccionColoniaTextBox.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(524, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "No. Interior";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "No. Exterior";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Calle";
            // 
            // direccionNoExtTextBox
            // 
            this.direccionNoExtTextBox.Location = new System.Drawing.Point(437, 112);
            this.direccionNoExtTextBox.Name = "direccionNoExtTextBox";
            this.direccionNoExtTextBox.Size = new System.Drawing.Size(76, 20);
            this.direccionNoExtTextBox.TabIndex = 43;
            // 
            // direccionCalleTextBox
            // 
            this.direccionCalleTextBox.Location = new System.Drawing.Point(437, 86);
            this.direccionCalleTextBox.Name = "direccionCalleTextBox";
            this.direccionCalleTextBox.Size = new System.Drawing.Size(228, 20);
            this.direccionCalleTextBox.TabIndex = 42;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(435, 38);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(230, 20);
            this.telefonoTextBox.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(435, 15);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(230, 20);
            this.emailTextBox.TabIndex = 40;
            // 
            // curpTextBox
            // 
            this.curpTextBox.Location = new System.Drawing.Point(109, 93);
            this.curpTextBox.Name = "curpTextBox";
            this.curpTextBox.Size = new System.Drawing.Size(200, 20);
            this.curpTextBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "CURP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Apellido Paterno";
            // 
            // apellidoPaternoTextBox
            // 
            this.apellidoPaternoTextBox.Location = new System.Drawing.Point(109, 41);
            this.apellidoPaternoTextBox.Name = "apellidoPaternoTextBox";
            this.apellidoPaternoTextBox.Size = new System.Drawing.Size(260, 20);
            this.apellidoPaternoTextBox.TabIndex = 34;
            // 
            // apellidoMaternoTextBox
            // 
            this.apellidoMaternoTextBox.Location = new System.Drawing.Point(109, 67);
            this.apellidoMaternoTextBox.Name = "apellidoMaternoTextBox";
            this.apellidoMaternoTextBox.Size = new System.Drawing.Size(260, 20);
            this.apellidoMaternoTextBox.TabIndex = 35;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(109, 18);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(260, 20);
            this.nombreTextBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(426, 239);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(87, 31);
            this.limpiarButton.TabIndex = 30;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // RegistrarAlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 334);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.registrarButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistrarAlumnoForm";
            this.Text = "RegistrarAlumnoForm";
            this.Load += new System.EventHandler(this.RegistrarAlumnoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox direccionNoIntTextBox;
        private System.Windows.Forms.TextBox direccionCPTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox direccionColoniaTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox direccionNoExtTextBox;
        private System.Windows.Forms.TextBox direccionCalleTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox curpTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellidoPaternoTextBox;
        private System.Windows.Forms.TextBox apellidoMaternoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarButton;
    }
}