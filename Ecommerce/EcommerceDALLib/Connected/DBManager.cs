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

namespace EcommerceDALLib.Connected
{
    public static class DBManager
    {
      public static string constring= @"data source=shc-sql-01.database.windows.net ; database=HangFireCatalog_VG;User Id=tmgreadonly; Password=#p7P>Wzs; ";
       public static bool Insert(Product product) {
            bool status = false;
            IDbConnection conn = new SqlConnection(constring);
            string query = "INSERT INTO YV_Products(Id, Name, Description, UnitPrice, Quantity, images)"
                               + "values(" + product.Id + ", '" + product.Name + "','" + product.Description + "','" + product.UnitPrice + "','" + product.Quantity + "','" + product.images + "')";
            IDbCommand cmd = new SqlCommand(query, conn as SqlConnection);
            try
            {
                conn.Open();
                cmd.ExecuteReader();
                status= true;   

                
            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return status;
     
        }
     public static  bool Update(Product product) {
            bool status = false;    
            IDbConnection conn = new SqlConnection(constring);
            string query = "UPDATE YV_Products SET " +
                   "Name = '" + product.Name + "', " +
                   "Description = '" + product.Description + "', " +
                   "Price = '" + product.UnitPrice + "', " +
                   "Quantity = '" + product.Quantity + "', " +
                   "Url = '" + product.images + "' " +
                   "WHERE Id = " + product.Id;
            IDbCommand cmd = new SqlCommand( query, conn as SqlConnection );
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                status= true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return status;


        }
      public static  void Delete(int id) {
            IDbConnection conn = new SqlConnection(constring);
            string query = "Delete from YV_Products where id =" + id;
            IDbCommand cmd=new SqlCommand(query,conn as SqlConnection);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
     public static   void GetCount() {
            IDbConnection conn = new SqlConnection(constring);
            string query = "Select count(*) from YV_Products;";
            IDbCommand cmd=new SqlCommand(query,conn as SqlConnection);

            try
            {

                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
       public static List<Product> GetAll() {
            List<Product> products = new List<Product>();
            IDbConnection conn= new SqlConnection(constring);
            string query = "Select * from YV_Products;";
            IDbCommand cmd=new SqlCommand(query, conn as SqlConnection);

            try
            {
                conn.Open();
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr["Name"].ToString();
                    string description = dr["Description"].ToString();
                    int quantity = int.Parse(dr["Quantity"].ToString());

                    Product product = new Product();
                    product.Name = name;
                    product.Description = description;
                    product.Quantity = quantity;
                    products.Add(product);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return products;

        }
      public static  Product GetByID(int id)
        {
            Product product = new Product();
            //    List<Product>products = new List<Product>();
            IDbConnection conn = new SqlConnection(constring);
            string query = "Select * from YV_Products where id ="+id;
            IDbCommand cmd = new SqlCommand(query, conn as SqlConnection);

            try
            {
                conn.Open();
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr["Name"].ToString();
                    string description = dr["Description"].ToString();
                    int quantity = int.Parse(dr["Quantity"].ToString());

                 
                    product.Id = id;
                    product.Name = name;
                    product.Description = description;
                    product.Quantity = quantity;
                    /*products.Add(product);*/

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);      
            }
            finally
            {
                conn.Close();
            }
            return product;


            }
    }
}
