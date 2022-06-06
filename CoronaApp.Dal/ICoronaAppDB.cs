using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Dal
{
    public interface ICoronaAppDB
    {
        public Task<List<Location>> GetLocationsDB();
        public Task AddItemToLocationsDB(Location location);
    }
}
