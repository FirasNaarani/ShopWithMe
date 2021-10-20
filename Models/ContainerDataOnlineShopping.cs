using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Models
{
    public class ContainerDataOnlineShopping
    {
        public Cart cart { get; set; }

        public NewList newList  { get; set; }

        public Proudct _proudct { get; set; }

        public string action { get; set; }

        public ContainerDataOnlineShopping()
        {
            this.cart = new();
            cart.Proudcts = new();
            this.newList = new();
            _proudct = new();
        }
    }
}
