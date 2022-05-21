using System;
using System.Numerics;

namespace E11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

           BigInteger bestValue = BigInteger.Zero;

            for (int i = 1; i <= number; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                int snowTimeDivide = snow / time;
                BigInteger currentValue = BigInteger.Pow(snowTimeDivide, quality);

                if (currentValue>=bestValue)
                {
                    bestValue = currentValue;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
