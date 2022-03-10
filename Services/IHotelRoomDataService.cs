using CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Services
{
    public interface IHotelRoomDataService : IEntityDataService<IHotelRoom>
    {
        string AssignRoom();

        bool Checkout(string roomNumber);

        bool SetClean(string roomNumber);

        bool SetOutOfService(string roomNumber);

    }
}
