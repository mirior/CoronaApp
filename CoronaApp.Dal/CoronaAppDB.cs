using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Dal
{

    public class CoronaAppDB: ICoronaAppDB
    {

        List<Location> locations = new List<Location>();

        public async Task<List<Location>> GetLocationsDB()
        {
            return locations;
        }

        public async Task AddItemToLocationsDB(Location location)
        {
            locations.Add(location);
        }

       
    }
}
