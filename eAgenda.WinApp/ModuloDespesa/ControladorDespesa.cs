using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesa
{
    internal class ControladorDespesa : ControladorBase, IControladorFiltravel
    {
        RepositorioDespesa repositorioDespesa;

        public ControladorDespesa(RepositorioDespesa repositorio)
        {
            repositorioDespesa = repositorio;
        }
        public override string TipoCadastro => "Despesa";

        public override string ToolTipAdicionar => "Cadastrar uma nova despesa";

        public override string ToolTipEditar => "Editar uma despesa existente";

        public override string ToolTipExcluir => "Excluir uma despesa existente";

        public string ToolTipFiltrar => "Filtrar por categoria";

        public override void Adicionar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public void Filtrar()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
