using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportIS.Data
{
    public class SubwayStation
    {
        [JsonProperty(PropertyName = "line")]
        public string Line { get; set; }
        [JsonProperty(PropertyName = "stations")]
        public List<string> Stations { get; set; }

    }
}
