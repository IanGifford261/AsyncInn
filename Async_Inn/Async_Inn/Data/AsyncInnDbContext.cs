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
            //Composite Key Associations
            modelBuilder.Entity<HotelRooms>().HasKey(ce => new { ce.HotelsID, ce.RoomsID });
            modelBuilder.Entity<RoomAmenities>().HasKey(ce => new { ce.RoomsID, ce.AmenitiesID });

            //Seeding Data
            modelBuilder.Entity<Hotels>().HasData(
                new Hotels
                {
                    ID = 1,
                    Name = "Hotel LuluPalooza",
                    StreetAddress = "685 W 8th St",
                    Phone = "408-956-7777"
                },
                new Hotels
                {
                    ID = 2,
                    Name = "San Luis Resort",
                    StreetAddress = "7984 Seawall Blvd",
                    Phone = "409-887-9494"
                },
                new Hotels
                {
                    ID = 3,
                    Name = "Lazy Days Inn & Suites",
                    StreetAddress = "123 Sleepy Ave",
                    Phone = "888-999-1000"
                },
                new Hotels
                {
                    ID = 4,
                    Name = "Whispering Hollow B&B",
                    StreetAddress = "456 Eerie Lane",
                    Phone = "666-666-4242"
                },
                new Hotels
                {
                    ID = 5,
                    Name = "Doomsday Inn",
                    StreetAddress = "000 End Of World Avenue",
                    Phone = "000-000-0001"
                });


        }


        public DbSet<Hotels> Hotels {get; set;}
        public DbSet<HotelRooms> HotelRooms { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
    }
}
