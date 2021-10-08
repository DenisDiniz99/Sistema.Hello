using Sistema.Hello.Business.ValuesObjects;
using System;
using System.Collections.Generic;

namespace Sistema.Hello.Business.Entities
{
    public class Cidadao : BaseEntidade
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNasc { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public DateTime DataCad { get; set; }
        public Endereco Endereco { get; set; }

        public IEnumerable<Agendamento> Agendamentos { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }
    }
}
