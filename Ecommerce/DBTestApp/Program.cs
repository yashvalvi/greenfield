using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.ComponentModel.Design;

namespace DBTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conString= @"data source=shc-sql-01.database.windows.net ; database=HangFireCatalog_VG; User Id=tmgreadonly; Password=#p7P>Wzs;";
            IDbConnection conn = new SqlConnection(conString);
             string query = "Select * from YV_Products;";
            IDbCommand cmd= new SqlCommand(query,conn as SqlConnection); 
            try
            {
                conn.Open();
                IDataReader dr = cmd.ExecuteReader();
                while(dr.Read()) {
                    string Name = dr["Name"].ToString();
                        string description = dr["Description"].ToString();

                        int quantity=int.Parse(dr["Quantity"].ToString());
                    Console.WriteLine(Name + " " + description + " " + quantity);

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);  
            }
            finally
            {
                conn.Close();
                Console.ReadLine();
            }
        }
    }
}
