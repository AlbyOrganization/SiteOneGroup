namespace OneGroup
{
    partial class Cadastro
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
            txtNome = new TextBox();
            txtFone = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            txtCpf = new TextBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(277, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 35);
            txtNome.TabIndex = 0;
            // 
            // txtFone
            // 
            txtFone.Location = new Point(277, 91);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(150, 35);
            txtFone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(277, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 35);
            txtEmail.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(277, 203);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(150, 35);
            txtEndereco.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(277, 264);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(150, 35);
            txtCpf.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(465, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(174, 356);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(149, 34);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtCpf);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtFone);
            Controls.Add(txtNome);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtFone;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private TextBox txtCpf;
        private Button btnCancelar;
        private Button btnCadastrar;
    }
}