using Sistema.Hello.Business.Entities;
using Sistema.Hello.Data.Context;

namespace Sistema.Hello.Data.Repositories
{
    public class AgendamentoRepositorio : BaseRepositorio<Agendamento>
    {
        public AgendamentoRepositorio(HelloContext context) : base(context) { }
    }
}
