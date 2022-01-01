using System;

namespace _6_FlowControl
{
    public class Program
    {
        //to share the attributes with other classes(thanks to kevin and daniel)
        string username;
        string password;
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// This method gets a valid temperature between -40 asnd 135 inclusive from the user
        /// and returns the valid int. 
        /// </summary>
        /// <returns></returns>
        public static int GetValidTemperature()
        {
            //throw new NotImplementedException($"GetValidTemperature() has not been implemented.");
            string userTemp;
            bool userTempConverted = false;
            int userTempConvertedNumber;

            //This loop iterates itself until int type specified in the data range below is selected.
            do
            {

                //store the user input in a string variable
                userTemp = Console.ReadLine();

                //convert the string variable into int type using tryparse method
                userTempConverted = Int32.TryParse(userTemp, out userTempConvertedNumber);

            } while (!userTempConverted || userTempConvertedNumber < -40 || userTempConvertedNumber > 135);
            return userTempConvertedNumber;
        }

        /// <summary>
        /// This method has one int parameter
        /// It prints outdoor activity advice and temperature opinion to the console 
        /// based on 20 degree increments starting at -20 and ending at 135 
        /// n < -20, Console.Write("hella cold");
        /// -20 <= n < 0, Console.Write("pretty cold");
        ///  0 <= n < 20, Console.Write("cold");
        /// 20 <= n < 40, Console.Write("thawed out");
        /// 40 <= n < 60, Console.Write("feels like Autumn");
        /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
        /// 80 <= n < 90, Console.Write("niiice");
        /// 90 <= n < 100, Console.Write("hella hot");
        /// 100 <= n < 135, Console.Write("hottest");
        /// </summary>
        /// <param name="temp"></param>
        public static void GiveActivityAdvice(int temp)
        {
            //throw new NotImplementedException($"GiveActivityAdvice() has not been implemented.");
            //using if else statement to specify the data range to output what the method wants to display per summary.
            if(temp < -20)
            {
                Console.WriteLine("hella cold");
            }
            else if (temp<0 && temp >= -20)
            {
                Console.WriteLine("pretty cold");
            }
            else if (temp >= 0 && temp < 20)
            {
                Console.WriteLine("cold");
            }
            else if (temp >= 20 && temp < 40)
            {
                Console.WriteLine("thawed out");
            }
            else if (temp >= 40 && temp < 60)
            {
                Console.WriteLine("feels like Autumn");
            }
            else if (temp >= 60 && temp < 80)
            {
                Console.WriteLine("perfect outdoor workout temperature");
            }
            else if (temp >= 80 && temp < 90)
            {
                Console.WriteLine("niiice");
            }
            else if (temp >= 90 && temp < 100)
            {
                Console.WriteLine("hella hot");
            }
            else if (temp >= 100 && temp < 135)
            {
                Console.WriteLine("hottest");
            }else
            {
                Console.WriteLine("Error, invalid input!"); 
            }
        }

        /// <summary>
        /// This method gets a username and password from the user
        /// and stores that data in the global variables of the 
        /// names in the method.
        /// </summary>
        public static void Register()
        {
            //throw new NotImplementedException($"Register() has not been implemented.");
            //(instantiated username & password in program class so the variable can be accessible by other methods)
            //prompts the user to register and stores the username and password
            Console.WriteLine("Enter your username to register:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password to register:");
            string password = Console.ReadLine();

            Console.WriteLine($"saved: username: {username} password: {password}");

        }

        /// <summary>
        /// This method gets username and password from the user and
        /// compares them with the username and password names provided in Register().
        /// If the password and username match, the method returns true. 
        /// If they do not match, the user is reprompted for the username and password
        /// until the exact matches are inputted.
        /// </summary>
        /// <returns></returns>
        public static bool Login(string username, string password)
        {
            //throw new NotImplementedException($"Login() has not been implemented.");
            //prompts the user to enter their username and password to login
            Console.WriteLine("Enter your username to login:");
            string loginusername = Console.ReadLine();
            Console.WriteLine("Enter your password to login:");
            string loginpassword = Console.ReadLine();
            //if the users input matches the value stored in register returns true else false
            if (loginusername == username && loginpassword == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method has one int parameter.
        /// It checks if the int is <=42, Console.WriteLine($"{temp} is too cold!");
        /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
        /// or > 78, Console.WriteLine($"{temp} is too hot!");
        /// For each temperature range, a different advice is given. 
        /// </summary>
        /// <param name="temp"></param>
        public static void GetTemperatureTernary(int temp)
        {
            //following if statements evaluate to check if the temp is below specified value and displays an output based on the evaluation.
            if (temp <= 42)
            {
                Console.WriteLine($"{temp} is too cold!");
            }
            else if (temp >= 43 && temp <= 78)
            {
                Console.WriteLine($"{temp} is an ok temperature");
            }
            else if (temp > 78)
            {
                Console.WriteLine($"{temp} is too hot!");
            }
            else
            {
                Console.WriteLine("Error, invalid input!");
            }
        }
    }//EoP
}//EoN
