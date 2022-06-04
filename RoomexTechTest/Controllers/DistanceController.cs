using Microsoft.AspNetCore.Mvc;
using RoomexTechTestApi.Model;
using RoomexTechTestApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoomexTechTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistanceController : ControllerBase
    {
        [HttpGet("{latitude1}/{longitude1}/{latitude2}/{longitude2}/{unit}")]
        public string GetDistance(string form, double latitude1, double longitude1, double latitude2, double longitude2, string unit)
        {
            Point start = new(latitude1, longitude1);
            Point end = new(latitude2, longitude2);
            Body body = new(start, end, form, unit);

            return new DistanceCalculatorService().Process(body).ToString();
        }
    }
}
