using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceEntities;
using Specification;

namespace Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        public List<Item> GetAll() {  return new List<Item>(); }
        public bool  AddtoCart() { return false; }
        public bool RemoveFromCart() {  return false; }
        public bool Empty() {  return false; }

        
    }
}
 
