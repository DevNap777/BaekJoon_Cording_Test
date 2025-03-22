using System.Data;

namespace backjun_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine().Split(' ');
            int firstDice = int.Parse(userInput[0]);
            int secondDice = int.Parse(userInput[1]);
            int thirdDice = int.Parse(userInput[2]);

            if (firstDice == secondDice && secondDice == thirdDice)
            {
                Console.WriteLine(10000 + (firstDice * 1000));
            }
            else if (firstDice == secondDice)
            {
                Console.WriteLine(1000 + (firstDice * 100));
            }
            else if (firstDice == thirdDice)
            {
                Console.WriteLine(1000 + (firstDice * 100));
            }
            else if (secondDice == thirdDice)
            {
                Console.WriteLine(1000 + (secondDice * 100));
            }
            else
            {
                if (firstDice > secondDice && firstDice > thirdDice)
                {
                    Console.WriteLine(firstDice * 100);
                }
                else if (secondDice > firstDice && secondDice > thirdDice)
                {
                    Console.WriteLine(secondDice * 100);
                }
                else
                {
                    Console.WriteLine(thirdDice * 100);
                }
            }
        }   
    }
}