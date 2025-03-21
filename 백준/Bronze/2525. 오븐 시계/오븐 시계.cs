using System.Data;

namespace backjun_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(' ');
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);

            string cooked = Console.ReadLine();
            int cookedMin = int.Parse(cooked);

            minute += cookedMin;

            while (minute >= 60)
            {
                hour++;
                minute -= 60;
            }

            if (hour >= 24)
            {
                hour -= 24;
            }

            Console.WriteLine(hour + " " + minute);
        }
    }
}