using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCategoria
{
    public class Categoria : EntidadeBase
    {
        public string Nome { get; set; }
        public string Identificador { get; set; }
        public bool EmUso { get; set; }
        public Categoria(string nome, string identificador)
        {
            Nome = nome;
            Identificador = identificador;
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Categoria cat = (Categoria)novoRegistro;
            Nome = cat.Nome;
            Identificador = cat.Identificador;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");
            if (string.IsNullOrEmpty(Identificador.Trim()))
                erros.Add("O campo \"identificador\" é obrigatório");

            return erros;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}