using Sistema.Hello.Business.Entities;
using Sistema.Hello.Data.Context;

namespace Sistema.Hello.Data.Repositories
{
    public class ColaboradorRepositorio : BaseRepositorio<Colaborador>
    { 
        public ColaboradorRepositorio(HelloContext context) : base(context) { }
    }
}
