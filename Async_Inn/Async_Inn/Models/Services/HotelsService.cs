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
        private AsyncInnDbContext _context;

        public HotelsService(AsyncInnDbContext context)
        {
            _context = context;
        }
        public async Task Create(Hotels hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }
    }
}
