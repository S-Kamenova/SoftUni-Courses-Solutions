using System;

namespace E10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double dispalyPrice = double.Parse(Console.ReadLine());


            int counterHeadset = 0;
            int counterMouse = 0;
            int counterKeyboard = 0;
            int counterDisplay = 0;

            //При всяка втора загубена игра Петър изхвърля слушалките си
            //При всяка трета загубена игра Петър разбива мишката си.
            //Когато Петър изхвърля и мишката, и слушалките си в една и съща загубена игра, той изхвърля и клавиатурата си.
            //Всеки втори път, когато изхвърля клавиатурата си, той изхвърля и дисплея си.

            for (int i = 1; i <= lostGames; i++)
            {
                if (i%2==0)
                {
                    counterHeadset++;
                }
                if (i%3==0)
                {
                    counterMouse++;
                }
                if (i%2==0 && i%3==0)
                {
                    counterKeyboard++;

                    if (counterKeyboard%2==0)
                    {
                        counterDisplay++;
                    }
                }

            }

            double price = counterHeadset * headsetPrice + counterMouse * mousePrice + counterKeyboard * keyboardPrice + counterDisplay * dispalyPrice;
            Console.WriteLine($"Rage expenses: {price:f2} lv.");

        }
    }
}
