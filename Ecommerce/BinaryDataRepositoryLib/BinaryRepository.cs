using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ECommerceEntities;
using Specification;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace BinaryDataRepositoryLib

{
    public class BinaryRepository<T> : IDataRepository<T>
    {
        public bool Serialize(string filename, List<T> products)
        {
            bool status = false;
            //code for saving
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
            formatter.Serialize(stream, products);
            stream.Close();
            return status;
        }

        public List<T> Deserialize(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<T> products = new List<T>();

            FileStream stream = new FileStream(filename, FileMode.Open);
            if (stream != null)
            {
                products = (List<T>)formatter.Deserialize(stream);
            }
            stream.Close();
            //retreive all products from file
            return products;
        }


    }
}
