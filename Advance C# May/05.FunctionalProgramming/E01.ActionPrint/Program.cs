﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            Action<string> print = name => Console.WriteLine(name);
            list.ForEach(print);

        }
    }
}
