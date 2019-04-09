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
        /// <summary>
        /// Method to hold composite keys and seed data
        /// </summary>
        /// <param name="modelBuilder"></param>
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
                    City = "LuLu",
                    State = "Washington",
                    Phone = "408-956-7777",
                },
                new Hotels
                {
                    ID = 2,
                    Name = "San Luis Resort",
                    StreetAddress = "7984 Seawall Blvd",
                    City = "Galveston",
                    State = "Texas",
                    Phone = "409-887-9494",
                },
                new Hotels
                {
                    ID = 3,
                    Name = "Lazy Days Inn & Suites",
                    StreetAddress = "123 Sleepy Ave",
                    City = "Lazyville",
                    State = "Sleepington",
                    Phone = "888-999-1000",
                },
                new Hotels
                {
                    ID = 4,
                    Name = "Whispering Hollow B&B",
                    StreetAddress = "456 Eerie Lane",
                    City = "Sleepy Hollow",
                    State = "Myth",
                    Phone = "666-666-4242",
                },
                new Hotels
                {
                    ID = 5,
                    Name = "Doomsday Inn",
                    StreetAddress = "000 End Of World Avenue",
                    City = "Yellowstone",
                    State = "Wyoming",
                    Phone = "000-000-0001",
                });
            modelBuilder.Entity<Rooms>().HasData(
                new Rooms
                {
                    ID = 1,
                    Name = "Single Queen",
                    Layout = Models.Rooms.RoomLayout.SingleQueen,
                },
                new Rooms
                {
                    ID = 2,
                    Name = "Double Queen",
                    Layout = Models.Rooms.RoomLayout.DoubleQueen,
                },
                new Rooms
                {
                    ID = 3,
                    Name = "Queen Suite",
                    Layout = Models.Rooms.RoomLayout.QueenSuite,
                },
                new Rooms
                {
                    ID = 4,
                    Name = "King Suite",
                    Layout = Models.Rooms.RoomLayout.KingSuite,
                },
                new Rooms
                {
                    ID = 5,
                    Name = "King Jaccuzi",
                    Layout = Models.Rooms.RoomLayout.KingJacuzzi,
                },
                new Rooms
                {
                    ID = 6,
                    Name = "Penthouse",
                    Layout = Models.Rooms.RoomLayout.Penthouse,
                });
            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Balcony",
                },
                new Amenities
                {
                    ID = 2,
                    Name = "Mini Fridge",
                },
                new Amenities
                {
                    ID = 3,
                    Name = "Mini Bar",
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Room Service",
                },
                new Amenities
                {
                    ID = 5,
                    Name = "Wifi",
                },
                new Amenities
                {
                    ID = 6,
                    Name = "TV",
                });


        }


        public DbSet<Hotels> Hotels {get; set;}
        public DbSet<HotelRooms> HotelRooms { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
    }
}
