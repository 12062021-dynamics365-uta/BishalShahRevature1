using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StoreApplication
{
    public class Customer
    {
        private readonly SqlConnection connection = new SqlConnection("Data source =DESKTOP-DN2IV14\\SQLEXPRESS01;initial Catalog=NewStoreLocations; integrated security =true");

        string query;
        SqlConnection db = new SqlConnection();
        StoreLogic storelogic = new StoreLogic();


        public string fname;
        public string lname;
        public string username;
        public string customerPassword;
        

        public int customerId { get;  set; }
        public string firstName { get;  set; }
        public string lastName { get;  set; }
        public string password { get;  set; }

        //method to login and validate customerRegister with SqlDatabase 
        public int CustomerLogin(string username, string password)
        {
            int foundCustomerId;
            query = $"SELECT * FROM Customer WHERE userName = '{username}' AND customerPassword = '{password}'";
            
            connection.Open();
            SqlCommand cmdCommand = new SqlCommand(query, connection);
            SqlDataReader dr = cmdCommand.ExecuteReader();
            dr.Read();
            try
            {
                foundCustomerId = Int32.Parse(dr[0].ToString());
                Console.WriteLine("Welcome " + foundCustomerId + " to the online shopping mall");
                
                storelogic.storeMainMenu();
            }
            catch (InvalidOperationException) //if nothing return 0
            {
                foundCustomerId = 0;
            }
            connection.Close();

            return foundCustomerId;


        }

        //method to register and update sqlDatabase
        public void registerCustomer(string firstName, string lastName, string userName, string password)
        {

            query = $"INSERT INTO Customer (firstName, lastName, userName, customerPassword) VALUES ('{firstName}', '{lastName}', '{userName}','{password}')";
            connection.Open();
            SqlCommand cmdCommand = new SqlCommand(query, connection);
            cmdCommand.ExecuteNonQuery();
            connection.Close();

        }
        //invoked methods within this method are not working/established
        public void customerCart()
        {

            List<Product> Cart = new List<Product>();
            string customerInput;
            int userInputConverted;
            bool userInput = false;
            customerInput = Console.ReadLine();
            userInputConverted = Convert.ToInt32(customerInput);
            string queryString = $"SELECT * FROM Products WHERE ProductID = {customerInput}";
            connection.Open();
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Selected:");
                Console.WriteLine(dr[0].ToString() + ": " + dr[1].ToString() + ": " + dr[2].ToString() + ": " + dr[3].ToString());
                
            }
            StoreLogic storeLogic = new StoreLogic();
            Console.WriteLine("Press 1 to add more items to cart,  press 2 to checkout, or press 3 to go back to list of store");
            customerInput = Console.ReadLine();
            userInputConverted = Convert.ToInt32(customerInput);
            switch (userInputConverted)
            {
                case 1:
                    addToCart();
                    break;
                case 2:
                    customerCheckout();
                    break;
                case 3:
                    storeLogic.storeLocations();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }



        }
        //stuck on JOIN query
        public void addToCart()
        {
            string queryString = "";
            connection.Open();
            SqlCommand cmd = new SqlCommand(queryString, connection);
            SqlDataReader dr = cmd.ExecuteReader();

           /* do
            {
                if (userInputConverted != 1 && userInputConverted != 2 && userInputConverted != 3 && userInputConverted != 4 && userInputConverted != 6)
                {
                    Console.WriteLine("Please select from the following products to add to the cart");
                }
            } while (!userInput || (userInputConverted != 1 && userInputConverted != 2 && userInputConverted != 3 && userInputConverted != 4 && userInputConverted != 6));

            switch (userInputConverted)
            {
                case 1:
                    Console.WriteLine("Added product 1 to the shopping cart");
                    // call a method to add product to cart
                    break;
                //write a method to add product 1 to shopping cart

                case 2:
                    Console.WriteLine("Added product 2 to the shopping cart");
                    break;
                //write a method to add product 2 to shopping cart

                case 3:
                    Console.WriteLine("Added product 3 to the shopping cart");
                    break;
                //write a method to add product 3 to shopping cart
                case 4:
                    Console.WriteLine("Added product 4 to the shopping cart");
                    break;
                //write a method to add product 4 to shopping cart
                case 6:
                    Console.WriteLine("Added product 5 to the shopping cart");
                    break;
                //write a method to add product 5 to shopping cart

                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }*/
        }
        public void removeFromCart()
        {

        }
        //customerPastPurchase method not complete
        public void customerPastPurchase()
        {
            int CustomerId;
            Console.WriteLine("Please input your CustomerId that you were greeted with during login");
            string userID = Console.ReadLine();
            Int32.TryParse(userID, out CustomerId);

            string query = @"SELECT customerOrder.orderID, customerOrder.CustomerId, customerOrder.ProductID, customerOrder.TotalProductPrice
                            FROM customerOrder
                            INNER JOIN Customer on customerOrder.CustomerId = Customer.CustomerId;
                            INNER JOIN Products on customerOrder.ProductID = Product.ProductID AND customerOrder.TotalProductPrice = Product.TotalProductPrice
							WHERE CustomerID = " + CustomerId;   
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(@"OrderID: " + dr[0].ToString() + " \t CustomerID: " + dr[1].ToString() + "\tProductID: " + dr[2].ToString() +
                    "\tTotalProductPrice: " + dr[3].ToString());
            }

            if (!dr.Read())
            {
                Console.WriteLine("Customer has not made any past purchases.");
            }
            connection.Close();
        }
        public void customerCheckout()
        { }


    }
}
