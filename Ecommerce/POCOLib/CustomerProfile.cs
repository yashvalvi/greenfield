using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceEntities
{
   public class CustomerProfile
    {
        public Customer TheCustomer { get; set; }   
        public List<Order> OrderHistory { get; set; }
    }
}
