using CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Services
{
    public interface IHotelRoomDataService<T> :IEntityDataService<T> where T : HotelRoom
    {
        string AssignRoom();

        void Checkout();

        void SetClean();

        void SetOutOfService();
    }
}
