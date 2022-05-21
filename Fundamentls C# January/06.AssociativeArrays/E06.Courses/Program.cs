using System;
using System.Collections.Generic;

namespace E06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string comand = Console.ReadLine();



            while (comand != "end")
            {
                string[] token = comand.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = token[0];
                string studentName = token[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);


                comand = Console.ReadLine();
            }
            foreach (var item in courses)
            {
                string name = item.Key;
                List<string> students = item.Value;

                Console.WriteLine($"{name}: {students.Count}");

               // Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
