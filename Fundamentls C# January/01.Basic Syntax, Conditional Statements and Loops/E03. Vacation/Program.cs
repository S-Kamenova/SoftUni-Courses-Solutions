using System;

namespace E03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double total = 0;


            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                   
                    if (people >=30)
                    {
                        total = 0.85 * people * price;
                    }
                    else
                    {
                        total = people * price;
                    }
                    break;

                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                   
                    if (people>=100)
                    {
                        total = (people - 10) * price;
                    }
                    else
                    {
                        total = people * price;
                    }
                    break;

                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                   

                    if (people>=10 && people<=20)
                    {
                        total = 0.95 * (people * price);
                    }
                    else
                    {
                        total = people * price;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {total:f2}");
           
        }
    }
}
