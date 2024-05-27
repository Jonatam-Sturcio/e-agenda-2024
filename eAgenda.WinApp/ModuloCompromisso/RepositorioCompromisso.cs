using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCompromisso
{
    internal class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        internal List<Compromisso> SelecionarCompromissosFuturos()
        {
            return registros.FindAll(c => c.Data >= DateTime.Today);
        }

        internal List<Compromisso> SelecionarCompromissosPassados()
        {
            return registros.FindAll(c => c.Data < DateTime.Today);
        }

        internal List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return registros.FindAll(c => c.Data >= dataInicio && c.Data <= dataTermino);
        }
    }
}
