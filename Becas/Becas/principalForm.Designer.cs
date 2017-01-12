namespace Becas
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAlumnoButton = new System.Windows.Forms.Button();
            this.aplicarButton = new System.Windows.Forms.Button();
            this.perfilButton = new System.Windows.Forms.Button();
            this.resultadosButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // registrarAlumnoButton
            // 
            this.registrarAlumnoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarAlumnoButton.Image = ((System.Drawing.Image)(resources.GetObject("registrarAlumnoButton.Image")));
            this.registrarAlumnoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarAlumnoButton.Location = new System.Drawing.Point(40, 64);
            this.registrarAlumnoButton.Name = "registrarAlumnoButton";
            this.registrarAlumnoButton.Size = new System.Drawing.Size(180, 80);
            this.registrarAlumnoButton.TabIndex = 1;
            this.registrarAlumnoButton.Text = "                Registrar               Alumno";
            this.registrarAlumnoButton.UseVisualStyleBackColor = true;
            this.registrarAlumnoButton.Click += new System.EventHandler(this.registrarAlumnoButton_Click);
            // 
            // aplicarButton
            // 
            this.aplicarButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.aplicarButton.Location = new System.Drawing.Point(226, 150);
            this.aplicarButton.Name = "aplicarButton";
            this.aplicarButton.Size = new System.Drawing.Size(180, 80);
            this.aplicarButton.TabIndex = 1;
            this.aplicarButton.Text = "Aplicar beca";
            this.aplicarButton.UseVisualStyleBackColor = true;
            this.aplicarButton.Click += new System.EventHandler(this.aplicarButton_Click);
            // 
            // perfilButton
            // 
            this.perfilButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfilButton.Image = ((System.Drawing.Image)(resources.GetObject("perfilButton.Image")));
            this.perfilButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.perfilButton.Location = new System.Drawing.Point(132, 150);
            this.perfilButton.Name = "perfilButton";
            this.perfilButton.Size = new System.Drawing.Size(180, 80);
            this.perfilButton.TabIndex = 2;
            this.perfilButton.Text = "              Perfil";
            this.perfilButton.UseVisualStyleBackColor = true;
            this.perfilButton.Click += new System.EventHandler(this.perfilButton_Click);
            // 
            // resultadosButton
            // 
            this.resultadosButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.resultadosButton.Location = new System.Drawing.Point(226, 64);
            this.resultadosButton.Name = "resultadosButton";
            this.resultadosButton.Size = new System.Drawing.Size(180, 80);
            this.resultadosButton.TabIndex = 3;
            this.resultadosButton.Text = "Obtener Resultado";
            this.resultadosButton.UseVisualStyleBackColor = true;
            this.resultadosButton.Click += new System.EventHandler(this.resultadosButton_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 250);
            this.Controls.Add(this.resultadosButton);
            this.Controls.Add(this.perfilButton);
            this.Controls.Add(this.registrarAlumnoButton);
            this.Controls.Add(this.aplicarButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Becas";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button registrarAlumnoButton;
        private System.Windows.Forms.Button aplicarButton;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button perfilButton;
        private System.Windows.Forms.Button resultadosButton;
    }
}

