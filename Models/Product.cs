using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class Product
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        [Required]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        [Required]
        public string Quantity { get; set; }

        public Product(string name,string quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
        public override string ToString() => $"{Name}={Quantity}";

    }
}
