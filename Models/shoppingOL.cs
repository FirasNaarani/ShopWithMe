using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class shoppingOL
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "cart")]
        public Cart Cart { get; set; }

        [JsonProperty(PropertyName = "newlist")]
        public NewList NewList { get; set; }
        
        public string action { get; set; }

        public Proudct _proudct { get; set; }

        [JsonProperty(PropertyName = "cartUrl")]
        public string CartUrl { get; set; }

        public shoppingOL()
        {
            this.Cart = new();
            Cart.Proudcts = new();
            this.NewList = new();
            _proudct = new();
        }

    }
}
