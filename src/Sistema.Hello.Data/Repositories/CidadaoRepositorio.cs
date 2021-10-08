using Sistema.Hello.Business.Entities;
using Sistema.Hello.Data.Context;

namespace Sistema.Hello.Data.Repositories
{
    public class CidadaoRepositorio : BaseRepositorio<Cidadao>
    {
        public CidadaoRepositorio(HelloContext contex) : base(contex) { }
    }
}
