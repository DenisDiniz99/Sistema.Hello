using Sistema.Hello.Business.Entities;
using Sistema.Hello.Data.Context;

namespace Sistema.Hello.Data.Repositories
{
    public class CargoRepositorio : BaseRepositorio<Cargo>
    {
        public CargoRepositorio(HelloContext context) : base(context) { }
    }
}
