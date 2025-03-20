using System;

namespace baekjun1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string userInput = Console.ReadLine();
           string[] input = userInput.Split();
            
            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);

            Console.WriteLine(A / (double)B);
        }
    }
}
