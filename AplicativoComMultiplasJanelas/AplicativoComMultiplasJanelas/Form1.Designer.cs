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
            buttonProdutos = new Button();
            buttonFornecedores = new Button();
            buttonClientes = new Button();
            buttonCompras = new Button();
            buttonVendas = new Button();
            buttonAdicionarFornecedor = new Button();
            buttonDeletarFornecedor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonNovoProduto
            // 
            buttonNovoProduto.Location = new Point(2, 59);
            buttonNovoProduto.Name = "buttonNovoProduto";
            buttonNovoProduto.Size = new Size(94, 23);
            buttonNovoProduto.TabIndex = 0;
            buttonNovoProduto.Text = "Novo Produto";
            buttonNovoProduto.UseVisualStyleBackColor = true;
            buttonNovoProduto.Click += buttonAdicionarProduto_Click;
            // 
            // buttonDeletarProduto
            // 
            buttonDeletarProduto.Location = new Point(2, 88);
            buttonDeletarProduto.Name = "buttonDeletarProduto";
            buttonDeletarProduto.Size = new Size(94, 26);
            buttonDeletarProduto.TabIndex = 1;
            buttonDeletarProduto.Text = "Deletar Produto";
            buttonDeletarProduto.UseVisualStyleBackColor = true;
            buttonDeletarProduto.Click += buttonDeletarProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(521, 195);
            dataGridView1.TabIndex = 2;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Location = new Point(0, 12);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(96, 41);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.Location = new Point(102, 12);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(125, 41);
            buttonFornecedores.TabIndex = 4;
            buttonFornecedores.Text = "Fornecedores";
            buttonFornecedores.UseVisualStyleBackColor = true;
            buttonFornecedores.Click += buttonFornecedores_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.Location = new Point(233, 12);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(88, 41);
            buttonClientes.TabIndex = 5;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonCompras
            // 
            buttonCompras.Location = new Point(327, 12);
            buttonCompras.Name = "buttonCompras";
            buttonCompras.Size = new Size(83, 41);
            buttonCompras.TabIndex = 6;
            buttonCompras.Text = "Compras";
            buttonCompras.UseVisualStyleBackColor = true;
            buttonCompras.Click += buttonCompras_Click;
            // 
            // buttonVendas
            // 
            buttonVendas.Location = new Point(416, 12);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(88, 41);
            buttonVendas.TabIndex = 7;
            buttonVendas.Text = "Vendas";
            buttonVendas.UseVisualStyleBackColor = true;
            buttonVendas.Click += buttonVendas_Click;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdicionarFornecedor.Location = new Point(107, 59);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(120, 23);
            buttonAdicionarFornecedor.TabIndex = 8;
            buttonAdicionarFornecedor.Text = "Novo Fornecedor";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = true;
            buttonAdicionarFornecedor.Click += buttonAdicionarFornecedor_Click;
            // 
            // buttonDeletarFornecedor
            // 
            buttonDeletarFornecedor.Location = new Point(107, 90);
            buttonDeletarFornecedor.Name = "buttonDeletarFornecedor";
            buttonDeletarFornecedor.Size = new Size(120, 23);
            buttonDeletarFornecedor.TabIndex = 9;
            buttonDeletarFornecedor.Text = "Deletar";
            buttonDeletarFornecedor.UseVisualStyleBackColor = true;
            buttonDeletarFornecedor.Click += buttonDeletarFornecedor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 327);
            Controls.Add(buttonDeletarFornecedor);
            Controls.Add(buttonAdicionarFornecedor);
            Controls.Add(buttonVendas);
            Controls.Add(buttonCompras);
            Controls.Add(buttonClientes);
            Controls.Add(buttonFornecedores);
            Controls.Add(buttonProdutos);
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
        private Button buttonProdutos;
        private Button buttonFornecedores;
        private Button buttonClientes;
        private Button buttonCompras;
        private Button buttonVendas;
        private Button buttonAdicionarFornecedor;
        private Button buttonDeletarFornecedor;
    }
}
