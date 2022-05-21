using System;

namespace L01.Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
          decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000;
            Console.WriteLine($"{kilometers:F2}");

           // int meters = int.Parse(Console.ReadLine());
          //double kilometers = meters / 1000.0;
           // Console.WriteLine($"{kilometers:F2}");
        }
    }
}
