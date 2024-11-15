using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using POCOLib;
using Services;
using Specification;

namespace AuthWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
 

            //crud operation

            // GET api/values
            public IEnumerable<product> Get()
            {
                Iproductservice svc = new productservice();
                List<product> products = svc.GetAll();
                return products;
            }

            // GET api/values/5
            public product Get(int id)
            {
                Iproductservice svc = new productservice();
                product product = svc.Get(id);
                return product;
            }

            // POST api/values
            public void Post([FromBody] product product)
            {
                Iproductservice svc = new productservice();
                svc.Insert(product);
            }

            // PUT api/values/5
            public void Put(int id, [FromBody] product product)
            {
                Iproductservice svc = new productservice();
                svc.Update(product);
            }

            // DELETE api/values/5
            public void Delete(int id)
            {
                Iproductservice svc = new productservice();
                svc.Delete(id);
     

            }

        }
    }

