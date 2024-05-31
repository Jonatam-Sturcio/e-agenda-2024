using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloCategoriaDespesa
{
    public partial class TelaCategoriaForm : Form
    {
        private Categoria categoria;
        public Categoria Categoria
        {
            get { return categoria; }
            set
            {
                txtNome.Text = value.Nome;
                txtIdentificador.Text = value.Identificador;
            }
        }
        public TelaCategoriaForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string identificador = txtIdentificador.Text;
            categoria = new Categoria(nome, identificador);

            List<string> erros = categoria.Validar();
            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
