using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using POCOLib;
using Specification;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace BinaryDataRepositoryLib
    
{
    public class BinaryRepository:IDataRepository
    {
        public bool Serialize(string filename,List<product> products)
        {
            bool status = false;
            //code for saving
            BinaryFormatter formatter=new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
            formatter.Serialize(stream, products);  
            stream.Close();
            return status;
        }

        public List<product> Deserialize(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<product> products = new List<product>();
           
            FileStream stream = new FileStream(filename, FileMode.Open);
            if (stream != null)
            {
                products = (List<product>) formatter.Deserialize(stream);
            }
            stream.Close();
            //retreive all products from file
            return products;
        }

    }
}
