using System.ComponentModel.DataAnnotations;

namespace CoreLibrary.Entities
{
    public class HotelRoom : IHotelRoom
    {
        private string roomNumber;
        private RoomStatus status;
        private int id;

        [Required]
        [StringLength(10)]
        [Display(Name ="Room Number")]
        public string RoomNumber { get => roomNumber; set => roomNumber = value; }

        [Required]
        public RoomStatus Status { get => status; set => status = value; }

        public int Id { get => id; set => id = value; }
    }
}
