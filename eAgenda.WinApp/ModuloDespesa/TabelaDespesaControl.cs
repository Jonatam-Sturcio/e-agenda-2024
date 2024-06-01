using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }
        public void AtualizarRegistros(List<Despesa> despesas)
        {
            string categorias = "";
            grid.Rows.Clear();

            foreach (Despesa d in despesas)
            {
                categorias = String.Join(",", d.Categorias);
                grid.Rows.Add(d.Id, d.Descricao, "R$" + d.Valor, d.FormaPagamento, categorias, d.Data.ToString("dd/MM/yyyy"));
            }
        }
        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                       {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Descrição", HeaderText = "Descrição"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn { DataPropertyName = "FormaDePagamento", HeaderText = "Forma de Pagamento" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoria"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DataDaDespesa", HeaderText = "Data da Despesa" }
                       };
        }
    }
}
