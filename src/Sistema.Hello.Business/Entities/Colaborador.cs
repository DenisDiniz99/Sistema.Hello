using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Hello.Business.Entities
{
    public class Colaborador : BaseEntidade
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public DateTime DataCad => DateTime.Now.Date;
        public Guid CargoId { get; set; }
        public Cargo Cargo { get; set; }

        public IEnumerable<Atendimento> Atendimentos { get; set; }
        public IEnumerable<Agendamento> Agendamentos { get; set; }
    }
}
