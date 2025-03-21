using System;

namespace baekjun1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int userInput;
            int.TryParse(input, out userInput);

            if (userInput <= 100 && userInput >= 90)
            {
                Console.WriteLine("A");
            }

            else if (userInput < 90 && userInput >= 80)
            {
                Console.WriteLine("B");
            }

            else if (userInput < 80 && userInput >= 70)
            {
                Console.WriteLine("C");
            }

            else if (userInput < 70 && userInput >= 60)
            { 
                Console.WriteLine("D");
            }

            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
