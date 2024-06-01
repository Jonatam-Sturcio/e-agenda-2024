using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoria : RepositorioBase<Categoria>
    {
        public bool ValidarRegistroIgual(Categoria categoria)
        {
            Categoria cat = registros.Find(c => c.Identificador == categoria.Identificador);
            return cat == null ? false : true;
        }
        public bool ValidarPossuiRegistros()
        {
            return registros.Count > 0 ? false : true;
        }

        internal void MarcarEmUso(List<Categoria> categorias)
        {
            foreach (Categoria cat in categorias)
            {
                cat.EmUso = true;
            }
        }
    }
}
