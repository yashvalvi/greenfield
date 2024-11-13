using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification
{
    internal interface IJsonRepository<T>
    {
        bool Serialize(string filename, List <T> products);
        List <T> Deserialize(string filename);
    }
}
