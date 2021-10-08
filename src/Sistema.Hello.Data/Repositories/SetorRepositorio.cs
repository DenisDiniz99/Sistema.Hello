using Sistema.Hello.Business.Entities;
using Sistema.Hello.Data.Context;

namespace Sistema.Hello.Data.Repositories
{
    public class SetorRepositorio : BaseRepositorio<Setor>
    {
        public SetorRepositorio(HelloContext context) : base(context) { }
    }
}
