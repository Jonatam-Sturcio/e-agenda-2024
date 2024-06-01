using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TelaFiltroDespesa : Form
    {
        private Categoria filtro;
        public Categoria Filtro { get { return filtro; } }
        public TelaFiltroDespesa(RepositorioCategoria repositorioCategoria)
        {
            InitializeComponent();
            CarregarCategorias(repositorioCategoria);
        }

        private void CarregarCategorias(RepositorioCategoria repositorioCategoria)
        {
            foreach (Categoria c in repositorioCategoria.SelecionarTodos())
            {
                cbCategorias.Items.Add(c);
            }

        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbCategorias.Enabled = rbCategoria.Checked;
            if (cbCategorias.Enabled)
                cbCategorias.SelectedIndex = 0;
            else
                cbCategorias.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                filtro = null;
            }
            else
            {
                filtro = (Categoria)cbCategorias.SelectedItem;
            }
        }
    }
}
