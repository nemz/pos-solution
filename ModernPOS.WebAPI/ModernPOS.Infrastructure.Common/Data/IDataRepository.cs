using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ModernPOS.Infrastructure.Common.Data
{
    public interface IDataRepository <T> where T: class, new()
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);

        void Create(T entity);
        void Delete(T entity);
        T Update(T entity);


    }
}
