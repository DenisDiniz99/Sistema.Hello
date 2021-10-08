using Sistema.Hello.Business.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema.Hello.Business.Contracts
{
    public interface IRepositorio<T> where T : BaseEntidade
    {
        Task Adicionar(T entidade);
        Task Atualizar(T entidade);
        Task Excluir(Guid id);
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorId(Guid id);
        Task<int> SaveChange();
    }
}
