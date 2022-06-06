using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Services
{
    public interface ILocationDataAccess
    {
        public Task<List<Location>> GetLocation();
        public Task<List<Location>> GetLocationByCity(string city);
        //public Task<List<Location>> getLocationByPatiantId(string id);
        //public Task postLocation(Location location);
    }
}
