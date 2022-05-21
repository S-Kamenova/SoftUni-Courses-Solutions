using System;

namespace E10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int end = int.Parse(Console.ReadLine());
            //bool isSum = false;
            //bool isOdd = false;
            //int result = 0;
            //int num = 0;

            //for (int i = 1; i <=end; i++)
            //{
            //    string text = i.ToString();
            //    for (int j = 0; j < text.Length; j++)
            //    {
            //        char current = text[j];


            //        result += (int)current;
            //        if ((int)text[j]%2!=0)
            //        {
            //            isOdd = true;
            //            num = i;
            //            Console.WriteLine(num);
            //        }
            //    }
            //    if (result % 8 == 0)
            //    {
            //        isSum = true;
            //    }


            //}



            int number = int.Parse(Console.ReadLine());
            IsTopNumber(number);


            static void IsTopNumber(int number)
            {
                for (int i = 1; i <= number; i++)
                {
                    int sum = 0;
                    bool oddDigit = false;
                    int cpy = i;
                    while (true)
                    {
                        if (cpy == 0) break;
                        int right = cpy % 10;
                        sum += right;
                        if (!(right % 2 == 0)) oddDigit = true;
                        cpy /= 10;
                    }
                    if (sum % 8 == 0 && oddDigit == true)
                    {
                        Console.WriteLine(i);
                    }
                }


            }
        }
    }
}
