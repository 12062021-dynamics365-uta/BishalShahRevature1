using System;
using System.Collections.Generic;
using System.Linq;

namespace SweenNSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to SweetNSalty Console");
            Console.WriteLine("\n");
            Console.WriteLine("Printing numbers 1-1000 in increments of 20: ");
            Console.WriteLine("\n");
            //instantiate variables to count the number of integers that pass certain if methods
            int Sweet = 0;
            int Salty = 0;
            int SweetNSalty = 0;
            //set up a for loop to evaluate int begining from 1 to 1000 by the following if else statements
            for (int i = 1; i <= 1000; i++)
            {
                //this method evaluates if the int is both a multiple of 3 and 5 by using the modulus operator
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //.Write method writes the statement in 1 line until it breaks using the last if expression(line 46)
                    Console.Write("SweetNSalty" + " ");
                    //increments the count of number of int that pass this if statement
                    SweetNSalty++;
                }
                //this method only evaluates if the int is a multiple of 5
                //this expression also conflicted with the if statement(line 54) therefore had to use else if and if to evaluate those 2 expression
                else if (i % 5 == 0)
                {
                    Console.Write("Salty" + " ");
                    Salty++;
                }
                //this method evaluates if the int is a multiple of 3
                else if (i % 3 == 0)
                {
                    Console.Write("Sweet" + " ");
                    Sweet++;
                }
                //This method only evaluates true if all other if expressions have been executed
                else
                {
                    //this method writes the (integer value + " ") on the same line; if none of the if expression is true
                    Console.Write(i + " ");

                }
                //this method evaluates only if the expression is true
                if (i % 20 == 0)
                {
                    //prints a new line to seperate the list of integers displayed in groups of 20
                    Console.WriteLine("\n");
                }

            }

            Console.WriteLine("Total number of times SweetNSalty was printed: " + SweetNSalty);
            Console.WriteLine("Total number of times Salty was printed: " + Salty);
            Console.WriteLine("Total number of times Sweet was printed: " + Sweet);




        }
    }
}
