using CoronaApp.Controllers;
using CoronaApp.Services;
using CoronaApp.Services.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Tests
{
    public class LocationsControllerTests
    {
        WebApplicationFactory<Program> application = new WebApplicationFactory<Program>();

        [Fact]
        public async void GetLocations_ByCityUsingMock_ReturnLocations()
        {
            // Arrange
            string city = "Jerusalem";
            List<Location> locations = new List<Location> {
                new Location{
                City = city,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                TheLocation = "center",
                Patient = new Patient{
                    Id = "325191450"
                    }
                },
        };
            var mock = new Mock<ILocationBusinessLogic>();
            mock.Setup(x => x.GetLocationByCity(city))
                .Returns(Task.FromResult(locations));
            //var client = application.CreateClient();

            var controller = new LocationsController(mock.Object);

            // Act
            var result =controller.GetLocationByCity(city).Result;
          

            //Assert
            Assert.Same(result, locations);
        }

        [Fact]
        public async void GetLocations_ByCity_ReturnLocations()
        {
            // Arrange
            var client = application.CreateClient();

            // Act
            var response = await client.GetAsync("/api/Locations/GetByCity?city=Jerusalem");


            //Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async void GetAllLocations_Any_ReturnLocations()
        {
            // Arrange
            var client = application.CreateClient();

            // Act
            var response = await client.GetAsync("/api/Locations");

            //Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
