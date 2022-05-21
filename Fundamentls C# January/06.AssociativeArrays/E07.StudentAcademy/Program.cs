using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> academy = new Dictionary<string, List<double>>();

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!academy.ContainsKey(name))
                {
                    academy.Add(name, new List<double>());
                }
                academy[name].Add(grade);

            }
            foreach (var item in academy)
            {

                if (item.Value.Average() >= 4.50)
                {
                    //string studentName = item.Key;
                    //List<double> grades = item.Value;
                    //Console.WriteLine($"{studentName} -> {grades.Average():f2}");
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");

                }

            }
        }
    }
}
