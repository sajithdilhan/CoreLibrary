using CoreLibrary.Entities;

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
