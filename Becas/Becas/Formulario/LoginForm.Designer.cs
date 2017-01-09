namespace Becas.Formulario
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.loginButton = new System.Windows.Forms.Button();
            this.registrarButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.controlsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(252, 88);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(93, 39);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Entrar";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrarButton
            // 
            this.registrarButton.Location = new System.Drawing.Point(153, 88);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(93, 39);
            this.registrarButton.TabIndex = 3;
            this.registrarButton.Text = "Registrarse";
            this.registrarButton.UseVisualStyleBackColor = true;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(104, 14);
            this.userTextBox.MaxLength = 13;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(229, 20);
            this.userTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(104, 40);
            this.passwordTextBox.MaxLength = 15;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(229, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario/CURP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.label2);
            this.controlsPanel.Controls.Add(this.userTextBox);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Controls.Add(this.passwordTextBox);
            this.controlsPanel.Location = new System.Drawing.Point(12, 12);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(364, 70);
            this.controlsPanel.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 141);
            this.Controls.Add(this.registrarButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.controlsPanel);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel controlsPanel;
    }
}