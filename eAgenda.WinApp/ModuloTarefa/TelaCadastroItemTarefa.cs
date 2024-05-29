using System.Data;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaCadastroItemTarefa : Form
    {
        private Tarefa tarefa;

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
            }
        }
        public List<ItemTarefa> ItensAdicionados
        {
            get
            {
                return listItensTarefa.Items.Cast<ItemTarefa>().ToList();
            }
        }

        public TelaCadastroItemTarefa(Tarefa tarefaSelecionada)
        {
            InitializeComponent();
            Tarefa = tarefaSelecionada;

            lblTarefa.Text = tarefaSelecionada.Titulo;

            foreach (ItemTarefa item in tarefaSelecionada.Itens)
                listItensTarefa.Items.Add(item);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (titulos.Contains(txtTitulo.Text))
                return;

            ItemTarefa itemTarefa = new ItemTarefa(txtTitulo.Text);

            listItensTarefa.Items.Add(itemTarefa);
        }
    }
}
