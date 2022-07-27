using System;

namespace CustomRandomList
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("pesho"); 
            list.Add("pesho1");
            list.Add("pesho2");
            list.Add("pesho3");

            Console.WriteLine(list.RandomString());
        }
    }
}
