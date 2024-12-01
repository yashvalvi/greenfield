using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specification;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Security.Policy;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using ECommerceEntities;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EcommerceDALLib.DB.ORM
{
    public class ECommerceContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ECommerceContext() : base("name=conString")
        {
        }
    }
    public static class DBManager
    {
        public static string constring = @"data source=shc-sql-01.database.windows.net ; database=HangFireCatalog_VG;User Id=tmgreadonly; Password=#p7P>Wzs; ";

        public static List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            using (var context = new ECommerceContext())
            {
                var dbProducts = context.Products.ToList();
                foreach (var product in dbProducts)
                {
                    Product theProduct = new Product();
                    theProduct.Id = product.Id;
                    theProduct.Name = product.Name;
                    theProduct.Description = product.Description;
                    theProduct.UnitPrice = product.UnitPrice;
                    theProduct.images = product.images;
                    theProduct.Quantity = product.Quantity;
                    products.Add(product);
                }
            }
            return products;

        }
    }
}