using CoronaApp.Services;
using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Dal
{
    public class LocationDataAccess: ILocationDataAccess
    {
        ICoronaAppDB _db;

        public LocationDataAccess(ICoronaAppDB db)
        {
            _db = db;
        }
        public async Task<List<Location>> GetLocation()
        {
            return await _db.GetLocationsDB();
        }
        public async Task<List<Location>> GetLocationByCity(string city)
        {
            List<Location> locations=await _db.GetLocationsDB();   
            return locations.FindAll(l => l.City == city);
        }
        //public async Task<List<Location>> getLocationByPatiantId(string id)
        //{
        //    return _db.FindAll(l => l.Patient.Id == id);
        //}

        //public async Task postLocation(Location location)
        //{
        //    _db.Add(location);
        //}
    }
}
