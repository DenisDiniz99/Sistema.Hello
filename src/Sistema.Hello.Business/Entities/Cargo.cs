using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Hello.Business.Entities
{
    public class Cargo : BaseEntidade
    {
        public string TituloCargo { get; set; }
        public Guid SrtorId { get; set; }
        public Setor Setor { get; set; }

        public IEnumerable<Colaborador> Colaboradores { get; set; }
    }
}
