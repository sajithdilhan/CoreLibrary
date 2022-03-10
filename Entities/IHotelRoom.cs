using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Entities
{
    public interface IHotelRoom : IEntityBase
    {
        string RoomNumber { get; set; }

        RoomStatus Status { get; set; }

    }
}
