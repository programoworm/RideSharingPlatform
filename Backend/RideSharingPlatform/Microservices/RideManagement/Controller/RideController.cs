using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideSharingPlatform.Context;
using RideSharingPlatform.Microservices.RideManagement.BLL;
using RideSharingPlatform.Microservices.RideManagement.DAL.Interfaces;
using RideSharingPlatform.Microservices.RideManagement.Models;
using RideSharingPlatform.Microservices.RideManagement.Models.DTOs;

namespace RideSharingPlatform.Microservices.RideManagement.Controller
{
    [Route("api/")]
    [ApiController]
    public class RideController : ControllerBase
    {
        private readonly RideService service;

        public RideController(IMapper mapper, IRideRepository rideRepository)
        {
            this.service = new RideService(mapper, rideRepository);
        }

        [HttpGet]
        [Route("distances")]
        public IActionResult GetDistances()
        {
            var r = service.GetDistances();
            return Ok(r);
        }

        [HttpGet]
        [Route("rides/calculatefare")]
        public IActionResult GetRideFare([FromQuery] FareDTO fareDTO)
        {
            var r = service.GetFare(fareDTO);
            return Ok(r);
        }

        [HttpPost]
        [Route("rides/schedule")]
         public IActionResult ScheduleRide([FromBody] RideDTO rideDTO)
        {
            var r = service.ScheduleRide(rideDTO);
            return Ok(r);
        }

        [HttpGet]
        [Route("rides/search")]
        public IActionResult SearchRides([FromQuery] SearchDTO searchDTO) { 
            var r = service.SearchRide(searchDTO);
            return Ok(r);
        }

        [HttpPost]
        [Route("rides/book")]
        public IActionResult BookRide([FromBody] BookingDTO bookingDTO)
        {
            var r = service.BookRide(bookingDTO);
            return Ok(r);
        }

        [HttpGet]
        [Route("GetRegNo/{userId}")]
        public IActionResult GetRegNo(int userId)
        {
            var r = service.GetRegNo(userId);
            return Ok(r);
        }
    }
}
