using System.Data;

namespace backjun_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int checkyear;
            int.TryParse(input, out checkyear);

            if (checkyear % 4 == 0 && checkyear % 100 != 0)
            {
                Console.WriteLine("1");
            }
            else if (checkyear % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}