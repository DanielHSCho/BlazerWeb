using System;
using System.ComponentModel.DataAnnotations;

namespace BlazerStudy.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Need TemperatureC!")]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
