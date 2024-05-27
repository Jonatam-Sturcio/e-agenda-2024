using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class ListagemTarefaControl : UserControl
    {
        public ListagemTarefaControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa tarefa in tarefas)
                listTarefas.Items.Add(tarefa);
        }
        public Tarefa ObterRegistroSelecionado()
        {
            if (listTarefas.SelectedItems == null)
                return null;

            return (Tarefa)listTarefas.SelectedItem;
        }
    }
}
