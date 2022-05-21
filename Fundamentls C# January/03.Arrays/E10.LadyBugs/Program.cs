using System;
using System.Linq;

namespace E10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialIndexis = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndexis.Length; i++)
            {
                int currentIndex = initialIndexis[i];

                if (currentIndex>=0 && currentIndex<field.Length)
                {
                field[currentIndex] = 1;
                }
            }

            string comand = string.Empty;

            while ((comand=Console.ReadLine()) != "end")
            {
                string[] elements = comand.Split(); // "0" "right" "1"
                int ladyBugindex =int.Parse( elements[0]);
                string direction = elements[1];
                int flyLenght = int.Parse(elements[2]);

                if (ladyBugindex<0|| ladyBugindex>field.Length-1 || field[ladyBugindex]==0)
                {
                    continue;
                }

                field[ladyBugindex] = 0;
                if (direction=="right")
                {
                    int landIdex = ladyBugindex + flyLenght;

                    if (landIdex>field.Length-1)
                    {
                        continue;
                    }

                    if (field[landIdex]==1)
                    {
                        while (field[landIdex]==1)
                        {
                            landIdex += flyLenght;
                            if (landIdex>field.Length-1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIdex>=0 && landIdex<=field.Length-1)
                    {
                    field[landIdex] = 1;
                    }
                }
                else if (direction=="left")
                {
                    int landIdex = ladyBugindex - flyLenght;

                    if (landIdex < 0)
                    {
                        continue;
                    }
                    if (field[landIdex] == 1)
                    {
                        while (field[landIdex] == 1)
                        {
                            landIdex -= flyLenght;
                            if (landIdex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIdex >= 0 && landIdex <= field.Length - 1)
                    {
                        field[landIdex] = 1;
                    }
                 
                }
            }
            Console.WriteLine(String.Join(' ',field));
        }
    }
}
