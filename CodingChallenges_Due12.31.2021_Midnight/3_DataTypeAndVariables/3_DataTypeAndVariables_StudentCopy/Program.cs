using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            // Insert code here.
            //
            //Instantiate an object storing a value of the data type and invoking Printvalues method to print the datatype 
            string @string = "This is a string";
            PrintValues(@string);


            double @double = 1.75315945678915;
            PrintValues(@double);


            sbyte @sbyte = -128;
            PrintValues(@sbyte);


            ulong @ulong = 0;
            PrintValues(@ulong);


            int @int32 = -2147483647;
            PrintValues(@int32);


            byte @byte= 255;
            PrintValues(@byte);


            decimal @decimal = 999.354M;
            PrintValues(@decimal);


            float @float = 0;
            PrintValues(@float);


            short @short = 30000;
            PrintValues(@short);


            uint @uint = 1;
            PrintValues(@uint);


            ushort @ushort = 50000;
            PrintValues(@ushort);


            long @long = 9223372036854775807;
            PrintValues(@long);


            char @char= '\u00FA';
            PrintValues(@char);



            //Invoke StringtoInt method
            Console.WriteLine("Enter a string to convert to int");
            string numString = Console.ReadLine();
            var output = Program.StringToInt(numString);
            Console.WriteLine(output);

        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
            //invoking system.Typecode to get datatype of the parameter
            TypeCode typeCode = Type.GetTypeCode(obj.GetType());
            //using the typecode as a expression to evaluate the datatype.
            switch (typeCode)
            {
                case TypeCode.String:
                    return "Data type => string";

                case TypeCode.Double:
                    return "Data type => double";

                case TypeCode.SByte:
                    return "Data type => sbyte";

                case TypeCode.UInt64:
                    return "Data type => ulong";

                case TypeCode.Int32:
                    return "Data type => int";

                case TypeCode.Byte:
                    return "Data type => byte";

                case TypeCode.Decimal:
                    return "Data type => decimal";

                case TypeCode.Single:
                    return "Data type => float";

                case TypeCode.Int16:
                    return "Data type => short";

                case TypeCode.UInt32:
                    return "Data type => uint";  

                case TypeCode.UInt16:
                    return "Data type => ushort";

                case TypeCode.Int64:
                    return "Data type => long";

                case TypeCode.Char:
                    return "Data type => char";

                default:
                    return "Error, not valid.";

            }
        }

            /// <summary>
            /// THis method has a string parameter.
            /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
            /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
            /// 3. If the string cannot be converted to a integer, return 'null'. 
            /// 4. Investigate how to use '?' to make non-nullable types nullable.
            /// </summary>
            /// <param name="numString"></param>
            /// <returns></returns>
            public static int? StringToInt(string numString)
            {
                //instantiate a int type variable if the output is int
                int number;
                // convert the string into an int type using TryParse method
                bool success = Int32.TryParse(numString, out number);
                //if the output of string type is not int display null else display the int value
                if (!success)
                {
                    return null;
                }
                else
                {
                    return number;
                    //throw new NotImplementedException($"StringToInt() has not been implemented");
                }

            }
        // end of class
    }
}// End of Namespace
