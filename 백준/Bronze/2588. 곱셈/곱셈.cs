using System;

namespace baekjun1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string userInputs = Console.ReadLine();
            
            int A = int.Parse(userInput);
            int B = int.Parse(userInputs);

            Console.WriteLine(A * (B % 10));
            Console.WriteLine(A * ((B / 10) % 10));
            Console.WriteLine(A * (B / 100));
            Console.WriteLine(A * B);
        }
    }
}
