using CoreLibrary.Entities;

namespace CoreLibrary.DataProviders
{
    public interface IHotelRoomsDataProvider : IEntityDataProvider<IHotelRoom>
    {
        IHotelRoom FindByRoomNumber(string roomNumber);
    }
}
