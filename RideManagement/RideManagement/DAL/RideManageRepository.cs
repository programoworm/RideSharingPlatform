using RideManagement.Context;
using RideManagement.DAL.Interface;
using RideManagement.Models;

namespace RideManagement.DAL
{
    public class RideManageRepository : IRideManageRepository
    {
        private readonly RideDbContext rideDbContext;

        public RideManageRepository(RideDbContext rideDbContext)
        {
            this.rideDbContext = rideDbContext;
        }
        public IEnumerable<Distance> GetAllDistances()
        {
            return rideDbContext.Distances.ToList();
        }
    }
}
