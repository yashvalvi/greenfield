using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceEntities;
using JsonDataRepositoryLib;
using Specification;
using System.Security.Cryptography.X509Certificates;
using System.Dynamic;
 
 

namespace Services
{
    public class ProductService : IProductService
    {
        string userfile = @"E:/products.json";

        //  }
       /* public ProductService()
        {
            List<Product> products=new List<Product>();
            Seeding();
        }*/
        public bool Seeding()
        {
            bool status = false;
            List<Product> products = new List<Product>();
            //retreive all products from file
            products.Add(new Product { Id = 1, Name = "gerbera", Description = "Wedding Flower", UnitPrice = 12, Quantity = 2000, images = "/Images/gerbera.jpg" });
            products.Add(new Product { Id = 2, Name = "rose", Description = "Valentine Flower", UnitPrice = 23, Quantity = 9000, images = "/images/rose.jpg" });
            products.Add(new Product { Id = 3, Name = "lily", Description = "Delicate Flower", UnitPrice = 2, Quantity = 7000, images = "/images/lily.jpg" });
            products.Add(new Product { Id = 4, Name = "jasmine", Description = "Fregrance Flower", UnitPrice = 12, Quantity = 55000, images = "/images/jasmines.jpg" });
            products.Add(new Product { Id = 5, Name = "lotus", Description = "Worship Flower", UnitPrice = 45, Quantity = 15000, images = "/images/lotus.jpg" });
            //  IDataRepository<product> repo = new BinaryRepository<product>();
            IDataRepository<Product> repo = new JsonRepository<Product>();
            status = repo.Serialize(userfile, products);
            return status;

        }


        public Product Get(int id)
        {
            Product foundProduct = null;
            List<Product> products = GetAll();
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    foundProduct = p;

                }

            }
                return foundProduct;
        }
        public  List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            //   IDataRepository<product> repo = new BinaryRepository<product>();
            IDataRepository<Product> repo = new JsonRepository<Product>();
              products = repo.Deserialize(userfile);

            return products;
        }

        public bool Insert(Product product)
        {
            List<Product> allProducts = GetAll();
            allProducts.Add(product);
            // IDataRepository<product> repo = new BinaryRepository<product>();
            IDataRepository<Product> repo = new JsonRepository<Product>();
            repo.Serialize(userfile, allProducts);
            return false;

        }

        public bool Update(Product productTobeUpdated)
        {
            Product theproduct = Get(productTobeUpdated.Id);
            if (theproduct != null)
            {
                List<Product> allProducts = GetAll();
                allProducts.Remove(theproduct);
                allProducts.Add(productTobeUpdated);
                //  IDataRepository<product> repo = new BinaryRepository<product>();
                IDataRepository<Product> repo = new JsonRepository<Product>();
                repo.Serialize(userfile, allProducts);
            }
            return false;
        }



        public bool Delete(int id)
        {
            Product theProduct = Get(id);
            if (theProduct != null)
            {
                List<Product> allProducts = GetAll();
                allProducts.Remove(theProduct);
                //  IDataRepository<product> repo = new BinaryRepository<product>();
                IDataRepository<Product> repo = new JsonRepository<Product>();
                repo.Serialize(userfile, allProducts);
            }
            return false;
        }
    }
}
