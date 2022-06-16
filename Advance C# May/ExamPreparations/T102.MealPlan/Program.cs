using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T102.MealPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mealCalories = new Dictionary<string, int>();
            mealCalories.Add("salad", 350);
            mealCalories.Add("soup", 490);
            mealCalories.Add("pasta", 680);
            mealCalories.Add("steak", 790);

            Queue<string> meals = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Stack<int> calories = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int count = meals.Count();
            while (meals.Count>0 && calories.Count>0)
            {
                string meal = meals.Peek();
                int cal = calories.Peek();
                if (mealCalories.ContainsKey(meal))
                {
                    cal -= mealCalories[meal];
                    if (cal>0)
                    {
                        meals.Dequeue();
                        calories.Pop();
                        calories.Push(cal);
                    }
                    else
                    {
                        meals.Dequeue();
                        calories.Pop();
                        if (calories.Count>0)
                        {
                            int newCal = calories.Peek() - Math.Abs(cal);
                            calories.Pop();
                            calories.Push(newCal);
                        }
                        
                    }
                }
            }

            if (!(meals.Count>0))
            {
                Console.WriteLine($"John had {count} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {count-meals.Count} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
