using System.Data.SqlClient;
using System;
using Domain;

namespace StoreApplication
{
    public class Product
    {
        private readonly SqlConnection connection = new SqlConnection("Data source =DESKTOP-DN2IV14\\SQLEXPRESS01;initial Catalog=NewStoreLocations; integrated security =true");
        SqlConnection db = new SqlConnection();

        public int ProductId { get; internal set; }
        public string ProductName { get; internal set; }
        public string ProductDescription { get; internal set; }
        public double ProductPrice { get; internal set; }
        //Method to pull the list of products 
        public void productList()
        {
            Customer customer = new Customer();
            string query1 = "SELECT * FROM Products;";
            connection.Open(); 
            SqlCommand cmdCommand = new SqlCommand(query1, connection);
            SqlDataReader dr = cmdCommand.ExecuteReader();
            Console.WriteLine("Please select from the following items to add to cart");
            Console.WriteLine("-----------------------------------------------------");
            while (dr.Read())
            {
                
                Console.WriteLine(dr[0].ToString() + ": " + dr[1].ToString() + ": " + dr[2].ToString() + ": " + dr[3].ToString());
            }
            
            
            customer.customerCart();
        }
    }
}
