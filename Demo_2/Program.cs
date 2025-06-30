using System;
using System.ComponentModel;

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
            #region  Q5
            /*
             Write C# program that Assigning one value type 
            variable to another and modifying the value of one variable
            and mention what will happen
             
             */
            int x = 10;
            int y = x;
            y = 20;
            Console.WriteLine("x = " + x); 
            Console.WriteLine("y = " + y);

            #endregion
            #region  Q6
            /*
             Write C# program that Assigning one reference type variable to
            another and modifying the object through one variable 
            and mention what will happen
             
             */
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 100;

            Console.WriteLine("arr1[0]: " + arr1[0]);

            #endregion
            #region  Q7
            //Write C# program that take two string variables and print them as one variable 
            string first = "Hello";
            string second = "World";
            string combined = first + " " + second;
            Console.WriteLine(combined);

            #endregion

            #region  Q8
            /*
             Write a program that calculates the simple interest given 
            the principal amount, rate of interest, and time. The formula for simple interest is 
            Interest = (principal * rate * time ) /100.

             
             */

            double principal = 1000, rate = 5, time = 2;
            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest: " + interest);

            #endregion
            #region Q9
            /*
             Write a program that calculates the Body Mass Index (BMI)
            given a person's weight in kilograms and height in meters. 
            The formula for BMI is
            BMI = (Weight)/(Height*Height)

             
             */
            double weight = 70; // kg
            double height = 1.75; // meters
            double bmi = weight / (height * height);
            Console.WriteLine("BMI: " + bmi);

            #endregion
            #region Q10
            /*
             Write a program that uses the ternary operator to check if the 
            temperature is too hot, too cold, or just good. Assign the result in a
            variable then display the result. Assume that below 10 degrees is "Just Cold",
            above 30 degrees is "Just Hot", and anything else is "Just Good".
             */
            int temperature = 15;
            string result = (temperature < 10) ? "Just Cold" :
                            (temperature > 30) ? "Just Hot" : "Just Good";
            Console.WriteLine("Temperature status: " + result);

            #endregion
            #region Q11

            Console.Write("Enter day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Today's date: {day} , {month} , {year}");
            Console.WriteLine($"Today's date: {day} / {month} / {year}");
            Console.WriteLine($"Today's date: {day} – {month} – {year}");

            #endregion

        }
    }
}
