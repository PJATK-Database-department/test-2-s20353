using System.Collections.Generic;
using System.Threading.Tasks;
using Test_2.Models;

namespace Test_2.Services
{
    public interface IDatabaseService
    {
        Task<bool> CityExistsAsync(string cityName);
        Task<CityDict> GetCityAsync(string cityName);
        Task<List<Flight>> GetListofFlightssAsync();
        Task<List<Flight_Passenger>> GetFlight_PassengerAsync(int IdFlight);
        Task<List<Passenger>> GetPassengersAsync(Flight_Passenger fli_pas);
        Task<List<Passenger>> GetPassengersForCityAsync(CityDict city);
        Task<List<Flight>> GetListofFlightsToCitysAsync(CityDict city);

    }
}
