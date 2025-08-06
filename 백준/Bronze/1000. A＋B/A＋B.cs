namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(userInput[0]) + int.Parse(userInput[1]));
        }
    }
}
