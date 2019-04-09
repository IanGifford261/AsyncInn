using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    /// <summary>
    /// joining table for Hotels and their respective rooms
    /// </summary>
    public class HotelRooms
    {
        public int HotelsID { get; set; }
        public int RoomNumber { get; set; }
        public int RoomsID { get; set; }
        public decimal Rate { get; set; }
        public bool PetFriendly { get; set; }

        public Hotels Hotels { get; set; }
        public Rooms Rooms { get; set; }        
    }
}
