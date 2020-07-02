using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int waterTank = int.Parse(Console.ReadLine());
            int liters = 0;

            int capacity = 0;

            for (int i = 1; i <= waterTank; i++)
            {
                liters = int.Parse(Console.ReadLine());
                capacity += liters;
                if (capacity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity -= liters;
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
