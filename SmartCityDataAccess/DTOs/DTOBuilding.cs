using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartCityDataAccess.DTOs
{
    public class DTOBuilding
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }


        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }


        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }


        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }


        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }


        [JsonProperty(PropertyName = "house")]
        public string House { get; set; }


        [JsonProperty(PropertyName = "cinemas")]
        public List<DTOArtOrganization> Cinemas { get; set; }


        [JsonProperty(PropertyName = "restaurants")]
        public List<DTORestaurant> Restaurants { get; set; }
    }
}
