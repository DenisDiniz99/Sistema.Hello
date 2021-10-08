using Sistema.Hello.Business.ValuesObjects;
using System.Collections.Generic;
using System;

namespace Sistema.Hello.Business.Entities
{
    public class Setor : BaseEntidade
    {
        public string TituloSetor { get; set; }
        public Guid SecretariaId { get; set; }
        public Secretaria Secretaria { get; set; }
        public Endereco Endereco { get; set; }

        public IEnumerable<Cargo> Cargos { get; set; }
        public IEnumerable<Agendamento> Agendamentos { get; set; }
    }
}
