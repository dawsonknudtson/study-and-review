using System; 
using System.Text.Json;

namespace SerializationDeserialization {
    public class WeatherForecast {
        // properties
        public DateTimeOffset Date {get;set;}
        public int TemperatureC {get;set;}
        public string? Summary {get;set;}
    }

    public class Program {
        public static void Main() {
            var weatherForecast = new WeatherForecast {
                Date = DateTime.Now,
                TemperatureC = 25,
                Summary = "Sunny"
            };
            string fileName = "weather.json";
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            File.WriteAllText(fileName,jsonString);
            
            Console.WriteLine(jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}

