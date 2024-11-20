using ECommerceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification
{
    public  interface IShoppingCartService
    {
        List<Item> GetAll();
        bool AddtoCart();
       bool RemoveFromCart();
       bool Empty();
    }
}
