using AutoMapper;
using Moq;
using NUnit.Framework;
using RideSharingPlatform.Microservices.RideManagement.BLL;
using RideSharingPlatform.Microservices.RideManagement.DAL.Interfaces;
using RideSharingPlatform.Microservices.RideManagement.Models;
using RideSharingPlatform.Microservices.UserVerification.BLL;
using RideSharingPlatform.Microservices.UserVerification.DAL.Interfaces;
using RideSharingPlatform.Microservices.UserVerification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingPlatform.Tests
{
    [TestFixture]
    internal class RideManagementTests
    {
        private Mock<IRideRepository> rideRepositoryMock;
        private IMapper mapper;
        private RideService service;
        
        [SetUp]
        public void Setup()
        {
            rideRepositoryMock = new Mock<IRideRepository>();
            service = new RideService(mapper, rideRepositoryMock.Object);
        }

        [Test]
        public void GetDistances_ShouldReturnListOfDistances()
        {
            var distances = new List<Distance>
            {
                new Distance
                {
                    ID = 2,
                    From = "Unitech",
                    To = "SaltLake",
                    DistanceInKMS = 5,
                },
                new Distance
                {
                    ID = 3,
                    From = "Chinar Park",
                    To = "Technopolis",
                    DistanceInKMS = 8,
                },
                new Distance
                {
                    ID = 1,
                    From = "Airport",
                    To = "Garia",
                    DistanceInKMS = 25,
                },
                new Distance
                {
                    ID = 10,
                    From = "Unitech",
                    To = "Calcutta University",
                    DistanceInKMS = 5,
                },
                new Distance
                {
                    ID = 3,
                    From = "Chinar Park",
                    To = "TCS GP",
                    DistanceInKMS = 3,
                },
                new Distance
                {
                    ID = 4,
                    From = "Airport",
                    To = "TCS GP",
                    DistanceInKMS = 9,
                }
            };
            rideRepositoryMock.Setup(x => x.GetDistances()).Returns(distances);

            var result = service.GetDistances();

            Assert.That(result, Is.EqualTo(distances));
        }
    }
}
