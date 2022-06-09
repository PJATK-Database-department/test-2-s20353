using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_2.Models;

namespace Test_2.Services
{
    public class DatabaseService : IDatabaseService
    {
        private s20353Context _context;
        public DatabaseService(s20353Context context)
        {
            _context = context;
        }

        public async Task<bool> CityExistsAsync(string cityName)
        {
            var docs = await _context.CityDicts.ToListAsync();
            return docs.Any(t => t.City == cityName);
        }

        public async Task<CityDict> GetCityAsync(string cityName)
        {
            return await _context.CityDicts.FindAsync(cityName);
        }

        public async Task<List<Flight>> GetListofFlightssAsync()
        {
            return await _context.Flights.ToListAsync();
        }

        public async Task<List<Flight_Passenger>> GetFlight_PassengerAsync(int IdFlight)
        {
            var fli_pas = await _context.Flight_Passengers.ToListAsync();
            var result = fli_pas.FindAll(t => t.IdFlight == IdFlight);
            return result;
        }

        public async Task<List<Passenger>> GetPassengersAsync(Flight_Passenger fli_pas)
        {
            var allPassengers = await _context.Passengers.ToListAsync();
            var result = allPassengers.FindAll(t => t.IdPassenger == fli_pas.IdPassenger);
            return result;
        }

        public async Task<List<Passenger>> GetPassengersForCityAsync(CityDict city)
        {
            //var flights = 
            //return result;
            return null;
        }
    }
}
