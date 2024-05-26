namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Compromisso> compromissos, FiltroCompromissoEnum filtro)
        {
            DateTime agora = DateTime.Now;

            listCompromissos.Items.Clear();
            if (filtro == FiltroCompromissoEnum.Todos)
            {
                foreach (Compromisso compromisso in compromissos)
                    listCompromissos.Items.Add(compromisso);
            }
            else if (filtro == FiltroCompromissoEnum.Futuros)
            {
                foreach (Compromisso compromisso in compromissos)
                    if (compromisso.Data >= agora)
                    {
                        listCompromissos.Items.Add(compromisso);
                    }

            }
            else if (filtro == FiltroCompromissoEnum.Passados)
            {
                foreach (Compromisso compromisso in compromissos)
                    if (compromisso.Data < agora)
                    {
                        listCompromissos.Items.Add(compromisso);
                    }

            }
        }
        public Compromisso ObterRegistroSelecionado()
        {
            if (listCompromissos.SelectedItems == null)
                return null;

            return (Compromisso)listCompromissos.SelectedItem;
        }
    }
}
