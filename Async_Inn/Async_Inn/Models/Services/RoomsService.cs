using Async_Inn.Data;
using Async_Inn.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Services
{
    public class RoomsService : IRoomsManager
    {
        private readonly AsyncInnDbContext _context;

        public RoomsService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task Create(Rooms room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Rooms>> GetRoomList()
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

        public void UpdateRooms(int id, Rooms room)
        {
            if (room.ID == id)
            {
                _context.Rooms.Update(room);
                _context.SaveChanges();
            }
        }

        public bool DeleteRooms(int id)
        {
            var rooms = _context.Rooms.Where(i => i.ID == id);
            if (rooms != null)
            {
                _context.Remove(rooms);
                _context.SaveChanges();
            }
            return true;
        }

        public async Task<Rooms> GetRoom(int id)
        {
            Rooms room = await _context.Rooms
                                       .Include(a => a.Amenities)
                                       .FirstOrDefaultAsync(i => i.ID == id);

            return room;
        }
    }
}
