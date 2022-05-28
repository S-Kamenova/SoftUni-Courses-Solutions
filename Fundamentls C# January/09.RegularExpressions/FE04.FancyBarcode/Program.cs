using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FE04.FancyBarcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string barcode = Console.ReadLine();

                if (pattern.IsMatch(barcode))
                {
                    char[] digits = barcode.Where(x => char.IsDigit(x)).ToArray();
                    if (digits.Length==0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("",digits)}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
