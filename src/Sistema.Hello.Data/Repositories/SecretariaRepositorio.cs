using Sistema.Hello.Business.Entities;
using Sistema.Hello.Data.Context;

namespace Sistema.Hello.Data.Repositories
{
    public class SecretariaRepositorio : BaseRepositorio<Secretaria>
    {
        public SecretariaRepositorio(HelloContext context) : base(context) { }
    }
}
