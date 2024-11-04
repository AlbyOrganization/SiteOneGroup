namespace OneGroup
{
    partial class GestaoVenda
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
            btnVoltar = new Button();
            btnCadFornec = new Button();
            dataGridViewVendas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(468, 165);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCadFornec
            // 
            btnCadFornec.Location = new Point(468, 221);
            btnCadFornec.Name = "btnCadFornec";
            btnCadFornec.Size = new Size(282, 34);
            btnCadFornec.TabIndex = 1;
            btnCadFornec.Text = "CADASTRAR FORNECEDOR";
            btnCadFornec.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVendas
            // 
            dataGridViewVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendas.Location = new Point(72, 142);
            dataGridViewVendas.Name = "dataGridViewVendas";
            dataGridViewVendas.RowHeadersWidth = 62;
            dataGridViewVendas.Size = new Size(360, 225);
            dataGridViewVendas.TabIndex = 2;
            // 
            // GestaoVenda
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewVendas);
            Controls.Add(btnCadFornec);
            Controls.Add(btnVoltar);
            Name = "GestaoVenda";
            Text = "GestaoVenda";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private Button btnCadFornec;
        private DataGridView dataGridViewVendas;
    }
}