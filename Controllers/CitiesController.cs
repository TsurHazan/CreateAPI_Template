using Microsoft.AspNetCore.Mvc;

namespace WebApiTemplate.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet("GetCitiesList")]
        public JsonResult GetAllCitiesList()
        {
            List<City> citiesList = new List<City>();
            citiesList.Add(new City() { Id = 1, Name = "Tel-Aviv" });
            citiesList.Add(new City() { Id = 2, Name = "Jerusalem" });
            citiesList.Add(new City() { Id = 3, Name = "Tiberias" });

            return new JsonResult(citiesList);
        }

        [HttpGet("GetSingleCity/{id}")]
        public JsonResult GetCityByID(int id)
        {
            List<City> citiesList = new List<City>();
            citiesList.Add(new City() { Id = 1, Name = "Tel-Aviv" });
            citiesList.Add(new City() { Id = 2, Name = "Jerusalem" });
            citiesList.Add(new City() { Id = 3, Name = "Tiberias" });

            return new JsonResult(citiesList.Find(c => c.Id == id));
        }

        [HttpPost("SaveCity")]
        public JsonResult SaveSingleCity(City city)//int id, string name
        {
            // return new JsonResult(new City() { Id = id, Name = name });
            return new JsonResult(city);
        }
    }
}