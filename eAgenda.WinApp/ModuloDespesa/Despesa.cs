using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloCategoria;

namespace eAgenda.WinApp.ModuloDespesa
{
    public class Despesa : EntidadeBase
    {
        public Despesa(string descricao, double valor, DateTime data, FormaPagamentoEnum formaPagamento, List<Categoria> categorias)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
            FormaPagamento = formaPagamento;
            Categorias = categorias;
        }

        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set; }
        public List<Categoria> Categorias { get; set; }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Despesa despesa = (Despesa)novoRegistro;
            Descricao = despesa.Descricao;
            Valor = despesa.Valor;
            Data = despesa.Data;
            FormaPagamento = despesa.FormaPagamento;
            Categorias = despesa.Categorias;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros.Add("O campo \"descição\" é obrigatório");

            if (string.IsNullOrEmpty(Valor.ToString().Trim()))
                erros.Add("O campo \"valor\" é obrigatório");

            return erros;
        }
    }
}
