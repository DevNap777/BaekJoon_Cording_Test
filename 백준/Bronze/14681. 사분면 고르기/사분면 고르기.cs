using System.Data;

namespace backjun_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInput;
            string secondInput;
            int firstQuad = int.Parse(Console.ReadLine());
            int secondQuad = int.Parse(Console.ReadLine());

            if (firstQuad > 0 && secondQuad > 0)
            {
                Console.WriteLine("1");
            }
            else if (firstQuad < 0 && secondQuad > 0)
            {
                Console.WriteLine("2");
            }
            else if (firstQuad < 0 && secondQuad < 0)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("4");
            }

        }
    }
}