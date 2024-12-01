using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceDALLib;
using Specification;
using ECommerceEntities;

namespace Services.DBServices
{
    
        public class ProductService : IProductService
        {
          

            public Product Get(int id)
            {
              return DBManager.GetByID(id);
            }
            public List<Product> GetAll()
            {
                 return  DBManager.GetAll();   
            }

            public bool Insert(Product product)
            {
              return DBManager.Insert(product);

            }

            public bool Update(Product product)
            {
            Product theProduct = Get(product.Id);


            if (theProduct != null)
            {

                return DBManager.Update(product);
            }

            return false;
        }



            public void Delete(int id)
            {
            DBManager.Delete(id);
            
        }

  
    }

}

