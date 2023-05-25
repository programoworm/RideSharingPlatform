using Microsoft.AspNetCore.Mvc;
using RideManagement.DAL.Interface;
using RideManagement.Models;

namespace RideManagement.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApplicationController : Controller
    {
        private readonly IRideManageRepository rideManageRepository;

        public ApplicationController(IRideManageRepository rideManageRepository)
        {
            this.rideManageRepository = rideManageRepository;
        }
        [HttpGet]
        [Route("distances")]
        public IActionResult GetAllDistances()
        {
            var distances = rideManageRepository.GetAllDistances();
            return Ok(distances);
        }
    }
}
