using System.Data;

namespace backjun_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine().Split(' ');
            int firstNum = int.Parse(userInput[0]);
            int secondNum = int.Parse(userInput[1]);

            if (firstNum > secondNum)
            {
                Console.WriteLine(">");
            }
            else if (firstNum < secondNum)
            {
                Console.WriteLine("<");
            }
            else if(firstNum == secondNum)
            {
                Console.WriteLine("==");
            }

        }
    }
}