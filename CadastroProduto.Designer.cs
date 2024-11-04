namespace OneGroup
{
    partial class CadastroProduto
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
            txtPreco = new TextBox();
            txtDesc = new TextBox();
            txtCategoria = new TextBox();
            txtMarca = new TextBox();
            txtDataEntrada = new TextBox();
            txtDataVenda = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(284, 31);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(150, 35);
            txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(284, 94);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(150, 35);
            txtPreco.TabIndex = 1;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(284, 166);
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Descrição";
            txtDesc.Size = new Size(150, 35);
            txtDesc.TabIndex = 2;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(284, 236);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Categoria";
            txtCategoria.Size = new Size(150, 35);
            txtCategoria.TabIndex = 3;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(284, 298);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(150, 35);
            txtMarca.TabIndex = 4;
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.Location = new Point(284, 352);
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.PlaceholderText = "Data de Entrada";
            txtDataEntrada.Size = new Size(150, 35);
            txtDataEntrada.TabIndex = 5;
            // 
            // txtDataVenda
            // 
            txtDataVenda.Location = new Point(284, 403);
            txtDataVenda.Name = "txtDataVenda";
            txtDataVenda.PlaceholderText = "Data de Venda";
            txtDataVenda.Size = new Size(150, 35);
            txtDataVenda.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(522, 125);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(146, 34);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(522, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 34);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtDataVenda);
            Controls.Add(txtDataEntrada);
            Controls.Add(txtMarca);
            Controls.Add(txtCategoria);
            Controls.Add(txtDesc);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtDesc;
        private TextBox txtCategoria;
        private TextBox txtMarca;
        private TextBox txtDataEntrada;
        private TextBox txtDataVenda;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}