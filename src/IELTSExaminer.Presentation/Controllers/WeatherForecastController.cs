using Microsoft.AspNetCore.Mvc;

namespace IELTSExaminer.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public static List<string> Names = new List<string>();


        [HttpPost]
        public void Create(string name)
        {
            Names.Add(name);            
        }

        [HttpPut]
        public void Update(string newName, string oldName)
        {
            var name = Names.Remove(oldName);
            Names.Add(newName);
        }

        [HttpDelete]
        public void Delete(string name)
        {
            Names.Remove(name);
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<string> Get()
        {
            return Names;
        }
    }
}
