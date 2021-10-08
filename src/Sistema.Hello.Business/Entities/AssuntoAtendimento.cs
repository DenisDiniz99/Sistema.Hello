using System.Collections.Generic;

namespace Sistema.Hello.Business.Entities
{
    public class AssuntoAtendimento : BaseEntidade
    {
        public string TituloAssunto { get; set; }
        public IEnumerable<Agendamento> Agendamentos { get; set; }
    }
}
