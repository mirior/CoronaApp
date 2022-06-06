using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Services
{
    public class PatientBusinessLogic: IPatientBusinessLogic
    {
        private IPatientDataAccess _patientDataAccess;

        public PatientBusinessLogic(IPatientDataAccess patientDataAccess)
        {
            _patientDataAccess = patientDataAccess;
        }

        public async Task<List<Location>> GetLocationByPatiantId(string id)
        {
            return await _patientDataAccess.GetLocationByPatiantId(id);
        }

        public async Task PostLocation(Location location)
        {
            await _patientDataAccess.PostLocation(location);
        }
    }
}
