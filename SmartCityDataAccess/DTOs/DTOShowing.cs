using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartCityDataAccess.DTOs
{
    public class DTOShowing
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }


        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }


        [JsonProperty(PropertyName = "releaseDate")]
        public Nullable<DateTime> ReleaseDate { get; set; }


        [JsonProperty(PropertyName = "endDate")]
        public Nullable<DateTime> EndDate { get; set; }
    }
}
