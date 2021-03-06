﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    /// <summary>
    /// Amenities model
    /// </summary>
    public class Amenities
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }
}
