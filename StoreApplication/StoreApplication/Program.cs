using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Storage;


namespace StoreApplication
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int customerId;
            string firstName;
            string lastName;
            string userName;
            string password;
            Customer customers = new Customer();
            StoreLogic sL = new StoreLogic();
            string input;
            int inputConvertednumber = 0;
            bool inputConverted = false;
            //prompts the user to login/register/or exit 
            do
            {
                Console.WriteLine("Welcome customer, press 1 to login or press 2 to register or 3 to exit");
                input = Console.ReadLine();
                inputConvertednumber = 0;
                inputConverted = Int32.TryParse(input, out inputConvertednumber);
                if (inputConvertednumber != 1 && inputConvertednumber != 2 && inputConvertednumber !=3)
                {
                    Console.WriteLine("Please Enter 1 or 2 to proceed or 3 to exit");
                }

            } while (!inputConverted || (inputConvertednumber != 1 && inputConvertednumber != 2 && inputConvertednumber != 3));
            //using the inputConvertednumber as an expression to evaluate user choice with the corresponding cases
            switch (inputConvertednumber)
            {
                case 1:
                    Console.WriteLine("Enter your username:");
                    userName = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    password = Console.ReadLine();
                    //uses the stored variables as arguments to access customerLogin Method
                    customerId = customers.CustomerLogin(userName, password);
                    break;
                case 2:
                    Console.Write("Enter your first name: ");
                    firstName = Console.ReadLine();
                    Console.Write("Enter your last name: ");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Enter your username:");
                    userName = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    password = Console.ReadLine();
                    //uses the stored variables as arguments to access registerCustomer Method
                    customers.registerCustomer(firstName, lastName, userName, password);
                    Console.WriteLine("welcome " + firstName + lastName);
                    sL.storeMainMenu();
                    break;
                case 3:
                    Console.WriteLine("Thank you for using our service."); 
                    break;
            }
            
           

        }
    }
}
