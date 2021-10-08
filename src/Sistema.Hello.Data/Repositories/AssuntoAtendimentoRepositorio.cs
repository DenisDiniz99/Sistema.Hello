using Sistema.Hello.Business.Entities;
using Sistema.Hello.Data.Context;

namespace Sistema.Hello.Data.Repositories
{
    public class AssuntoAtendimentoRepositorio : BaseRepositorio<AssuntoAtendimento>
    {
        public AssuntoAtendimentoRepositorio(HelloContext context) : base(context) { }
    }
}
