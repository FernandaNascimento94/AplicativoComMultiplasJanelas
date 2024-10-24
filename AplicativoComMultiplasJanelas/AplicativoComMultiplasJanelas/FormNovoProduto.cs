namespace AplicativoComMultiplasJanelas
{
    public partial class FormNovoProduto : Form
    {
        public string Nome { get { return textBoxNome.Text; } }
        public string Fabricante { get {  return textBoxFabricante.Text; } }
        public decimal PrecoCompra { get { return numericUpDownPrecoCompra.Value; } }
        public decimal PrecoVenda { get { return numericUpDownPrecoVenda.Value; } }

        public FormNovoProduto()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
