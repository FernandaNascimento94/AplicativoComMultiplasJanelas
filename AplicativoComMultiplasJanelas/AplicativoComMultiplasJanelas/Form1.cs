using System.ComponentModel;
using static System.Net.WebRequestMethods;

namespace AplicativoComMultiplasJanelas
{
    public partial class Form1 : Form
    {
        private BindingList<Produto> Produtos = new BindingList<Produto>();
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Produtos;
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormNovoProduto fnp = new FormNovoProduto();
            DialogResult resultado = fnp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();

                if (Produtos.Count == 0) produto.Id = 1;
                else produto.Id = Produtos.Max(x => x.Id) + 1;

                produto.Nome = fnp.Nome;
                produto.Fabricante = fnp.Fabricante;
                produto.PrecoVenda = fnp.PrecoVenda;
                produto.PrecoCompra = fnp.PrecoCompra;

                Produtos.Add(produto);

            }
        }

        private void buttonDeletarProduto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Produtos) 
            {
                if (dataGridView1.SelectedRows.Count > 0) 
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }
    }
}
