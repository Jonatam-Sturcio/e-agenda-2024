using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public TipoCompromissoEnum Categoria { get; set; }
        public string Endereco { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public Contato Contato { get; set; }

        public Compromisso(string assunto, TipoCompromissoEnum categoria, string endereco, DateTime data, DateTime horaInicio, DateTime horaTermino)
        {
            Assunto = assunto;
            Categoria = categoria;
            Endereco = endereco;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Assunto = atualizado.Assunto;
            Endereco = atualizado.Endereco;
            Categoria = atualizado.Categoria;
            Data = atualizado.Data;
            HoraInicio = atualizado.HoraInicio;
            HoraTermino = atualizado.HoraTermino;
            if (atualizado.Contato != null)
                Contato = atualizado.Contato;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Assunto.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Endereco.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório");

            return erros;
        }
        public override string ToString()
        {
            if (Contato != null)
                return $"Id: {Id}, Assunto: {Assunto}, Contato: {Contato.Nome}, Data: {Data.ToString("dd/MM/yyyy")}, " +
                $"Início: {HoraInicio.ToString("HH:mm")}, Término: {HoraTermino.ToString("HH:mm")}, " +
                $"Categoria: {Categoria} ,Endereço: {Endereco}";

            else
                return $"Id: {Id}, Assunto: {Assunto},Data: {Data.ToString("dd/MM/yyyy")}, " +
                $"Início: {HoraInicio.ToString("HH:mm")}, Término: {HoraTermino.ToString("HH:mm")}, " +
                $"Categoria: {Categoria} ,Endereço: {Endereco}";
        }
    }
}
