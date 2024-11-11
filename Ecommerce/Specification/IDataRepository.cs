using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCOLib
namespace Specification
{
    public interface IDataRepository
    {
        bool Serialize(string filename, List<product>products);
        List<product> Deserialize(string filename); 
    }
}
}
