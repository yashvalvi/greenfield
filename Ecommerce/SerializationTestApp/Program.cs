using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Services;
using POCOLib;
using Specification;


namespace SerializationTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            productservice svc = new productservice();
            svc.Seeding();
            List<product> allProducts = svc.GetAll();
            foreach(product p in allProducts)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
            
        }
    }
}
