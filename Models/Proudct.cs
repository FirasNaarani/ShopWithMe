using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class Proudct
    {
        [JsonProperty(PropertyName = "name")]
        [Required]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        [Required]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "price")]
        [Required]
        public double Price { get; set; }

        [JsonProperty(PropertyName = "url")]
        [Required]
        public string Url { get; set; }

        public Proudct()
        {

        }
        public Proudct(string name,int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }

    }
}
