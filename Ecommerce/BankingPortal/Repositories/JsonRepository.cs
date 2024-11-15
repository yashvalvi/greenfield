using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.InteropServices;
using BankingPortal.Repositories;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankingPortal.Repositories { 

    public class JsonRepository<T> : IDataRepository<T>
    {
        public List<T> Deserialize(string filename)
        {
            List<T> users = new List<T>();
            string jsonData = File.ReadAllText(filename);
            users = JsonSerializer.Deserialize<List<T>>(jsonData);

            //retreive all products from file
            return users;

        }

        public bool Serialize(string filename, List<T> users)
        {
            bool status = false;
            //code for saving
           // FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
           string jsonString= JsonSerializer.Serialize<List<T>>(users, new JsonSerializerOptions { WriteIndented = true });
            
                //string jsonData = JsonSerializer.Serialize(filename);
                File.WriteAllText(filename, jsonString);
            
                //stream.Close()
            return true;

        }

    }

}

