namespace OneGroup
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSenha = new TextBox();
            txtCodCli = new TextBox();
            btnLogin = new Button();
            btnCadastro = new Button();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(301, 204);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(150, 35);
            txtSenha.TabIndex = 0;
            // 
            // txtCodCli
            // 
            txtCodCli.Location = new Point(301, 126);
            txtCodCli.Name = "txtCodCli";
            txtCodCli.PlaceholderText = "Código";
            txtCodCli.Size = new Size(150, 35);
            txtCodCli.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(178, 302);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(398, 302);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(163, 34);
            btnCadastro.TabIndex = 3;
            btnCadastro.Text = "CADASTRAR";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastro);
            Controls.Add(btnLogin);
            Controls.Add(txtCodCli);
            Controls.Add(txtSenha);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtCodCli;
        private Button btnLogin;
        private Button btnCadastro;
    }
}
