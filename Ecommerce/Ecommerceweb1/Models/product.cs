using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerceweb1.Models
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        
        public string ProductName { get; set; }
        public string Unitprice { get; set; }
        public string images { get; set;}

             
    }
}