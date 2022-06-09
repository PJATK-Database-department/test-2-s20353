using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Test_2.Services;

namespace Test_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IDatabaseService _databaseService;

        public FlightsController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }


        [HttpGet()]
        public async Task<IActionResult> GetFlights([FromQuery(Name = "cityname")] string? cityName)
        {
            if (cityName == null)
            {
                return StatusCode(404, "City not specified");
            }

            return StatusCode(404, "Flights not found");
        }
    }
}
