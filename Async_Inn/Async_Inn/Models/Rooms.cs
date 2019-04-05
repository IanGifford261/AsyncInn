using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Rooms
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Layout { get; set; }


        public ICollection<Amenities> Amenities { get; set; }
        public ICollection<HotelRooms> HotelRooms { get; set; }
    }
}
