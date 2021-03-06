﻿using Async_Inn.Data;
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
        private readonly AsyncInnDbContext _context;

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

        public async Task<Amenities> GetAmenity(int id)
        {
            var amenity = await _context.Amenities.FindAsync(id);
            if (amenity == null)
            {
                return null;
            }
            return amenity;
        }

        public async Task UpdateAmenities(int id, Amenities amenities)
        {
            if (amenities.ID == id)
            {
                _context.Amenities.Update(amenities);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAmenities(int id)
        {
            var amenities = _context.Amenities.Where(i => i.ID == id);
            if (amenities != null)
            {
                _context.Remove(amenities);
                await _context.SaveChangesAsync();
            }
        }        
    }
}
