using RideManagement.Models;

namespace RideManagement.DAL.Interface
{
    public interface IRideManageRepository
    {
        IEnumerable<Distance>GetAllDistances();
    }
}
