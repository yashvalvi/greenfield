using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using Specification;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace JSONDataRepositoryLib
{
    public class JsonRepository<T>: IJsonRepository
    {
        public bool Serialize(string filename, List<T> items)
        {
            bool status = false;
            //code for saving
             = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
            JsonSerializer.Serialize(stream, items);
            stream.Close();
            return status;



        }

        public List<T> Deserialize(string filename) {
            BinaryFormatter formatter = new BinaryFormatter();
            List<T> items = new List<T>();

            FileStream stream = new FileStream(filename, FileMode.Open);
            if (stream != null)
            {
                items = (List<T>)JsonSerializer.Deserialize(stream);
            }
            stream.Close();
            //retreive all products from file
            return items;

        }
}
