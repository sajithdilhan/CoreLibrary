using CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.DataProviders
{
    public interface IHotelRoomsDataProvider : IEntityDataProvider<IHotelRoom>
    {
        IHotelRoom FindByRoomNumber(string roomNumber);
    }
}
