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
            int i = 0;

            foreach (Categoria cat in categorias)
            {
                listCategoria.Items.Add(cat);

                if (despesa != null && despesa.Categorias.Contains(cat))
                    listCategoria.SetItemChecked(i, true);

                i++;
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
            foreach (Categoria cat in listCategoria.CheckedItems.Cast<Categoria>().ToList())
            {
                categorias.Add(cat);
            }
            despesa = new Despesa(descricao, valor, data, formaPag, categorias);
        }
    }
}
