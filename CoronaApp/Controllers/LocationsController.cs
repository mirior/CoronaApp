using CoronaApp.Services;
using CoronaApp.Services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private ILocationBusinessLogic _locationBusinessLogic;

        public LocationsController(ILocationBusinessLogic locationBusinessLogic)
        {
            _locationBusinessLogic = locationBusinessLogic;
        }
        // GET: api/<LocationController>
        [HttpGet]
        public async Task<List<Location>> GetLocation()
        {
            //throw new NotImplementedException("error in location controller");
            return await _locationBusinessLogic.GetLocation();

        }

        // GET api/<LocationController>/getByCity
        [HttpGet("GetByCity")]
        public async Task<List<Location>> GetLocationByCity([FromQuery] string city)
        {
            return await _locationBusinessLogic.GetLocationByCity(city);
        }
        

        
    }
}
