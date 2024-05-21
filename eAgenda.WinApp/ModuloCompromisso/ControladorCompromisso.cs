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

            if (resultado == DialogResult.OK)
            {
                Compromisso novoCompromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Cadastrar(novoCompromisso);

                CarregarCompromissos();
            }
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
