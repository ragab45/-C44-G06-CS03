using System.Globalization;

namespace Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video-1
            //float x= 2.5654831547988f;
            //double y = 3.5;     
            //decimal z = 4.5m;
            //Console.WriteLine(z);

            //long a = 100_000_000_0000;
            //Console.WriteLine($"{a:c}");

            //var Calculatorinfo   = new CultureInfo("SA-ar");
            //Console.WriteLine($"{a.ToString("C", Calculatorinfo)}");
            #endregion

            #region Video_2
            // over flowing 
            //unchecked { 
            //long b = 100_000_000_0000;  
            //    int Y=()int)b;
            //    Console.WriteLine(Y);

            //}

            //long E = 100_000_000_0000;
            //if (E > int.MaxValue || E < int.MinValue)
            //{
            //    Console.WriteLine("The value is out of range for an int.");
            //}
            //else
            //{
            //    int Y = (int)E;
            //    Console.WriteLine(Y);
            //}
            #endregion

            #region Video_3 
            //Console.WriteLine("Enter a Name:");
            //String? name = Console.ReadLine();

            //Console.WriteLine("Enter a Age:");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a Salary:");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Enter a Date :");
            //Console.WriteLine("Name is :"+ name);
            //Console.WriteLine("Age is :" + Age);
            //Console.WriteLine("Salary is :" + Salary);
            #endregion

            #region Video_4
            #region Logical Operators [!, && , ||]

            /// Short Circuit
            //Console.WriteLine(!true);              // False
            //Console.WriteLine(false && true);     // False
            //Console.WriteLine(false || true);     // True

            //Console.WriteLine(4 < 5 && 7 < 9);    // True
            //Console.WriteLine(4 < 5 && 7 > 9);    // False
            //Console.WriteLine(4 > 5 && 7 < 9);    // False

            #endregion
            #region Terany Operator [Conditional Operator ?:]

            //int X = 10, Y = 5;
            //if (X > Y)
            //    Console.WriteLine("X > Y");
            //else
            //    Console.WriteLine("X < Y");

            //string message = (X > Y) ? true : false;

            ////string Message = X > Y ? "X > Y" : "X < Y";

            ////Console.WriteLine(Message);

            #endregion

            #endregion

            #region Vidoe_8 
            // 1. String Concatenations
            //message = "Equation : " + X + " + " + Y + " = " + res
            //Console.WriteLine(message);

            // 2. Composite Formatting
            //Console.WriteLine("Equation : {0} + {1} = {2}", X, Y,

            // //3. String.Format
            //message = string.Format("Equation : {0} + {1} = {2}",
            int Z = 4500;
            string message = string.Format("0:c", Z); // هذا السطر هو الموجود في الصورة بشكل أوضح
                                                      //Console.WriteLine(message);

            // 4. String Interpolation
            //message = $"Equation : {X} + {Y} = {result}";
            //Console.WriteLine(message);

            //message = @"D:\C44\DemoC#02C44\DemoC#02C44
            //Console.WriteLine(message);
            #endregion

            #region Video_9 if condition
            Console.WriteLine("Please Enter A Month Number Existed In 1st Quarter:");
            int.TryParse(Console.ReadLine(), out int value);

            if (value == 1)
            {
                Console.WriteLine("Hello January");
            }
            else if (value == 2)
            {
                Console.WriteLine("Hello February");
            }
            else if (value == 3)
            {
                Console.WriteLine("Hello March");
            }
            else
            {
                Console.WriteLine("Invalid Month Number");
            }
            #region  switch
            switch (value)
            {
                case 1:
                    Console.WriteLine("Hello January");
                    break;
                case 2:
                    Console.WriteLine("Hello February");
                    break;
                case 3:
                    Console.WriteLine("Hello March");
                    break;
                default:
                    Console.WriteLine("Invalid Month Number");
                    break;
            }
            #endregion
            #endregion

        }
    }
}
