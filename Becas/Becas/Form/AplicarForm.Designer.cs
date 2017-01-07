namespace Becas.Form
{
    partial class AplicarForm
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
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.buscarTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.buscarTextBox.Location = new System.Drawing.Point(40, 49);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(146, 20);
            this.buscarTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estudiante:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(214, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ficha del estudiante";
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(70, 84);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(81, 28);
            this.buscarButton.TabIndex = 4;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // AplicarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 204);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarTextBox);
            this.Name = "AplicarForm";
            this.Text = "Aplicar";
            this.Load += new System.EventHandler(this.AplicarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buscarButton;
    }
}