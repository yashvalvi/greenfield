using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCOLib;
namespace Specification
{
    public interface Iproductservice
    {
        List<product> GetAll();
        product Get(int id);
        bool Insert(product product);
        bool Update(product product);
        bool Delete(int id);
    }
}
