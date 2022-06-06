using CoronaApp.Services;
using CoronaApp.Services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private IPatientBusinessLogic _patientBusinessLogic;
        private readonly ILogger _logger;

        public PatientsController(IPatientBusinessLogic patientBusinessLogic, ILogger<PatientsController> logger)
        {
            _patientBusinessLogic = patientBusinessLogic;
            _logger = logger;

        }
        //GET api/<LocationController>/5
        [HttpGet("{id}")]
        public async Task<List<Location>> GetLocationByPatiantId(string id)
        {
            return await _patientBusinessLogic.GetLocationByPatiantId(id);
        }
        // POST api/<LocationController>
        [HttpPost]
        public async Task PostLocation(Location location)
        {
            await _patientBusinessLogic.PostLocation(location);
        }

        //// GET: api/<PatientsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<PatientsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<PatientsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<PatientsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PatientsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
