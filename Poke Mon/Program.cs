using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int targetCount = 0;
            int originalPower = powerN;


            while (powerN >= distanceM)
            {
                powerN -= distanceM;
                targetCount++;

                if (powerN == originalPower * 0.5 && powerN != 0)
                {
                    powerN /= exhaustionFactorY;
                }
            }
            Console.WriteLine($"{powerN}");
            Console.WriteLine($"{targetCount}");
        }
    }
}
