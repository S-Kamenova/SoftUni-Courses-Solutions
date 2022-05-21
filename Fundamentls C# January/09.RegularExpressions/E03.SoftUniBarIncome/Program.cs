using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace E03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^%$|.]*?\<(?<product>\w+)\>[^%$|.]*?\|(?<count>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)\$";

            
            decimal total = 0;

            string input = Console.ReadLine();


            while (input != "end of shift")
            {
                Match info = Regex.Match(input, pattern);
                if (info.Success)
                {
                    string client = info.Groups["name"].Value;
                    string product = info.Groups["product"].Value;
                    int count = int.Parse(info.Groups["count"].Value);
                    decimal price = decimal.Parse(info.Groups["price"].Value);

                    decimal sum = count * price;
                    total += sum;

                    Console.WriteLine($"{client}: {product} - {sum:f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
