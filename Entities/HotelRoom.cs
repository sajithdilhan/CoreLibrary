using System.ComponentModel.DataAnnotations;

namespace CoreLibrary.Entities
{
    public class HotelRoom : IHotelRoom
    {
        private string roomNumber;
        private string status;
        private int id;

        [Required]
        [StringLength(10)]
        [Display(Name ="Room Number")]
        public string RoomNumber { get => roomNumber; set => roomNumber = value; }

        [Required]
        public string Status { get => status; set => status = value; }

        public int Id { get => id; set => id = value; }
    }
}
