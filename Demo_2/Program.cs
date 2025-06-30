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
            Console.WriteLine("Enter a Name:");
            String? name = Console.ReadLine();

            Console.WriteLine("Enter a Age:");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Salary:");
            decimal Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a Date :");
            Console.WriteLine("Name is :"+ name);
            Console.WriteLine("Age is :" + Age);
            Console.WriteLine("Salary is :" + Salary);
            #endregion
        }
    }
}
