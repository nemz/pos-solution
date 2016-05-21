using ModernPOS.Infrastructure.Common.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPOS.Data.Access.Context
{
    public abstract class RepositoryBase<T> : IDataRepository<T> where T: class, new()
    {
        private readonly PosContext _context;

        private readonly DbSet<T> _set;

        public RepositoryBase(PosContext posContext)
        {
            _context = posContext;

            _set = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            var result = _set.Where(e => e != null);

            return result;
        }

        public T Get(int id)
        {
            var result = _set.Find(id);

            return result;
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            var result = _set.Where(predicate);

            return result;
        }

        public void Create(T entity)
        {
            _set.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Deleted;
        }

        public T Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;

            return entity;
        }
    }
}
