using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
        }

        public static string GetName()
        {
            //throw new NotImplementedException("GetName() is not implemented yet0");
            Console.WriteLine("Greetings! Enter your name.");
            string userName = Console.ReadLine();
            return userName;
        }
        public static string GreetFriend(string name)
        {
            //throw new NotImplementedException("GreetFriend() is not implemented yet");
            return "Hello, " + name + ". You are my friend.";
            
        }
        public static double GetNumber()
        {
            //throw new NotImplementedException("GetNumber() is not implemented yet");
            Console.WriteLine("Enter your number.");
            double userName = Convert.ToDouble(Console.ReadLine());
            return userName;
        }

        public static int GetAction()
        {
            //throw new NotImplementedException("GetAction() is not implemented yet");

            Console.WriteLine("Please choose one of the following: [1]Addition, [2]Subtraction, [3]Multiplcation, [4]Division.");
            //instantiate stored variable, bool statement to loop over the unselected range and an int type that evaluates the output of stored variable.
            string userInput;
            bool userInputConverted = false;
            int userInputConvertedNumber;

            //This loop iterates itself until int type specified in the data range below is selected.
            do
            {

                //store the user input in a string variable
                userInput = Console.ReadLine();

                //convert the string variable into int type using tryparse method
                userInputConverted = Int32.TryParse(userInput, out userInputConvertedNumber);

            } while (!userInputConverted  || userInputConvertedNumber < 1  || userInputConvertedNumber > 4);

            //returns the user input as int type if specified within the data range else returns invalid error.
            if (userInputConvertedNumber >= 1 || userInputConvertedNumber <= 4)
            {
                return userInputConvertedNumber;
            }
            else
            {
                Console.WriteLine("Invalid input!");
                GetAction();
                return 0;
            }

        }


        public static double DoAction(double x, double y, int action)
        {
            //throw new NotImplementedException("DoAction() is not implemented yet");
            //throws a format exception if the action input is not within the specified range.
            if (action < 1 || action > 4)
                throw new FormatException();


            //throw new NotImplementedException("DoAction() is not implemented yet");
            double z = 0;
            switch (action)
            {
                //select for Addition
                case 1:
                    Console.WriteLine("Addition:");
                    z = x + y;
                    return z;
                    

                //select for Subtraction
                case 2:
                    Console.WriteLine("Subtraction:");
                    z = y - x;
                    return z;
                    

                //select for Multiplciation
                case 3:
                    Console.WriteLine("Multiplciation:");
                    z = x * y;
                    return z;
                    

                //select for Division
                case 4:
                    Console.WriteLine("Division:");
                    try
                    {
                        z = (x / y);

                    }
                    //throws an arithmetic exception if trying to divide by 0
                    catch (ArithmeticException) 
                    {
                        Console.WriteLine("You can't divide by zero!");
                    }
                    return z;
                    //returns a default value of 0
                    default:
                    return 0;
                    
            }
        }
    }
    
}
