using Sistema.Hello.Business.ValuesObjects;
using System;

namespace Sistema.Hello.Business.Entities
{
    public class Atendimento : BaseEntidade
    {
        public Guid AgendamentoId { get; set; }
        public Agendamento Agendamento { get; set; }
        public Protocolo Protocolo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAtend { get; set; }
        public DateTime HoraAtend { get; set; }
        public Guid CidadaoId { get; set; }
        public Cidadao Cidadao { get; set; }
        //Colaborador que realizou o atendimento
        public Guid ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
        public StatusAtendimento StatusAtendimento { get; set; }
    }

    public enum StatusAtendimento
    {
        Aberto,
        Cancelado,
        Finalizado,
        Parado
    }

}

