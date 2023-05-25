using Microsoft.EntityFrameworkCore;
using RideManagement.Models;
using System.Data;

namespace RideManagement.Context
{
    public class RideDbContext : DbContext
    {
        public RideDbContext(DbContextOptions<RideDbContext> options) : base(options)
        {

        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Distance> Distances { get; set; }
        public DbSet<RideSchedule> RideSchedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Distance>().HasData(
                new Distance
                {
                    ID = 1,
                    From = "Kolkata",
                    To = "Chennai",
                    DistanceInKMS = 500
                },
                new Distance
                {
                    ID = 2,
                    From = "Delhi",
                    To = "Pune",
                    DistanceInKMS = 200
                },
                new Distance
                {
                    ID = 3,
                    From = "Kolkata",
                    To = "Bangalore",
                    DistanceInKMS = 300
                });
        }
    }
}
