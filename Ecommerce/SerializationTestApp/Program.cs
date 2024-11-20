using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Services;
using ECommerceEntities;
using Specification;


namespace SerializationTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService svc = new ProductService();
            svc.Seeding();
            List<Product> allProducts = svc.GetAll();
            foreach(Product p in allProducts)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
            
        }
    }
}
