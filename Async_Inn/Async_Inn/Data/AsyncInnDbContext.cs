using Async_Inn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRooms>().HasKey(ce => new { ce.HotelID, RoomsID });
            modelBuilder.Entity<RoomAmenities>().HasKey(ce => new { ce.RoomsID, AmenitiesID });
        }


        public DbSet<Hotels> Hotels {get; set;}
        public DbSet<HotelRooms> HotelRooms { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
    }
}
