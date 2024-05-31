using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloDespesa
{
    internal class Despesa : EntidadeBase
    {
        public List<Categoria> Categorias { get; set; }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
