using Async_Inn.Data;
using Async_Inn.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Services
{
    public class HotelsService : IHotelsManager
    {
        private readonly AsyncInnDbContext _context;

        public HotelsService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task Create(Hotels hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }
        
        public async Task<List<Hotels>> GetHotelList()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task<Hotels> GetHotel(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return null;
            }
            return hotel;
        }

        public async Task UpdateHotels(int id, Hotels hotels)
        {
            if (hotels.ID == id)
            {
                _context.Hotels.Update(hotels);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteHotels(int id)
        {
            var hotels = _context.Hotels.Where(i => i.ID == id);
            if (hotels != null)
            {
                _context.Remove(hotels);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Rooms>> GetRoomsList()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Rooms> GetRoom(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return null;
            }
            return room;
        }

        //public async Task<Hotels> GetHotel(int id)
        //{
        //    Hotels hotel = await _context.Hotels
        //                               .Include(a => a.HotelRooms)
        //                               .FirstOrDefaultAsync(i => i.ID == id);
        //    return hotel;
        //}

        public bool HotelsExists(int id)
        {
            return _context.Hotels.Any(e => e.ID == id);
        }
    }
}
