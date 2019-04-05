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
        public Async_InnDbContext(DbContextOptions<Async_InnDbContext> options) : base(options)
        {

        }
    }
}
