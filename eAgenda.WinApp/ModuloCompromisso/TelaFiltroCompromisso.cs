namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromisso : Form
    {
        public TelaFiltroCompromisso()
        {
            InitializeComponent();
        }
        private FiltroCompromissoEnum filtro;
        public FiltroCompromissoEnum Filtro { get { return filtro; } }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            if (rbTodos.Checked)
            {
                filtro = FiltroCompromissoEnum.Todos;
            }
            else if (rbFuturos.Checked)
            {
                filtro = FiltroCompromissoEnum.Futuros;
            }
            else
            {
                filtro = FiltroCompromissoEnum.Passados;
            }

        }
    }
}
