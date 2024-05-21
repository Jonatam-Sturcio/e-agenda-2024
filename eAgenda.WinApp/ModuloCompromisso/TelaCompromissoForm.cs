namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public Compromisso Compromisso
        {
            set
            {
                txtAssunto.Text = value.Assunto;
                txtLocal.Text = value.Local;
                txtData.Text = value.Data.ToShortDateString();
                txtHoraInicio.Text = value.HoraInicio.ToShortTimeString();
                txtHoraTermino.Text = value.HoraTermino.ToShortTimeString();
            }
            get { return compromisso; }
        }
        public TelaCompromissoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            string local = txtLocal.Text;
            DateTime data = DateTime.Parse(txtData.Text);
            DateTime horaInicio = DateTime.Parse(txtHoraInicio.Text);
            DateTime horaTermino = DateTime.Parse(txtHoraTermino.Text);
            compromisso = new Compromisso(assunto, local, data, horaInicio, horaTermino);
        }
    }
}

