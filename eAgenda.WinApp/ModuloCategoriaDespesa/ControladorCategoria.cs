using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCategoriaDespesa;

namespace eAgenda.WinApp.ModuloCategoria
{
    internal class ControladorCategoria : ControladorBase
    {
        private TabelaCategoriaControl tabelaCategoria;
        private RepositorioCategoria repositorioCategoria;
        public ControladorCategoria(RepositorioCategoria repositorioCategoria)
        {
            this.repositorioCategoria = repositorioCategoria;
        }

        public override string TipoCadastro => "Categoria";

        public override string ToolTipAdicionar => "Cadastrar uma categoria";

        public override string ToolTipEditar => "Editar uma categoria existente";

        public override string ToolTipExcluir => "excluir uma categoria existente";

        public override void Adicionar()
        {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            DialogResult resultado = telaCategoria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Categoria novoCategoria = telaCategoria.Categoria;

            if (repositorioCategoria.ValidarRegistroIgual(novoCategoria))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Já existem categoria com o identificador \"{novoCategoria.Identificador}\", " +
                    $"por favor tente novamente com outro identificador!");
                return;
            }
            repositorioCategoria.Cadastrar(novoCategoria);

            CarregarCategorias();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoCategoria.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaCategoriaForm telaCategoria = new();

            Categoria categoriaSelecionado = repositorioCategoria.SelecionarPorId(tabelaCategoria.ObterRegistroSelecionado());

            if (categoriaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCategoria.Categoria = categoriaSelecionado;

            DialogResult resultado = telaCategoria.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Categoria CategoriaEditado = telaCategoria.Categoria;

            repositorioCategoria.Editar(categoriaSelecionado.Id, CategoriaEditado);

            CarregarCategorias();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{categoriaSelecionado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            Categoria categoriaSelecionado = repositorioCategoria.SelecionarPorId(tabelaCategoria.ObterRegistroSelecionado());
            if (categoriaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (categoriaSelecionado.EmUso)
            {
                MessageBox.Show(
                    "A categoria possui despesas e não pode ser excluída!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{categoriaSelecionado.Nome}\"?"
                , "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioCategoria.Excluir(categoriaSelecionado.Id);

            CarregarCategorias();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{categoriaSelecionado.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCategoria == null)
                tabelaCategoria = new TabelaCategoriaControl();

            CarregarCategorias();

            return tabelaCategoria;
        }
        private void CarregarCategorias()
        {
            List<Categoria> Categorias = repositorioCategoria.SelecionarTodos();

            tabelaCategoria.AtualizarRegistros(Categorias);
        }
    }
}
