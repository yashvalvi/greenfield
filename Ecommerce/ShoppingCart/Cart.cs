using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        public List<Item> Items { get; set; }
        Items.Add(new Item{Id=1,Name="Phone",Description="accessories"});
          

    }
}
