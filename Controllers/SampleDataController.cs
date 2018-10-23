using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vuets.Model;

namespace vuets.Controllers
{
  [Route("api/[controller]")]
  public class SampleDataController : Controller
  {
    private static string[] Summaries = new[]
    {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

    private List<Hotel> hotelList = new List<Hotel>()
    { 
      new Hotel(){ Name = ":D" }
    };

    [HttpGet("[action]")]
    public IEnumerable<WeatherForecast> WeatherForecasts()
    {
      var rng = new Random();
      return Enumerable.Range(1, 5).Select(index => new WeatherForecast
      {
        DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
        TemperatureC = rng.Next(-20, 55),
        Summary = Summaries[rng.Next(Summaries.Length)]
      });
    }

    public class WeatherForecast
    {
      public string DateFormatted { get; set; }
      public int TemperatureC { get; set; }
      public string Summary { get; set; }

      public int TemperatureF
      {
        get
        {
          return 32 + (int)(TemperatureC / 0.5556);
        }
      }
    }

    [HttpPost]
    public ActionResult PostHotel(Hotel hotel)
    {
      if (hotel == null) return null;
      hotel.Guid = Guid.NewGuid();
      hotelList.Add(hotel);

      return Ok(hotel);
    }

    [HttpGet("[action]")]
    public ActionResult GetHotels()
    {
      return Ok(hotelList);
    }
  }
}
