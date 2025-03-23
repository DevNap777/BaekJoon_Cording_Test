using System.Data;

namespace backjun_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int input = int.Parse(userInput);

            for (int i = input; i <= input; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

            }
        }   
    }
}