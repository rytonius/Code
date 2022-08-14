using System.Text.Json;
using System.Text.Json.Serialization;

namespace aspnetcore_timekeeping.Models
{
    public class Data
    {
        [JsonPropertyName("id")]
        public string? ID { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        public int[]? Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Data>(this);

    }
}
