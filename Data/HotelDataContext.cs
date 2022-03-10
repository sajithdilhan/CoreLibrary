using CoreLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreLibrary.Data
{
    public class HotelDataContext : DbContext
    {
        public HotelDataContext(DbContextOptions<HotelDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasData(
                new HotelRoom { Id = 1, RoomNumber = "1A", Status = RoomStatus.Available },
                new HotelRoom { Id = 2, RoomNumber = "1B", Status = RoomStatus.Available },
                new HotelRoom { Id = 3, RoomNumber = "1C", Status = RoomStatus.Available },
                new HotelRoom { Id = 4, RoomNumber = "1D", Status = RoomStatus.Available },
                new HotelRoom { Id = 5, RoomNumber = "1E", Status = RoomStatus.Available },
                new HotelRoom { Id = 6, RoomNumber = "2E", Status = RoomStatus.Available },
                new HotelRoom { Id = 7, RoomNumber = "2D", Status = RoomStatus.Available },
                new HotelRoom { Id = 8, RoomNumber = "2C", Status = RoomStatus.Available },
                new HotelRoom { Id = 9, RoomNumber = "2B", Status = RoomStatus.Available },
                new HotelRoom { Id = 10, RoomNumber = "2A", Status = RoomStatus.Available },
                new HotelRoom { Id = 11, RoomNumber = "3A", Status = RoomStatus.Available },
                new HotelRoom { Id = 12, RoomNumber = "3B", Status = RoomStatus.Available },
                new HotelRoom { Id = 13, RoomNumber = "3C", Status = RoomStatus.Available },
                new HotelRoom { Id = 14, RoomNumber = "3D", Status = RoomStatus.Available },
                new HotelRoom { Id = 15, RoomNumber = "3E", Status = RoomStatus.Available },
                new HotelRoom { Id = 16, RoomNumber = "4E", Status = RoomStatus.Available },
                new HotelRoom { Id = 17, RoomNumber = "4D", Status = RoomStatus.Available },
                new HotelRoom { Id = 18, RoomNumber = "4C", Status = RoomStatus.Available },
                new HotelRoom { Id = 19, RoomNumber = "4B", Status = RoomStatus.Available },
                new HotelRoom { Id = 20, RoomNumber = "4A", Status = RoomStatus.Available }
            );
        }

        public DbSet<HotelRoom> Rooms { get; set; }
    }
}
