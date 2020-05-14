using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartCityDataAccess.DTOs
{
    public class DTOArtOrganization
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }


        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "rating")]
        public decimal? Rating { get; set; }


        [JsonProperty(PropertyName = "website")]
        public string Website { get; set; }


        [JsonProperty(PropertyName = "workHours")]
        public string WorkHours { get; set; }
    }
}
