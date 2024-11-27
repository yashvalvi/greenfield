using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ECommerceEntities;
using Services;
using Specification;

namespace AuthWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
 

            //crud operation

            // GET api/values
            public IEnumerable<Product> Get()
            {
                IProductService svc = new ProductService();
                List<Product> products = svc.GetAll();
                return products;
            }

            // GET api/values/5
            public Product Get(int id)
            {
            IProductService svc = new ProductService();
            Product product = svc.Get(id);
                return product;
            }

            // POST api/values
            public void Post([FromBody] Product product)
            {
            IProductService svc = new ProductService();
            svc.Insert(product);
            }

            // PUT api/values/5
            public void Put(int id, [FromBody] Product product)
            {
            IProductService svc = new ProductService();
            svc.Update(product);
            }

            // DELETE api/values/5
            public void Delete(int id)
            {
                IProductService svc = new ProductService();
                svc.Delete(id);

     

            }


        }
    }

