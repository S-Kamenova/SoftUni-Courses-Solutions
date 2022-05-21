using System;
using System.Collections.Generic;

namespace L05.Students2._0
{
    class Student
    {
        public Student(string firstName,
            string lastname,
            int age,
            string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (comand != "end")
            {
                string[] token = comand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = token[0];
                string lastName = token[1];
                int age = int.Parse(token[2]);
                string homeTown = token[3];

                bool doesStudentsexist = Doesstudentsexist(students, firstName, lastName);
                if (doesStudentsexist)
                {
                    
                    Student existingStudent = GetExistingStudent(students, firstName, lastName);

                    //using System.Linq
                    //same as GetExistingStudent metod
                    //Student existingStudent = students.FirstOrDefault(Student =>
                     // student.FirstName == firstName &&
                    //  student.LasttName == lastName);

                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;
                }
                else
                {
                    Student newStudent = new Student(firstName, lastName, age, homeTown);

                    students.Add(newStudent);
                }



                comand = Console.ReadLine();
            }

            string homeTownToSearch = Console.ReadLine();
            List<Student> filteredStudents = students
                .FindAll(student => student.HomeTown == homeTownToSearch);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        private static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }

            }
            return null;

        }

        static bool Doesstudentsexist(List<Student> students,
            string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
