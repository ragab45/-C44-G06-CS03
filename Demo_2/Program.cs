using System;

namespace Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1. Program to allow the user to enter a number then print it

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);

            #endregion
            #region  Q2  
            /*
             2. Convert a string with non-numeric characters to an integer and explain what happens
             */

            string input = "123abc";
            int result = Convert.ToInt32(input);

            #endregion
            #region  Q3 
            //  3. Perform arithmetic operation with floating-point numbers and explain:
            float a = 5.7f;
            float b = 2.3f;
            float sum = a + b;
            Console.WriteLine("Sum: " + sum);


            #endregion
            #region  Q4
            /*
             Write C# program that Extract a substring from a given string.
             */
            string text = "Hello, World!";
            string sub = text.Substring(7, 5); 
            Console.WriteLine("Substring: " + sub);

            #endregion
        }
    }
}
