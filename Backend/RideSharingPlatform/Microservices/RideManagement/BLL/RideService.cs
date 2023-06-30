using AutoMapper;
using RideSharingPlatform.Context;
using RideSharingPlatform.Microservices.RideManagement.DAL;
using RideSharingPlatform.Microservices.RideManagement.DAL.Interfaces;
using RideSharingPlatform.Microservices.RideManagement.Models;
using RideSharingPlatform.Microservices.RideManagement.Models.DTOs;

namespace RideSharingPlatform.Microservices.RideManagement.BLL
{
    public class RideService
    {
        private readonly IRideRepository rideRepository;
        private readonly IMapper mapper;

        public RideService(IMapper mapper, IRideRepository rideRepository)
        {
            this.rideRepository = rideRepository;
            this.mapper= mapper;
        }

        public List<Distance> GetDistances()
        {
            return rideRepository.GetDistances();
        }

        
        public IEnumerable<RideSchedule> SearchRide(SearchDTO ride)
        {
            return rideRepository.Search(ride);
        }

        public int BookRide(BookingDTO bookingDTO)
        {
            Booking booking = mapper.Map<Booking>(bookingDTO);
            return rideRepository.BookRide(booking);
        }

        public int GetFare(FareDTO fare)
        {
            return rideRepository.GetRideFare(fare);
        }

        public string GetRegNo(int userid)
        {
            return rideRepository.GetRegNo(userid);
        }

        public bool ScheduleRide(RideDTO rideDTO)
        {
            int r = rideRepository.SheduleRide(rideDTO);
            if (r > 0)
            {
                return true;
            }
            return false;

        }

    }
}
