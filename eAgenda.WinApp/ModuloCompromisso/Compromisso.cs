using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public Contato Contato { get; set; }

        public Compromisso(string assunto, string local, DateTime data, DateTime horaInicio, DateTime horaTermino)
        {
            Assunto = assunto;
            Local = local;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Assunto = atualizado.Assunto;
            Local = atualizado.Local;
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

            if (string.IsNullOrEmpty(Local.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório");

            return erros;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Assunto: {Assunto}, Local: {Local}, Data: {Data.ToString("dd/MM/yyyy")}, " +
                $"Hora de Inicio: {HoraInicio.TimeOfDay}, Hora de Termino: {HoraTermino.TimeOfDay}";
        }
    }
}
