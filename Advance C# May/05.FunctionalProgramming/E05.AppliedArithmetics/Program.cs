using System;
using System.Collections.Generic;
using System.Linq;


namespace E05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //Func<List<int>, List<int>> add = list => list.Select(num => num += 1).ToList();
            //Func<List<int>, List<int>> multiply = list => list.Select(num => num *= 2).ToList();
            //Func<List<int>, List<int>> substract = list => list.Select(num => num -= 1).ToList();
            //Action<List<int>> print = list => Console.WriteLine(string.Join(" ",list));

            //string comand = Console.ReadLine();

            //while (comand!="end")
            //{
            //    switch (comand)
            //    {
            //        case "add":
            //            numbers = add(numbers);
            //            break;
            //        case "multiply":
            //            numbers = multiply(numbers);
            //            break;
            //        case "subtract":
            //            numbers = substract(numbers);
            //            break;
            //        case "print":
            //            print(numbers);
            //            break;
            //    }
            //    comand = Console.ReadLine();
            //}


            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));

            Func<List<int>, List<int>> operations = null;
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                switch (comand)
                {
                    case "add":
                        operations = list => list.Select(num => num += 1).ToList();
                        numbers = operations(numbers);
                        break;
                    case "multiply":
                        operations = list => list.Select(num => num *= 2).ToList();
                        numbers = operations(numbers);
                        break;
                    case "subtract":
                        operations = list => list.Select(num => num -= 1).ToList();
                        numbers = operations(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }
                comand = Console.ReadLine();
            }
        }
    }
}
