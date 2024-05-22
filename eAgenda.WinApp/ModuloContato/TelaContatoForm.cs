namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public Contato Contato
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtEmail.Text = value.Email;
                txtTelefone.Text = value.Telefone;
                txtCargo.Text = value.Cargo;
                txtEmpresa.Text = value.Empresa;
            }
            get { return contato; }
        }

        public TelaContatoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {

                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string cargo = txtCargo.Text;
                string empresa = txtEmpresa.Text;

                contato = new Contato(nome, telefone, email, empresa, cargo);

                List<string> erros = contato.Validar();

                if (erros.Count > 0)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }
        private bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.Focus();
                TelaPrincipalForm.Instancia.AtualizarRodape("O campo \"Nome\" deve ser preenchido!");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                TelaPrincipalForm.Instancia.AtualizarRodape("O campo \"Email\" deve ser preenchido!");
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                txtTelefone.Focus();
                TelaPrincipalForm.Instancia.AtualizarRodape("O campo \"Telefone\" deve ser preenchido!");
                return false;
            }
            if (string.IsNullOrEmpty(txtCargo.Text))
            {
                txtCargo.Focus();
                TelaPrincipalForm.Instancia.AtualizarRodape("O campo \"Cargo\" deve ser preenchido!");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmpresa.Text))
            {
                txtEmpresa.Focus();
                TelaPrincipalForm.Instancia.AtualizarRodape("O campo \"Empresa\" deve ser preenchido!");
                return false;
            }
            return true;
        }
    }
}
