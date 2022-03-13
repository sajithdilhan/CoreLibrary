namespace CoreLibrary.Entities
{
    public interface IHotelRoom : IEntityBase
    {
        string RoomNumber { get; set; }

        string Status { get; set; }

    }
}
