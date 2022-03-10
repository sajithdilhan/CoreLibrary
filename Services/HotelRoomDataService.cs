using CoreLibrary.DataProviders;
using CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Services
{
    public class HotelRoomDataService : IHotelRoomDataService
    {
        private readonly IHotelRoomsDataProvider _hotelRoomsDataProvider;
        public HotelRoomDataService(IHotelRoomsDataProvider hotelRoomsDataProvider)
        {
            _hotelRoomsDataProvider = hotelRoomsDataProvider;
        }

        public string AssignRoom()
        {
            var nearestAvailable = this.List().FirstOrDefault(r => r.Status == RoomStatus.Available);
            if (nearestAvailable != null)
            {
                nearestAvailable.Status = RoomStatus.Occupied;
                _hotelRoomsDataProvider.Update(nearestAvailable);
                return nearestAvailable.RoomNumber;
            }
            else
            {
                return string.Empty;
            }
        }

        public bool Checkout(string roomNumber)
        {
            var room = _hotelRoomsDataProvider.FindByRoomNumber(roomNumber);
            if (room != null && room.Status == RoomStatus.Occupied)
            {
                room.Status = RoomStatus.Vacant;
                return true;
            }
            return false;
        }

        public IEnumerable<IHotelRoom> List()
        {
            return _hotelRoomsDataProvider.List();
        }

        public IEnumerable<IHotelRoom> List(Expression<Func<IHotelRoom, bool>> predicate)
        {
            return _hotelRoomsDataProvider.List(predicate);
        }

        public bool SetClean(string roomNumber)
        {
            var room = _hotelRoomsDataProvider.FindByRoomNumber(roomNumber);
            if (room != null && room.Status == RoomStatus.Vacant)
            {
                room.Status = RoomStatus.Available;
                return true;
            }
            return false;
        }

        public bool SetOutOfService(string roomNumber)
        {
            var room = _hotelRoomsDataProvider.FindByRoomNumber(roomNumber);
            if (room != null && room.Status == RoomStatus.Vacant)
            {
                room.Status = RoomStatus.Repair;
                return true;
            }
            return false;
        }
    }
}
