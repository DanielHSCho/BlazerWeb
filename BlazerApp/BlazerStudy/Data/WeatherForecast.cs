using System;
using System.ComponentModel.DataAnnotations;

namespace BlazerStudy.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Need TemperatureC!")]
        [Range(typeof(int), "-100", "100")]
        public int TemperatureC { get; set; }

        [Required(ErrorMessage ="Need Summary!")]
        [StringLength(10, MinimumLength =2, ErrorMessage ="2-10")]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
