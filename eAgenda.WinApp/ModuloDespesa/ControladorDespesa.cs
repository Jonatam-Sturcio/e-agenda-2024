using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloDespesa
{
    internal class ControladorDespesa : ControladorBase, IControladorFiltravel
    {
        private TabelaDespesaControl listDespesa;
        private RepositorioDespesa repositorioDespesa;
        private RepositorioCategoria repositorioCategoria;

        public ControladorDespesa(RepositorioDespesa repositorioD, RepositorioCategoria repositorioC)
        {
            repositorioDespesa = repositorioD;
            repositorioCategoria = repositorioC;
        }
        public override string TipoCadastro => "Despesa";

        public override string ToolTipAdicionar => "Cadastrar uma nova despesa";

        public override string ToolTipEditar => "Editar uma despesa existente";

        public override string ToolTipExcluir => "Excluir uma despesa existente";

        public string ToolTipFiltrar => "Filtrar por categoria";

        public override void Adicionar()
        {
            TelaDespesaForm telaDespesa = new(repositorioCategoria);

            DialogResult resultado = telaDespesa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Despesa novaDespesa = telaDespesa.Despesa;

            repositorioCategoria.MarcarEmUso(novaDespesa.Categorias);

            repositorioDespesa.Cadastrar(novaDespesa);

            CarregarDespesa();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaDespesa.Descricao}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {

            repositorioDespesa.VerificarCategoriaSemUso(repositorioCategoria);
        }

        public void Filtrar()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (listDespesa == null)
                listDespesa = new TabelaDespesaControl();

            CarregarDespesa();

            return listDespesa;
        }
        private void CarregarDespesa()
        {
            List<Despesa> despesa = repositorioDespesa.SelecionarTodos();

            listDespesa.AtualizarRegistros(despesa);
        }
    }
}
