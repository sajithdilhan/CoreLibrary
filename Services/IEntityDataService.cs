using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CoreLibrary.Services
{
    public interface IEntityDataService<T> where T : IEntityBase
    {
        IEnumerable<T> List();

        IQueryable<T> List(Expression<Func<T, bool>> predicate);

    }
}
