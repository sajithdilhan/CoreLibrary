using CoreLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreLibrary.Data
{
    public class HotelDataContext : DbContext
    {
        public HotelDataContext(DbContextOptions<HotelDataContext> options) : base(options)
        {

        }

        public DbSet<HotelRoom> Rooms { get; set; }
    }
}
