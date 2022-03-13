using CoreLibrary.DataProviders;
using CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


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
            var nearestAvailable = this.List().FirstOrDefault(r => r.Status == RoomStatusExtensions.Status_Available);
            if (nearestAvailable != null)
            {
                nearestAvailable.Status = RoomStatusExtensions.Status_Occupied;
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
            if (room != null && room.Status == RoomStatusExtensions.Status_Occupied)
            {
                room.Status = RoomStatusExtensions.Status_Vacant;
                _hotelRoomsDataProvider.Update(room);
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
            if (room != null && room.Status == RoomStatusExtensions.Status_Vacant)
            {
                room.Status = RoomStatusExtensions.Status_Available.ToString();
                _hotelRoomsDataProvider.Update(room);
                return true;
            }
            return false;
        }

        public bool SetOutOfService(string roomNumber)
        {
            var room = _hotelRoomsDataProvider.FindByRoomNumber(roomNumber);
            if (room != null && room.Status == RoomStatusExtensions.Status_Vacant)
            {
                room.Status = RoomStatusExtensions.Status_Repair;
                _hotelRoomsDataProvider.Update(room);
                return true;
            }
            return false;
        }
    }
}
