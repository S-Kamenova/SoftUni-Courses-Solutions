using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    public class Student
    {
        public Student(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LasttName = lastName;
            Subject = subject;
        }
        
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Subject { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Student: First Name = {FirstName}, Last Name = {LasttName}, Subject = {Subject}");
            return sb.ToString().TrimEnd();
        }
    }
}
