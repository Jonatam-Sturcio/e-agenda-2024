using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCategoria
{
    internal class RepositorioCategoria : RepositorioBase<Categoria>
    {
        public bool ValidarRegistroIgual(Categoria categoria)
        {
            Categoria cat = registros.Find(c => c.Identificador == categoria.Identificador);
            return cat == null ? false : true;
        }
    }
}
