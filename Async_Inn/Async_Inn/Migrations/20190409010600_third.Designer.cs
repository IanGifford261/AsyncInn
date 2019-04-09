﻿// <auto-generated />
using System;
using Async_Inn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Async_Inn.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    [Migration("20190409010600_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Async_Inn.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("RoomsID");

                    b.HasKey("ID");

                    b.HasIndex("RoomsID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Balcony"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Mini Fridge"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Mini Bar"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Room Service"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Wifi"
                        },
                        new
                        {
                            ID = 6,
                            Name = "TV"
                        });
                });

            modelBuilder.Entity("Async_Inn.Models.HotelRooms", b =>
                {
                    b.Property<int>("HotelsID");

                    b.Property<int>("RoomsID");

                    b.Property<bool>("PetFriendly");

                    b.Property<decimal>("Rate");

                    b.Property<int>("RoomNumber");

                    b.HasKey("HotelsID", "RoomsID");

                    b.HasIndex("RoomsID");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("Async_Inn.Models.Hotels", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.HasKey("ID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "LuLu",
                            Name = "Hotel LuluPalooza",
                            Phone = "408-956-7777",
                            State = "Washington",
                            StreetAddress = "685 W 8th St"
                        },
                        new
                        {
                            ID = 2,
                            City = "Galveston",
                            Name = "San Luis Resort",
                            Phone = "409-887-9494",
                            State = "Texas",
                            StreetAddress = "7984 Seawall Blvd"
                        },
                        new
                        {
                            ID = 3,
                            City = "Lazyville",
                            Name = "Lazy Days Inn & Suites",
                            Phone = "888-999-1000",
                            State = "Sleepington",
                            StreetAddress = "123 Sleepy Ave"
                        },
                        new
                        {
                            ID = 4,
                            City = "Sleepy Hollow",
                            Name = "Whispering Hollow B&B",
                            Phone = "666-666-4242",
                            State = "Myth",
                            StreetAddress = "456 Eerie Lane"
                        },
                        new
                        {
                            ID = 5,
                            City = "Yellowstone",
                            Name = "Doomsday Inn",
                            Phone = "000-000-0001",
                            State = "Wyoming",
                            StreetAddress = "000 End Of World Avenue"
                        });
                });

            modelBuilder.Entity("Async_Inn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("RoomsID");

                    b.Property<int>("AmenitiesID");

                    b.HasKey("RoomsID", "AmenitiesID");

                    b.HasIndex("AmenitiesID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("Async_Inn.Models.Rooms", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 0,
                            Name = "Single Queen"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 1,
                            Name = "Double Queen"
                        },
                        new
                        {
                            ID = 3,
                            Layout = 2,
                            Name = "Queen Suite"
                        },
                        new
                        {
                            ID = 4,
                            Layout = 3,
                            Name = "King Suite"
                        },
                        new
                        {
                            ID = 5,
                            Layout = 4,
                            Name = "King Jaccuzi"
                        },
                        new
                        {
                            ID = 6,
                            Layout = 5,
                            Name = "Penthouse"
                        });
                });

            modelBuilder.Entity("Async_Inn.Models.Amenities", b =>
                {
                    b.HasOne("Async_Inn.Models.Rooms")
                        .WithMany("Amenities")
                        .HasForeignKey("RoomsID");
                });

            modelBuilder.Entity("Async_Inn.Models.HotelRooms", b =>
                {
                    b.HasOne("Async_Inn.Models.Hotels", "Hotels")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HotelsID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Async_Inn.Models.Rooms", "Rooms")
                        .WithMany("HotelRooms")
                        .HasForeignKey("RoomsID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Async_Inn.Models.RoomAmenities", b =>
                {
                    b.HasOne("Async_Inn.Models.Amenities", "Amenities")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Async_Inn.Models.Rooms", "Rooms")
                        .WithMany()
                        .HasForeignKey("RoomsID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
