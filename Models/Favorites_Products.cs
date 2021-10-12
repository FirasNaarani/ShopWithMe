using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class Favorites_Products
    {
        public List<string> Favorites { get; set; }
        public List<string> Products { get; set; }
        public List<string> Urls { get; set; }
        public string IdList { get; set; }

    }
}
