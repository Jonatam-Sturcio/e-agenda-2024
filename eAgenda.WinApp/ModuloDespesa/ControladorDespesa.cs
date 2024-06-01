using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloDespesa
{
    internal class ControladorDespesa : ControladorBase, IControladorFiltravel
    {
        private TabelaDespesaControl tabelaDespesa;
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
            TelaDespesaForm telaDespesa = new TelaDespesaForm(repositorioCategoria);

            Despesa despesaSelecionado = repositorioDespesa.SelecionarPorId(tabelaDespesa.ObterRegistroSelecionado());

            if (despesaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaDespesa.Despesa = despesaSelecionado;

            DialogResult resultado = telaDespesa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Despesa despesaEditada = telaDespesa.Despesa;

            repositorioDespesa.Editar(despesaSelecionado.Id, despesaEditada);

            CarregarDespesa();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{despesaEditada.Descricao}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            Despesa despesaSelecionado = repositorioDespesa.SelecionarPorId(tabelaDespesa.ObterRegistroSelecionado());
            if (despesaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{despesaSelecionado.Descricao}\"?"
                , "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioDespesa.Excluir(despesaSelecionado.Id);

            CarregarDespesa();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{despesaSelecionado.Descricao}\" foi excluído com sucesso!");

            repositorioDespesa.VerificarCategoriaSemUso(repositorioCategoria);
        }

        public void Filtrar()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDespesa == null)
                tabelaDespesa = new TabelaDespesaControl();

            CarregarDespesa();

            return tabelaDespesa;
        }
        private void CarregarDespesa()
        {
            List<Despesa> despesa = repositorioDespesa.SelecionarTodos();

            tabelaDespesa.AtualizarRegistros(despesa);
        }
    }
}
