using System;
using System.Collections.Generic;
using System.Linq;

namespace E08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while (comand!="End")
            {
                string[] token = comand.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string company = token[0];
                string id = token[1];

                if (!users.ContainsKey(company))
                {
                    users.Add(company, new List<string>());
                }
                if (!users[company].Contains(id))
                {
                users[company].Add(id);
                }

                comand = Console.ReadLine();
            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key}");
                List<string> employes = item.Value;
                foreach (var employe in employes)
                {
                    Console.WriteLine($"--{employe}");
                }
            }
        }
    }
}
