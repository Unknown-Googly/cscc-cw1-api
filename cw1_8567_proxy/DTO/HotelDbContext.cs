using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw1_8567_proxy.DTO
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Room> Room { get; set; }
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {

        }
    }
}
