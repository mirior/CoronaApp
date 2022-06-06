using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Services
{
    public class LocationBusinessLogic: ILocationBusinessLogic
    {
        private ILocationDataAccess _locationDataAccess;
        public LocationBusinessLogic(ILocationDataAccess locationDataAccess)
        {
            _locationDataAccess = locationDataAccess;
        }
        public async Task<List<Location>> GetLocation()
        {
            return await _locationDataAccess.GetLocation();
        }
        public async Task<List<Location>> GetLocationByCity(string city)
        {
            return await _locationDataAccess.GetLocationByCity(city);
        }
        //public async Task<List<Location>> getLocationByPatiantId(string id)
        //{
        //    return await _locationDataAccess.getLocationByPatiantId(id);
        //}

        //public async Task postLocation(Location location)
        //{
        //    await _locationDataAccess.postLocation(location);
        //}
    }
}
