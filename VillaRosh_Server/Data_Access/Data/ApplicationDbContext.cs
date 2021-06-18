using System;
using DataAcesss.Data;
using Microsoft.EntityFrameworkCore;
namespace VillaRosh_Server.Data_Access
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<HotelRoom> HotelRooms { get; set; }

        public ApplicationDbContext()
        {
        }
    }
}
