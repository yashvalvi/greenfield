using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public string images { get; set; }
        public int Quantity { get; set; }


    }
}