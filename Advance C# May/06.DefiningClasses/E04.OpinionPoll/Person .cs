﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

       
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get { return this.name; } set { name = value; } }

        public int Age { get { return this.age; } set { age = value; } }
    }
}
