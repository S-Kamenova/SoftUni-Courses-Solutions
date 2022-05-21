using System;
using System.Linq;
using System.Text;

namespace L05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder letters = new StringBuilder();
            StringBuilder numbers = new StringBuilder();
            StringBuilder otherChar = new StringBuilder();

            string text = Console.ReadLine();

            //char[] digits = text.Where(item => char.IsDigit(item)).ToArray();
            //char[] letters = text.Where(item => char.IsLetter(item)).ToArray();
            //char[] others = text.Where(item => !char.IsDigit(item) && !char.IsDigit(item)).ToArray();
            //Console.WriteLine(new string(digits));
            //Console.WriteLine(new string(letters));
            //Console.WriteLine(new string(others));
            

            foreach (char item in text)
            {
                if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else if (char.IsDigit(item))
                {
                    numbers.Append(item);
                }
                else
                {
                    otherChar.Append(item);
                }
            }
            Console.WriteLine(numbers.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(otherChar.ToString());
        }
    }
}
