using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //Func<List<int>, int> getminElement = nubers => numbers.Min(); 
            //Console.WriteLine(getminElement(numbers));

            Action<List<int>> printMinElement = nubers => Console.WriteLine(numbers.Min());
            printMinElement(numbers);

        }
    }
}
