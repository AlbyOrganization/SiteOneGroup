namespace OneGroup
{
    partial class Produto
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
            btnEditarProd = new Button();
            btnDeletarProd = new Button();
            btnNovoProd = new Button();
            btnVoltar = new Button();
            dataGridViewProd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).BeginInit();
            SuspendLayout();
            // 
            // btnEditarProd
            // 
            btnEditarProd.Location = new Point(231, 64);
            btnEditarProd.Name = "btnEditarProd";
            btnEditarProd.Size = new Size(112, 34);
            btnEditarProd.TabIndex = 0;
            btnEditarProd.Text = "EDITAR";
            btnEditarProd.UseVisualStyleBackColor = true;
            // 
            // btnDeletarProd
            // 
            btnDeletarProd.Location = new Point(382, 64);
            btnDeletarProd.Name = "btnDeletarProd";
            btnDeletarProd.Size = new Size(112, 34);
            btnDeletarProd.TabIndex = 1;
            btnDeletarProd.Text = "DELETAR";
            btnDeletarProd.UseVisualStyleBackColor = true;
            // 
            // btnNovoProd
            // 
            btnNovoProd.Location = new Point(519, 64);
            btnNovoProd.Name = "btnNovoProd";
            btnNovoProd.Size = new Size(112, 34);
            btnNovoProd.TabIndex = 2;
            btnNovoProd.Text = "NOVO";
            btnNovoProd.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(364, 300);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProd
            // 
            dataGridViewProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProd.Location = new Point(50, 159);
            dataGridViewProd.Name = "dataGridViewProd";
            dataGridViewProd.RowHeadersWidth = 62;
            dataGridViewProd.Size = new Size(360, 225);
            dataGridViewProd.TabIndex = 4;
            // 
            // Produto
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewProd);
            Controls.Add(btnVoltar);
            Controls.Add(btnNovoProd);
            Controls.Add(btnDeletarProd);
            Controls.Add(btnEditarProd);
            Name = "Produto";
            Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditarProd;
        private Button btnDeletarProd;
        private Button btnNovoProd;
        private Button btnVoltar;
        private DataGridView dataGridViewProd;
    }
}