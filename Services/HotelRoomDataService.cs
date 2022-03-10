using CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Services
{
    public class HotelRoomDataService<T> : IHotelRoomDataService<T> where T : HotelRoom
    {
        public string AssignRoom()
        {
            throw new NotImplementedException();
        }

        public void Checkout()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void SetClean()
        {
            throw new NotImplementedException();
        }

        public void SetOutOfService()
        {
            throw new NotImplementedException();
        }
    }
}
