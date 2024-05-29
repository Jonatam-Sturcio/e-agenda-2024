using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    internal class ControladorCompromisso : ControladorBase, IControladorFiltravel
    {
        private RepositorioCompromisso repositorioCompromisso;
        private TabelaCompromissoControl TabelaCompromisso;
        private RepositorioContato repositorioContato;

        public ControladorCompromisso(RepositorioCompromisso repositorio, RepositorioContato repContato)
        {
            repositorioCompromisso = repositorio;
            repositorioContato = repContato;
        }
        public override string TipoCadastro { get { return "Compromissos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um compromisso existente"; } }

        public string ToolTipFiltrar { get { return "Filtrar Compromissos"; } }

        public override void Adicionar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            telaCompromisso.Contatos = repositorioContato.SelecionarTodos();

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

            Compromisso compromissoSelecionado = repositorioCompromisso.SelecionarPorId(TabelaCompromisso.ObterRegistroSelecionado());

            if (compromissoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCompromisso.Contatos = repositorioContato.SelecionarTodos();

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
            Compromisso compromissoSelecionado = repositorioCompromisso.SelecionarPorId(TabelaCompromisso.ObterRegistroSelecionado());

            if (compromissoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

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
            if (TabelaCompromisso == null)
                TabelaCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return TabelaCompromisso;
        }
        private void CarregarCompromissos()
        {

            List<Compromisso> compromisso = repositorioCompromisso.SelecionarTodos();
            TabelaCompromisso.AtualizarRegistros(compromisso);

        }
        public void Filtrar()
        {
            TelaFiltroCompromisso telaFiltro = new();

            DialogResult resultado = telaFiltro.ShowDialog();

            if (resultado != DialogResult.OK) return;

            FiltroCompromissoEnum filtro = telaFiltro.Filtro;

            List<Compromisso> compromissosSelecionados;

            if (filtro == FiltroCompromissoEnum.Passados)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosPassados();

            else if (filtro == FiltroCompromissoEnum.Futuros)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosFuturos();

            else if (filtro == FiltroCompromissoEnum.Periodo)
            {
                DateTime dataInicio = telaFiltro.inicioPeriodo;
                DateTime dataTermino = telaFiltro.TerminoPeriodo;

                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosPorPeriodo(dataInicio, dataTermino);
            }
            else
                compromissosSelecionados = repositorioCompromisso.SelecionarTodos();

            TabelaCompromisso.AtualizarRegistros(compromissosSelecionados);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissosSelecionados.Count} registros...");
        }
    }
}
