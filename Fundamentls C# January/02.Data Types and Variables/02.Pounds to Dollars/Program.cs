using System;


namespace L02.Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dolars = pounds * 1.31m;

            Console.WriteLine($"{dolars:f3}");

            
        }
    }
}
