using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using Specification;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace JSONDataRepositoryLib
{
    public class JsonRepository<T> : IDataRepository<T>
    {
        public List<T> Deserialize(string filename)
        {
            List<T> users = new List<T>();
            string jsonData = File.ReadAllText(filename);
            users = JsonConvert.DeserializeObject<List<T>>(jsonData);

            //retreive all products from file
            return users;

        }

        public bool Serialize(string filename, List<T> users)
        {
            bool status = false;
            //code for saving
            string jsonData = JsonConvert.SerializeObject(users);
            File.WriteAllText(filename, jsonData);
            return true;

        }

    }

}
