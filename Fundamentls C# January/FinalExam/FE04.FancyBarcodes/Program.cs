using System;
using System.Linq;
using System.Text.RegularExpressions

namespace FE04.FancyBarcodes
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

            }
        }
    }
}
