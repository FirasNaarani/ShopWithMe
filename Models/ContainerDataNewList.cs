using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class ContainerDataNewList
    {
        public List<Item> Favorites { get; set; }
        public NewList newList { get; set; }
        public Proudct _proudct { get; set; }
        public string Page_type { get; set; }


        public ContainerDataNewList()
        {
            this.Favorites = new();
            this.newList = new();
            this.newList.Proudcts = new();
            this._proudct = new();
        }


        public ContainerDataNewList(string page_type)
        {
            this.Favorites = new();
            this.newList = new();
            this.newList.Proudcts = new();
            this._proudct = new();
            this.Page_type = page_type;
        }
    }
}
