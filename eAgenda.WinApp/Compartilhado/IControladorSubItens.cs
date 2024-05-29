namespace eAgenda.WinApp.Compartilhado
{
    public interface IControladorSubItens
    {
        string ToolTipAdicionar { get; }
        string ToolTipConcluirItens { get; }
        void AdicionarItens();
        void AtualizarItens();
    }
}
