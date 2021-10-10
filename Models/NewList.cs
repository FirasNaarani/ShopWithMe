using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class NewList
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "nameList")]
        [Required]
        public string NameList { get; set; }

        [JsonProperty(PropertyName = "products")]
        public List<Product> Products { get; set; }

    }
}
