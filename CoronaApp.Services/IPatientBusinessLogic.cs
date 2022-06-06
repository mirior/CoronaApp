using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Services
{
    public interface IPatientBusinessLogic
    {
        public Task<List<Location>> GetLocationByPatiantId(string id);
        public Task PostLocation(Location location);
    }
}
