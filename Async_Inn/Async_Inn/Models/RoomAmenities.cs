using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    /// <summary>
    /// Joining table for rooms and their respective amenities
    /// </summary>
    public class RoomAmenities
    {
        public int AmenitiesID { get; set; }
        public int RoomsID { get; set; }

        public Amenities Amenities { get; set; }
        public Rooms Rooms { get; set; }
    }
}
