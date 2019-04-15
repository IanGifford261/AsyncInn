using Async_Inn.Data;
using Async_Inn.Interfaces;
using Async_Inn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Interfaces
{
    public interface IHotelsManager
    {
        Task Create(Hotels hotel);

        Task<List<Hotels>> GetHotelList();

        Task<Hotels> GetHotel(int id);

        Task<List<Rooms>> GetRoomsList();

        Task<Rooms> GetRoom(int id);

        Task UpdateHotels(int id, Hotels hotel);

        Task DeleteHotels(int id);

        bool HotelsExists(int id);
    }
}
