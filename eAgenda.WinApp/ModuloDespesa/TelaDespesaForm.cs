using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TelaDespesaForm : Form
    {
        private Despesa despesa;

        public Despesa Despesa
        {
            get
            { return despesa; }
            set
            {
                txtDescricao.Text = value.Descricao;
                txtValor.Text = value.Valor.ToString();
                dtpData.Value = value.Data;
                cbFormaPagamento.SelectedItem = value.FormaPagamento;
                cbCategorias.SelectedItem = value.Categorias.First();
                foreach (Categoria cat in value.Categorias)
                {
                    listCategoria.Items.Add(cat);
                }
            }
        }
        public TelaDespesaForm(RepositorioCategoria repoCategoria)
        {
            InitializeComponent();
            CarregarFormasPagamento();
            CarregarCategorias(repoCategoria.SelecionarTodos());
        }
        private void CarregarCategorias(List<Categoria> categorias)
        {
            listCategoria.Items.Clear();
            foreach (Categoria cat in categorias)
            {
                cbCategorias.Items.Add(cat);
                cbCategorias.SelectedIndex = 0;
            }
        }
        private void CarregarFormasPagamento()
        {
            Array valoresEnum = Enum.GetValues(typeof(FormaPagamentoEnum));

            foreach (var valor in valoresEnum)
                cbFormaPagamento.Items.Add(valor);

            cbFormaPagamento.SelectedItem = FormaPagamentoEnum.Pix;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            double valor = double.Parse(txtValor.Text);
            DateTime data = dtpData.Value;
            FormaPagamentoEnum formaPag = (FormaPagamentoEnum)cbFormaPagamento.SelectedItem;
            List<Categoria> categorias = new();

            foreach (Categoria cat in listCategoria.Items.Cast<Categoria>().ToList())
            {
                categorias.Add(cat);
            }
            despesa = new Despesa(descricao, valor, data, formaPag, categorias);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listCategoria.Items.Contains(cbCategorias.SelectedItem))
                TelaPrincipalForm.Instancia.AtualizarRodape($"Categoria \"{cbCategorias.SelectedItem}\" já incluída!");
            else
                listCategoria.Items.Add(cbCategorias.SelectedItem);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listCategoria.SelectedItem == null)
            {
                MessageBox.Show("É necessário selecionar uma categoria para remover!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            listCategoria.Items.Remove(listCategoria.SelectedItem);
        }
    }
}
