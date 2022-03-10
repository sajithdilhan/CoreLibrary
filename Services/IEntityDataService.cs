using CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Services
{
    public interface IEntityDataService<T> where T : IEntityBase
    {
        IEnumerable<T> List();

        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

    }
}
