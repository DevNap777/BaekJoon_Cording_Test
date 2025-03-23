using System.Data;

namespace backjun_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int input = int.Parse(userInput);

            int result = 0;

            for (int i = 1; i <= input; i++)
            {
                result += i;
                
            }
            Console.WriteLine(result);
        }   
    }
}