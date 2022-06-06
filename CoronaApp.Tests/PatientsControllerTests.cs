using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using Xunit;
using System.Net.Http.Json;
//using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace CoronaApp.Tests
{
    //: IClassFixture<WebApplicationFactory<Program>>
    public class PatientControllerTests 
    {
        //private readonly WebApplicationFactory<Program> _factory;

        WebApplicationFactory<Program> application = new WebApplicationFactory<Program>();
        
        //public PatientControllerTests(WebApplicationFactory<Program> factory)
        //{
        //    _factory = factory;
        //}

        public async void GetPatient_ById_ReturnPatient()
        {
            // Arrange
            var client = application.CreateClient();

            // Act
            var response = await client.GetAsync("/api/Patients/000000018");

            //Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async void GetLocations_ByPatientId_ReturnLocations()
        {
            // Arrange
            var client = application.CreateClient();

            // Act
            var response = await client.GetAsync("/api/Patients/000000018");

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task PostLocation_Location_ReturnSuccessCode()
        {
            // Arrange
            var client = application.CreateClient();
            var myObj = new
            {
                city = "string",
                startDate = "2022-06-06T11:02:29.358Z",
                endDate = "2022-06-06T11:02:29.358Z",
                theLocation = "string",
                patient = new
                {
                    id = "string"
                }
            };
            JsonContent content = JsonContent.Create(myObj);
            // Act
            var response = await client.PostAsync("/api/Patients", content);

            // Assert
            response.EnsureSuccessStatusCode();
        }



    }
}

