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

            long a = 100_000_000_0000;
            Console.WriteLine($"{a:c}");

            var Calculatorinfo   = new CultureInfo("SA-ar");
            Console.WriteLine($"{a.ToString("C", Calculatorinfo)}");
            #endregion
        }
    }
}
