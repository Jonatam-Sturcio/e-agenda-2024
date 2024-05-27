namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromisso : Form
    {
        public TelaFiltroCompromisso()
        {
            InitializeComponent();
        }
        public FiltroCompromissoEnum Filtro { get; private set; }
        public DateTime inicioPeriodo { get { return dtpInicio.Value; } }
        public DateTime TerminoPeriodo { get { return dtpTermino.Value; } }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            if (rbTodos.Checked)
            {
                Filtro = FiltroCompromissoEnum.Todos;
            }
            else if (rbFuturos.Checked)
            {
                Filtro = FiltroCompromissoEnum.Futuros;
            }
            else if (rbPassados.Checked)
            {
                Filtro = FiltroCompromissoEnum.Passados;
            }
            else if (rbPeriodo.Checked)
            {
                Filtro = FiltroCompromissoEnum.Periodo;
            }

        }

        private void rbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeriodo.Checked)
            {
                dtpInicio.Enabled = true;
                dtpTermino.Enabled = true;
            }
            else
            {
                dtpInicio.Enabled = false;
                dtpTermino.Enabled = false;
            }
        }
    }
}
