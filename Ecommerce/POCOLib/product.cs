using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceEntities
{
    [Table("YV_Products")]
    
       
    // [Serializable]
    public class Product
    {
        //  public int id { get; set; }
        //  public string title { get; set; }
        //  public string description { get; set; }
        //  // public string unitprice { get; set; }
        //  //  public string imageUrl { get; set; }
        //  public int Id { get; set; }
        //  public string Name { get; set; }
        //  public string Description { get; set; }
        //  // public int ProductId { get; set; }
        //
        //  //  public int UnitPrice { get; set; }
        //  public string images { get; set; }
        //  public int Quantity { get; set; }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       public int ProductId { get; set; }

        //public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string images { get; set; }
        public int Quantity { get; set; }

    }
}
