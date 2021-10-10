using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class Item
    {

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "name")]
        [Required]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        [Required]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "price")]
        [Required]
        public int Price { get; set; }

        [JsonProperty(PropertyName = "url")]
        [Required]
        public string Url { get; set; }

    }
}
