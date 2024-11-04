namespace OneGroup
{
    partial class Estoque
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
            dataGridViewEstoque = new DataGridView();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEstoque
            // 
            dataGridViewEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstoque.Location = new Point(217, 78);
            dataGridViewEstoque.Name = "dataGridViewEstoque";
            dataGridViewEstoque.RowHeadersWidth = 62;
            dataGridViewEstoque.Size = new Size(360, 225);
            dataGridViewEstoque.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(433, 323);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(dataGridViewEstoque);
            Name = "Estoque";
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEstoque;
        private Button btnVoltar;
    }
}