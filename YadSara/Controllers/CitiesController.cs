using Microsoft.AspNetCore.Mvc;
using YadSara.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YadSara.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private static new List<City> cities = new List<City>
        {
            new City(1,"Bney Brak"),
            new City(1, "Jerusalem")
        };

        // GET: api/<CityController>
        [HttpGet]
        public List<City> Get()
        {
            return cities;
        }

        // POST api/<CityController>
        [HttpPost]
        public City Post([FromBody] City c)
        {
            cities.Add(c);
            return c;
        }

    }
}
}
