using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class Cart
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "nameCart")]
        [Required]
        public string NameCart { get; set; }

        [JsonProperty(PropertyName = "total")]
        [Required]
        public double Total { get; set; }

        [JsonProperty(PropertyName = "products")]
        public List<Proudct> Proudcts { get; set; }

        [JsonProperty(PropertyName = "dateTime")]
        public DateTime Date_Time { get; set; }
    }
}
