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
    public interface IRoomsManager
    {
        Task Create(Rooms room);

        Task<List<Rooms>> GetRoomList();

        Task<Rooms> GetRoom(int id);

        Task UpdateRooms(int id, Rooms room);

        Task DeleteRooms(int id);

        Task<Rooms> GetRoomAmenities(int id);

    }
}
