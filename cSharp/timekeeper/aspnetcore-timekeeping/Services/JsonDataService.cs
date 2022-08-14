using aspnetcore_timekeeping.Models;
using System.Text.Json;

namespace aspnetcore_timekeeping.Services
{
    public class JsonDataService
    {
        public JsonDataService(IWebHostEnvironment webHostEnvironment) { WebHostEnvironment = webHostEnvironment; }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "data.json"); }
        }

        public IEnumerable<Data> GetInfo()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
#pragma warning disable CS8603 // Possible null reference return.
            return JsonSerializer.Deserialize<Data[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
