using System;

namespace ME01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int num = int.Parse(Console.ReadLine());
                Calculate(type, num);
            }
            else if (type == "real")
            {
                double num = double.Parse(Console.ReadLine());
                Calculate(type, num);
            }
            else if (type == "string")
            {
                string num = Console.ReadLine();
                Calculate(type, num);
            }


        }

        static void Calculate(string type, int num)
        {
            int result = 0;
            if (type == "int")
            {
                result = num * 2;
            }
            Console.WriteLine(result); ;
        }
        static void Calculate(string type, double num)
        {
            double result = 0;
            if (type == "real")
            {
                result = num * 1.5;
            }
            Console.WriteLine($"{result:f2}");
        }
        static void Calculate(string type, string num)
        {
            if (type == "string")
            {
                Console.WriteLine($"${num}$");
            }
        }
    }
    }

