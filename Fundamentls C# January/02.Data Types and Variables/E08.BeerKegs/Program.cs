using System;

namespace E08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggest = 0;
            string name = string.Empty;


            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * height * Math.Pow(radius, 2);

                if (volume>=biggest)
                {
                    biggest = volume;
                   name = model ;
                }

            }
            Console.WriteLine(name);
        }
    }
}
