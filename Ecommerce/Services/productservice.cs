using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCOLib;
using BinaryDataRepositoryLib;
using Specification;
using System.Security.Cryptography.X509Certificates;
using System.Dynamic;

namespace Services
{
    public class productservice : Iproductservice
    {
        //  private List<product> _productList = new List<product>();
        //  public productservice()
        //  {
        //      this._productList = new List<product>();
        //  }
        //  public bool delete(int id)
        //  {
        //      Customer theCustomer = this.Get(id);
        //      return this._customerList.Remove(theCustomer);
        //  }
        //  public Customer Get(int id)
        //  {
        //      foreach (Customer customer in _customerList)
        //      {
        //          if (customer.id == id)
        //              return customer;
        //      }
        //      return null;
        //  }
        //  public List<Customer> GetAll()
        //  {
        //      return _customerList;
        //  }
        //  public bool insert(Customer customer)
        //  {
        //      _customerList.Add(customer);
        //      return true;
        //  }
        //  public bool update(Customer customer)
        //  {
        //      _customerList.Remove(customer);
        //      -_customerList.Add
        //      return true;
        //
        //  }
        public productservice()
        {
            List<product> products=new List<product>();
            Seeding();
        }
        public bool Seeding()
        {
            bool status = false;
            List<product> products = new List<product>();
            //retreive all products from file
            products.Add(new product { Id = 1, Name = "gerbera", Description = "Wedding Flower", UnitPrice = 12, Quantity = 2000, images = "/Images/gerbera.jpg" });
            products.Add(new product { Id = 2, Name = "rose", Description = "Valentine Flower", UnitPrice = 23, Quantity = 9000, images = "/images/rose.jpg" });
            products.Add(new product { Id = 3, Name = "lily", Description = "Delicate Flower", UnitPrice = 2, Quantity = 7000, images = "/images/lily.jpg" });
            products.Add(new product { Id = 4, Name = "jasmine", Description = "Fregrance Flower", UnitPrice = 12, Quantity = 55000, images = "/images/jasmines.jpg" });
            products.Add(new product { Id = 5, Name = "lotus", Description = "Worship Flower", UnitPrice = 45, Quantity = 15000, images = "/images/lotus.jpg" });
            IDataRepository<product> repo = new BinaryRepository<product>();
            status = repo.Serialize(@"E:/products.dat", products);
            return status;

        }


        public product Get(int id)
        {
            product foundProduct = null;
            List<product> products = GetAll();
            foreach (product p in products)
            {
                if (p.Id == id)
                {
                    foundProduct = p;

                }

            }
                return foundProduct;
        }
        public List<product> GetAll()
        {
            List<product> products = new List<product>();
            IDataRepository<product> repo = new BinaryRepository<product>();
            products = repo.Deserialize(@"E:/products.dat");

            return products;
        }

        public bool Insert(product product)
        {
            List<product> allProducts = GetAll();
            allProducts.Add(product);
            IDataRepository<product> repo = new BinaryRepository<product>();
            repo.Serialize(@"E:/products.dat", allProducts);
            return false;

        }

        public bool Update(product productTobeUpdated)
        {
            product theproduct = Get(productTobeUpdated.Id);
            if (theproduct != null)
            {
                List<product> allProducts = GetAll();
                allProducts.Remove(theproduct);
                allProducts.Add(productTobeUpdated);
                IDataRepository<product> repo = new BinaryRepository<product>();
                repo.Serialize(@"E:/products.dat", allProducts);
            }
            return false;
        }



        public bool Delete(int id)
        {
            product theProduct = Get(id);
            if (theProduct != null)
            {
                List<product> allProducts = GetAll();
                allProducts.Remove(theProduct);
                IDataRepository<product> repo = new BinaryRepository<product>();
                repo.Serialize(@"E:/products.dat", allProducts);
            }
            return false;
        }
    }
   

    

}
