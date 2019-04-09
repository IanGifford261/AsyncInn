using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Rooms
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public RoomLayout Layout { get; set; }


        public ICollection<Amenities> Amenities { get; set; }
        public ICollection<HotelRooms> HotelRooms { get; set; }

        public enum RoomLayout
        {
            SingleQueen,

            DoubleQueen,

            QueenSuite,

            KingSuite,

            KingJacuzzi,

            Penthouse,
        }
    }
}
