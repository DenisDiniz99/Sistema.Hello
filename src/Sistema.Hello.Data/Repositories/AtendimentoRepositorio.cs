using Sistema.Hello.Business.Entities;
using Sistema.Hello.Data.Context;

namespace Sistema.Hello.Data.Repositories
{
    public class AtendimentoRepositorio : BaseRepositorio<Atendimento>
    {
        public AtendimentoRepositorio(HelloContext context) : base(context) { }
    }
}
