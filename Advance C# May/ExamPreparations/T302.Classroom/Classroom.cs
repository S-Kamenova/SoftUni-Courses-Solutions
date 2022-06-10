using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    class Classroom
    {
        public Classroom(int capacity)
        {
            Capacity = capacity;
            Students = new List<Student>();
        }

        public List<Student> Students { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return Students.Count; } }

        public string RegisterStudent(Student student)
        {
            if (Capacity >= Students.Count + 1)
            {
                Students.Add(student);
                return $"Added student {student.FirstName} {student.LasttName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            var currStudent = Students.FirstOrDefault(x => x.FirstName == firstName && x.LasttName == lastName);
            if (currStudent != null)
            {
                Students.Remove(currStudent);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            var studentsSubject = Students.Where(x => x.Subject == subject).ToList();

            if (studentsSubject.Count > 0)
            {
                var sb = new StringBuilder();

                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var item in studentsSubject)
                {
                    sb.AppendLine($"{item.FirstName} {item.LasttName}");
                }
                return sb.ToString().TrimEnd();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }

        public int GetStudentsCount()
        {
            return Count;
        }

        public Student GetStudent(string firstName, string lastName)
         => Students.FirstOrDefault(x => x.FirstName == firstName && x.LasttName == lastName);


    }
}
