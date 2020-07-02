using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int workingDays = 0;
            int totalAmount = 0;
            int yieldDrops = 10;

            while (yield >= 100)
            {
                workingDays++;
                int dropping = yield - yieldDrops;
                totalAmount += yield - 26;
                yield = dropping;
            }
            if (yield < 100)
            {
                Console.WriteLine($"{workingDays}");
                Console.WriteLine($"{totalAmount - 26}");
            }
            else
            {
                Console.WriteLine("balbblaa");
            }
        }
    }
}
