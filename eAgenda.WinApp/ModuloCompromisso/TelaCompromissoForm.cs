using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        private List<Contato> contatos;
        public List<Contato> Contatos
        {
            get { return contatos; }
            set { contatos = value; }
        }
        public Compromisso Compromisso
        {
            set
            {
                txtAssunto.Text = value.Assunto;
                if (value.Categoria == "Remoto")
                {
                    rbRemoto.Checked = true;
                    txtRemoto.Text = value.Endereco;
                }
                else
                {
                    rbPresencial.Checked = true;
                    txtPresencial.Text = value.Endereco;
                }
                dtpData.Value = value.Data;
                dtpHoraInicio.Value = value.HoraInicio;
                dtpHoraTermino.Value = value.HoraTermino;

                if (value.Contato != null)
                {
                    chkPossuiContato.Checked = true;
                    cmbContatos.SelectedItem = value.Contato;
                }
            }
            get { return compromisso; }
        }
        public TelaCompromissoForm()
        {
            InitializeComponent();
        }
        private void CarregarContatos()
        {
            cmbContatos.Items.Clear();
            foreach (Contato contato in contatos)
                cmbContatos.Items.Add(contato);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string assunto = txtAssunto.Text;
                DateTime data = dtpData.Value;
                DateTime horaInicio = dtpHoraInicio.Value;
                DateTime horaTermino = dtpHoraTermino.Value;

                string categoria = rbPresencial.Checked ? "Presencial" : "Remoto";
                string endereco = rbPresencial.Checked ? txtPresencial.Text : txtRemoto.Text;

                compromisso = new Compromisso(assunto, categoria, endereco, data, horaInicio, horaTermino);

                if (chkPossuiContato.Checked)
                    compromisso.Contato = contatos[cmbContatos.SelectedIndex];
                else
                    compromisso.Contato = null;

                List<string> erros = compromisso.Validar();

                if (erros.Count > 0)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                    DialogResult = DialogResult.None;
                }
            }
            else
                DialogResult = DialogResult.None;
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtAssunto.Text))
            {
                txtAssunto.Focus();
                TelaPrincipalForm.Instancia.AtualizarRodape("O campo \"Assunto\" deve ser preenchido!");
                return false;
            }
            if (!(rbRemoto.Checked || rbPresencial.Checked))
            {
                txtRemoto.Focus();
                TelaPrincipalForm.Instancia.AtualizarRodape("Uma das localizações deve ser marcada!");
                return false;
            }
            if (rbPresencial.Checked && string.IsNullOrEmpty(txtPresencial.Text))
            {
                txtPresencial.Focus();
                TelaPrincipalForm.Instancia.AtualizarRodape("O campo \"Presencial\" deve ser preenchido!");
                return false;
            }
            if (rbRemoto.Checked && string.IsNullOrEmpty(txtRemoto.Text))
            {
                txtRemoto.Focus();
                TelaPrincipalForm.Instancia.AtualizarRodape("O campo \"Remoto\" deve ser preenchido!");
                return false;
            }

            return true;
        }

        private void rbRemoto_CheckedChanged(object sender, EventArgs e)
        {
            txtRemoto.Enabled = true;
            txtPresencial.Enabled = false;
            txtPresencial.ResetText();
        }

        private void rbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtRemoto.Enabled = false;
            txtRemoto.ResetText();
            txtPresencial.Enabled = true;
        }

        private void chkPossuiContato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPossuiContato.Checked)
            {
                cmbContatos.Enabled = true;
                CarregarContatos();
            }
            else
                cmbContatos.Enabled = false;
        }
    }
}

