using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specification;
using ECommerceEntities;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Security.Policy;
using System.Xml.Linq;

namespace EcommerceDALLib.Disconnected
{
    public static class DBManager
    {
      public static string constring= @"data source=shc-sql-01.database.windows.net ; database=HangFireCatalog_VG;User Id=tmgreadonly; Password=#p7P>Wzs; ";
       public static List<Product> GetAll() {
            List<Product> products = new List< Product > ();
            IDbConnection con = new SqlConnection(constring);
            string query = "Select * from YV_Products";
            IDbCommand cmd= new SqlCommand(query,con as SqlConnection);   
            DataSet dataset=new DataSet();
            IDataAdapter adapter = new SqlDataAdapter(cmd as SqlCommand);
            adapter.Fill(dataset);
            DataTable table= dataset.Tables[0];
            foreach (DataRow row in table.Rows)
            {
                int id = int.Parse(row["Id"].ToString());
                string name = row["Name"].ToString();
                string description = row["Description"].ToString();
                int Unitprice = int.Parse(row["UnitPrice"].ToString());
                int Quantity = int.Parse(row["Quantity"].ToString());
                string image = row["images"].ToString();
                Product product = new Product();
                product.Id = id;
                product.Name = name;
                product.Description = description;
                product.Quantity = Quantity;
                product.images = image;
                products.Add(product);
            }
            return products;    

        }
      public static  Product GetByID(int id)
        {
            List<Product> products = new List<Product>();
            products = GetAll();
            Product theProduct=products.Find((product) => (product.Id == id));
            return theProduct;
       }

    }
}
    
       