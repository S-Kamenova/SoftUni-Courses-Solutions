using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            string comand = Console.ReadLine();
            int shootCounter = 0;

            while (comand != "End")
            {
                int indexToShoot = int.Parse(comand);

                if (indexToShoot >= 0
                    && indexToShoot < target.Length
                    && target[indexToShoot] != -1)
                {
                    ShootTarget(indexToShoot, target);
                    shootCounter++;
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shootCounter} -> {string.Join(" ", target)}");




            static void ShootTarget(int indexToShoot, int[] target)
            {
                var valueOfTarget = target[indexToShoot];

                target[indexToShoot] = -1;

                for (int i = 0; i < target.Length; i++)
                {
                    if (target[i] == -1)
                    {
                        continue;
                    }

                    if (target[i] > valueOfTarget)
                    {
                        target[i] -= valueOfTarget;
                    }
                    else
                    {
                        target[i] += valueOfTarget;
                    }
                }

            }
        }
    }
}
