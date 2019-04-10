using Async_Inn.Data;
using Async_Inn.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Services
{
    public class AmenitiesService : IAmenitiesManager
    {
        private AsyncInnDbContext _context;

        public AmenitiesService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task Create(Amenities amenities)
        {
            _context.Amenities.Add(amenities);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Amenities>> GetAmenitiesList()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task<Amenities> GetAmenities(int id)
        {
            var amenities = await _context.Amenities.FindAsync(id);
            if (amenities == null)
            {
                return null;
            }
            return amenities;
        }

        public void UpdateAmenities(int id, Amenities amenities)
        {
            if (amenities.ID == id)
            {
                _context.Amenities.Update(amenities);
                _context.SaveChanges();
            }
        }
    }
}
