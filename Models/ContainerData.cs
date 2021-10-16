using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class ContainerData
    {
        public List<Item> Favorites { get; set; }
        public NewList newList { get; set; }
        public Proudct _product { get; set; }
        public string Page_type { get; set; }


        public ContainerData()
        {
            this.Favorites = new();
            this.newList = new();
            this.newList.Proudcts = new();
            this._product = new();
        }


        public ContainerData(string page_type)
        {
            this.Favorites = new();
            this.newList = new();
            this.newList.Proudcts = new();
            this._product = new();
            this.Page_type = page_type;
        }
    }
}
