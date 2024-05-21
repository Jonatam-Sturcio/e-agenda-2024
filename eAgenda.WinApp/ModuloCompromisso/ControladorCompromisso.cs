using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCompromisso
{
    internal class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private ListagemCompromissoControl listagemCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorio)
        {
            repositorioCompromisso = repositorio;
        }
        public override string TipoCadastro { get { return "Compromissos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um compromisso existente"; } }
        public override void Adicionar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Compromisso novoCompromisso = telaCompromisso.Compromisso;

            repositorioCompromisso.Cadastrar(novoCompromisso);

            CarregarCompromissos();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoCompromisso.Assunto}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaCompromissoForm telaCompromisso = new();

            Compromisso compromissoSelecionado = listagemCompromisso.ObterRegistroSelecionado();

            telaCompromisso.Compromisso = compromissoSelecionado;

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Compromisso compromissoEditado = telaCompromisso.Compromisso;

            repositorioCompromisso.Editar(compromissoSelecionado.Id, compromissoEditado);

            CarregarCompromissos();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{compromissoSelecionado.Assunto}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            Compromisso compromissoSelecionado = listagemCompromisso.ObterRegistroSelecionado();
            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{compromissoSelecionado.Assunto}\"?"
                , "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioCompromisso.Excluir(compromissoSelecionado.Id);

            CarregarCompromissos();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{compromissoSelecionado.Assunto}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            CarregarCompromissos();

            return listagemCompromisso;
        }
        private void CarregarCompromissos()
        {
            List<Compromisso> compromisso = repositorioCompromisso.SelecionarTodos();

            listagemCompromisso.AtualizarRegistros(compromisso);
        }
    }
}
