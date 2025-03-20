namespace backjun_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] userInput = input.Split();

            int a = int.Parse(userInput[0]);
            int b = int.Parse(userInput[1]);
            
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }
}