namespace OneGroup
{
    partial class Fornecedor
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
            txtEmail = new TextBox();
            txtCnpj = new TextBox();
            txtEndereco = new TextBox();
            txtFone = new TextBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(293, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 35);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(293, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 35);
            txtEmail.TabIndex = 1;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(293, 161);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(150, 35);
            txtCnpj.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(293, 225);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(150, 35);
            txtEndereco.TabIndex = 3;
            // 
            // txtFone
            // 
            txtFone.Location = new Point(293, 283);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(150, 35);
            txtFone.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(525, 117);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(525, 174);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 34);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // Fornecedor
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtFone);
            Controls.Add(txtEndereco);
            Controls.Add(txtCnpj);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "Fornecedor";
            Text = "Fornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCnpj;
        private TextBox txtEndereco;
        private TextBox txtFone;
        private Button btnCancelar;
        private Button btnCadastrar;
    }
}