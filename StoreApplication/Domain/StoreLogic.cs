using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Storage;
using StoreApplication;
using Domain;

namespace Domain
{
    public class StoreLogic
    {
        private readonly SqlConnection connection = new SqlConnection("Data source =DESKTOP-DN2IV14\\SQLEXPRESS01;initial Catalog=NewStoreLocations; integrated security =true");

        string query1;
        SqlConnection db = new SqlConnection();
        
        //storemainmenu method takes in user input and evaluates to call storelocation method or customerPastpurchase
        public void storeMainMenu()
        {
            Customer customers = new Customer();
            string customerInput;
            bool customerMainmenuInput = false;
            int customerInputConvertedNumber = 0;

            do
            {
                Console.WriteLine("Please press 1 to view store locations, press 2 to view past order by customerID");
                customerInput = Console.ReadLine();
                customerMainmenuInput = Int32.TryParse(customerInput, out customerInputConvertedNumber);
                if (!customerMainmenuInput || customerInputConvertedNumber != 1 && customerInputConvertedNumber != 2)
                {
                    Console.WriteLine("Please Enter 1 or 2 to proceed");
                }

            } while (!customerMainmenuInput || customerInputConvertedNumber != 1 && customerInputConvertedNumber != 2);
            switch (customerInputConvertedNumber)
            {
                case 1:
                    storeLocations();
                    break;
                case 2:
                    customers.customerPastPurchase();
                    break;
            }

        }
        //runs a sql query to preview the list of store name and locations
        public void storeLocations()
        {
            Product productlist = new Product();
            string query1 = "SELECT * FROM StoreLocations;";
            connection.Open();
            SqlCommand cmdCommand = new SqlCommand(query1, connection);
            SqlDataReader dr = cmdCommand.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + ": " + dr[1].ToString() + ": " + dr[2].ToString());
            }
            //prompts the user to select from one of the storeLocations and evaluates the userinput to redirect to the list of product in store
            string input;
            int inputConvertednumber = 0;
            bool inputConverted = false;
            do
            {
                Console.WriteLine("Please select one of the location to shop at: ");
                input = Console.ReadLine();
                inputConvertednumber = 0;
                inputConverted = Int32.TryParse(input, out inputConvertednumber);
                if (inputConvertednumber != 1 && inputConvertednumber != 2 && inputConvertednumber != 3)
                {
                    Console.WriteLine("Please Enter 1,  2 or 3 to proceed");
                }
            } while (!inputConverted || (inputConvertednumber != 1 && inputConvertednumber != 2 && inputConvertednumber != 3));
            //uses user input to evaluate store location and displays list of product using productList method
            switch (inputConvertednumber)
            {
                case 1:
                    productlist.productList();
                    break;
                case 2:
                    productlist.productList();
                    break;
                case 3:
                    productlist.productList();
                    break;
            }


        }

    }

}
