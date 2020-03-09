using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using System.Data.SqlClient;


namespace BlazorServerInventoryCSSAreasADOnet.Data
    {
    public class InventoryDataAccessLayer
        {

        string connectionString = "Data Source=EDS-DEV-PC;Initial Catalog = CustomerDB;Integrated Security=True;";
        public void  AddProduct(Inventory inventory)
            {
            using (SqlConnection con = new SqlConnection(connectionString))
                {
                SqlCommand cmd= new SqlCommand
                  {
                    CommandType = CommandType.Text
                  };

                cmd.Connection = con;
                               
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO dbo.Inventory (ProductNumber, Description) VALUES (@ProductNumber, @Description)");
                
                cmd.CommandText = sb.ToString();
                               
                cmd.Parameters.AddWithValue("@ProductNumber", inventory.ProductNumber);
                cmd.Parameters.AddWithValue("@Description", inventory.Description);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                               
                }    
            }

        }
    }            
               
   