using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DriveRecorderConverter
{
    class Entry
    {
        public int id {  get; set; }
        public string? date { get; set; }
        public string? time { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }

        [JsonPropertyName("velocity_KM/H")]
        public double velocity_kmh { get; set; }

        [JsonPropertyName("velocity_MP/H")]
        public string? velocity_mph { get; set; }
    }

    class Metadata
    {
        public string? VIN { get; set; }
        public Entry[]? entries { get; set; }
    }
}
