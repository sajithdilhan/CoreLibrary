using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CoreLibrary.DataProviders
{
    public interface IEntityDataProvider<T> where T : IEntityBase
    {
        IEnumerable<T> List();
        IQueryable<T> List(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
