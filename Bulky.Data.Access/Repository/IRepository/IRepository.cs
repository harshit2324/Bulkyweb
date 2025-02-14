using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Data.Access.Repository.IRepository
{
    internal interface IRepository<T> where T : class
    {
        //T-Category 
        IEnumerable<T> getAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        
    }
}
