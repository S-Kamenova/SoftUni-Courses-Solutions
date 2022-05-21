using System;
using System.Collections.Generic;

namespace L04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (comand!="end")
            {
                string[] token = comand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = token[0];
                string lastName = token[1];
                int age = int.Parse(token[2]);
                string homeTown = token[3];

                Student newStudent = new Student()
                {
                    FirstName = firstName,
                    LasttName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };
                students.Add(newStudent);

                comand = Console.ReadLine();
            }

            string homeTownToSearch = Console.ReadLine();
            List<Student> filteredStudents = students
                .FindAll(student => student.HomeTown == homeTownToSearch);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LasttName} is {student.Age} years old.");
            }
        }
    }
}
