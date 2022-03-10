namespace CoreLibrary.Entities
{
    public class HotelRoom : IHotelRoom
    {
        private string roomNumber;
        private RoomStatus status;
        private int id;

        public string RoomNumber { get => roomNumber; set => roomNumber = value; }
        public RoomStatus Status { get => status; set => status = value; }
        public int Id { get => id; set => id = value; }
    }
}
