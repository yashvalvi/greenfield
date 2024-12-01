using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EcommerceDALLib.Disconnected;
using ECommerceEntities;
using static System.Net.Mime.MediaTypeNames;
namespace DisconnectedTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = DBManager.GetAll();

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name + " "
                  + p.Description + " "
                    + p.Quantity + " " +
                    p.images
               );

            }
            Product product = DBManager.GetByID(1);
            Console.WriteLine(product.Name + " "
                       + product.Description + " "
                    + product.Quantity + " " +
                    product.images);


        }
    }
}
