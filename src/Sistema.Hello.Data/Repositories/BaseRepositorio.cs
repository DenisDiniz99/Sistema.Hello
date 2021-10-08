using Microsoft.EntityFrameworkCore;
using Sistema.Hello.Business.Contracts;
using Sistema.Hello.Business.Entities;
using Sistema.Hello.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema.Hello.Data.Repositories
{
    public abstract class BaseRepositorio<T> : IRepositorio<T> where T : BaseEntidade
    {
        protected readonly HelloContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepositorio(HelloContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }


        public async Task Adicionar(T entidade)
        {
            _dbSet.Add(entidade);
            await SaveChange();
        }

        public async Task Atualizar(T entidade)
        {
            _dbSet.Update(entidade);
            await SaveChange();
        }

        public async Task Excluir(Guid id)
        {
            _dbSet.Remove(await ObterPorId(id));
        }

        public async Task<T> ObterPorId(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> ObterTodos()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<int> SaveChange()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
