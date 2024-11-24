using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultitaskAsyncApp
{
    internal class Program
    {

        static async Task<string> FetchDataAsync()
        {
            await Task.Delay(1000);
            return "Data Fetched successfully";
        }

        static async Task ProcessDataAsync()
        {
            try
            {
                string data = await FetchDataAsync();
                Console.WriteLine(data);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine("Error fetching data:" + ex.Message);
                }
            }

           
        }
        static async Task Main(string[] args)
        {

            await ProcessDataAsync();
        }

    }
}
