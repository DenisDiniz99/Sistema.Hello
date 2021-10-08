using Sistema.Hello.Business.ValuesObjects;
using System;

namespace Sistema.Hello.Business.Entities
{
    public class Agendamento : BaseEntidade
    {
        public DateTime DataAgend => DateTime.Now.Date;
        public DateTime HoraAgend => DateTime.Now.ToLocalTime();
        public DateTime DataAtend { get; set; }
        public DateTime HoraAtend { get; set; }
        public TipoAtendimento TipoAtendimento { get; set; }
        public Protocolo Protocolo { get; set; }
        public Guid CidadaoId { get; set; }
        public Cidadao Cidadao { get; set; }
        public Guid AssuntoId { get; set; }
        public AssuntoAtendimento AssuntoAtendimento { get; set; }
        public Guid SetorId { get; set; }
        public Setor Setor { get; set; }
        //Colaborador que realizou o agendamento
        public Guid ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
        public string Observacao { get; set; }
        public Atendimento Atendimento { get; set; }
    }

    public enum TipoAtendimento
    {
        Presencial,
        Remoto
    }
}
