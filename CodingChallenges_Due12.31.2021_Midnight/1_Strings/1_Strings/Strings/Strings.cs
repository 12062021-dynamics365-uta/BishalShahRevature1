using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            *
            * implement the required code here and within the methods below.
            *
            */
            //enter a input to convert number to upper invoking StringToUpper method
            Console.WriteLine("Enter a string to convert to Upper");
            string s1 = Console.ReadLine();
            string s2 = Program.StringToUpper(s1);
            Console.WriteLine(s2);

            //converts the first input string to lower invoking StringToLower method
            Console.WriteLine("Enter an Upper string to convert to Lower");
            string s4 = Console.ReadLine();
            string s3 = Program.StringToLower(s4);
            Console.WriteLine(s3);

            //returns user input without whitespaces
            Console.WriteLine("Enter a string with whitespaces and return the string without whitespaces; ALAAHKAZZAM!!");
            string s5 = Console.ReadLine();
            string s6 = Program.StringTrim(s5);
            Console.WriteLine(s6);

            //Fetch specified data by invoking stringsubstring method to pass user input, indexPosition and lengthofString as arguments.
            Console.WriteLine("Enter a sentence");
            string userString = Console.ReadLine();
            Console.WriteLine("Enter placement value number to fetch data");
            int firstElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of character to fetch from data");
            int lengthOfSubstring = Convert.ToInt32(Console.ReadLine());
            string s9 = Program.StringSubstring(userString, firstElement, lengthOfSubstring);
            Console.WriteLine(s9);

            //SearchChar
            Console.WriteLine("Enter a input");
            string userInputString = Console.ReadLine();
            Console.WriteLine("Enter a character to search for its IndexPosition within the input");
            char charUserWants = Convert.ToChar(Console.ReadLine());
            int SearchCharacter = Program.SearchChar(userInputString, charUserWants);
            Console.WriteLine(SearchCharacter);

            //Concat

            Console.WriteLine("Enter a input");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter another input and press enter to add the two inputs");
            string lName = Console.ReadLine();
            string Concat = Program.ConcatNames(fName, lName);
            Console.WriteLine(Concat);
        }

        /// <summary>
        /// This method has one string parameter and will: 
        /// 1) change the string to all upper case and 
        /// 2) return the new string.
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>
        public static string StringToUpper(string usersString)
        {
            //returns the argument after invoking Toupper method
            return usersString.ToUpper();
            
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) change the string to all lower case,
        /// 2) return the new string into the 'lowerCaseString' variable
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>       
        public static string StringToLower(string usersString)
        {
            return usersString.ToLower();
            
            //returns the argument after invoking to Tolower method
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) trim the whitespace from before and after the string, and
        /// 2) return the new string.
        /// HINT: When getting input from the user (you are the user), try inputting "   a string with whitespace   " to see how the whitespace is trimmed.
        /// </summary>
        /// <param name="usersStringWithWhiteSpace"></param>
        /// <returns></returns>
        public static string StringTrim(string usersStringWithWhiteSpace)
        {
            return usersStringWithWhiteSpace.Trim();
            //returns the argument after invoking the .Trim method
        }

        /// <summary>
        /// This method has three parameters, one string and two integers. It will:
        /// 1) get the substring based on the first integer element and the length 
        /// of the substring desired.
        /// 2) return the substring.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="firstElement"></param>
        /// <param name="lastElement"></param>
        /// <returns></returns>
        public static string StringSubstring(string x, int firstElement, int lengthOfSubstring)
        {
            return x.Substring(firstElement, lengthOfSubstring);
            //returns the user input after implementing the substring method with specified arguments. 
        }

        /// <summary>
        /// This method has two parameters, one string and one char. It will:
        /// 1) search the string parameter for first occurrance of the char parameter and
        /// 2) return the index of the char.
        /// HINT: Think about how StringTrim() (above) would be useful in this situation
        /// when getting the char from the user. 
        /// </summary>
        /// <param name="userInputString"></param>
        /// <param name="charUserWants"></param>
        /// <returns></returns>
        public static int SearchChar(string userInputString, char charUserWants)
        {
            return userInputString.IndexOf(charUserWants);
            //returns the user input after implementing the IndexOf method with specified argument.
        }

        /// <summary>
        /// This method has two string parameters. It will:
        /// 1) concatenate the two strings with a space between them.
        /// 2) return the new string.
        /// HINT: You will need to get the users first and last name in the 
        /// main method and send them as arguments.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        public static string ConcatNames(string fName, string lName)
        {
            return string.Concat(fName, " ", lName);
            //passed the arguments using concat method and returns the value.
        }
    }//end of program
}
