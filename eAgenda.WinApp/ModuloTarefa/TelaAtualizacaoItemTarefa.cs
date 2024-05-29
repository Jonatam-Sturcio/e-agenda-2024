using System.Data;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizacaoItemTarefa : Form
    {
        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                return listItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems
                    .Cast<ItemTarefa>().ToList();
            }
        }
        public TelaAtualizacaoItemTarefa(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            lbTitulo.Text = tarefaSelecionada.Titulo;

            CarregarItensSelecionados(tarefaSelecionada);
        }
        private void CarregarItensSelecionados(Tarefa tarefaSelecionada)
        {
            int i = 0;

            foreach (ItemTarefa item in tarefaSelecionada.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.Concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
