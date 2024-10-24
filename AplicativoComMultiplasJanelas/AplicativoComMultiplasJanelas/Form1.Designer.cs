namespace AplicativoComMultiplasJanelas
{
    partial class Form1
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
            buttonNovoProduto = new Button();
            buttonDeletarProduto = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonNovoProduto
            // 
            buttonNovoProduto.Location = new Point(12, 12);
            buttonNovoProduto.Name = "buttonNovoProduto";
            buttonNovoProduto.Size = new Size(117, 23);
            buttonNovoProduto.TabIndex = 0;
            buttonNovoProduto.Text = "Novo Produto";
            buttonNovoProduto.UseVisualStyleBackColor = true;
            buttonNovoProduto.Click += buttonAdicionarProduto_Click;
            // 
            // buttonDeletarProduto
            // 
            buttonDeletarProduto.Location = new Point(173, 12);
            buttonDeletarProduto.Name = "buttonDeletarProduto";
            buttonDeletarProduto.Size = new Size(117, 23);
            buttonDeletarProduto.TabIndex = 1;
            buttonDeletarProduto.Text = "Deletar Produto";
            buttonDeletarProduto.UseVisualStyleBackColor = true;
            buttonDeletarProduto.Click += buttonDeletarProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(552, 220);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 320);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDeletarProduto);
            Controls.Add(buttonNovoProduto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNovoProduto;
        private Button buttonDeletarProduto;
        private DataGridView dataGridView1;
    }
}
