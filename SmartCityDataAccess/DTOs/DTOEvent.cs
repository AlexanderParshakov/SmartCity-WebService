using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartCityDataAccess.DTOs
{
    public class DTOEvent
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }


        [JsonProperty(PropertyName = "title")]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }


        [JsonProperty(PropertyName = "rating")]
        public Nullable<decimal> Rating { get; set; }


        [JsonProperty(PropertyName = "boxOffice")]
        public Nullable<decimal> BoxOffice { get; set; }


        [JsonProperty(PropertyName = "pictureData")]
        public byte[] Picture { get; set; }


        [JsonProperty(PropertyName = "website")]
        public string Website { get; set; }


        [JsonProperty(PropertyName = "showings")]
        public List<DTOShowing> Showings { get; set; }
    }
}
