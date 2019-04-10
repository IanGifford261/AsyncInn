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
        private AsyncInnDbContext _context;

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
    }
}
