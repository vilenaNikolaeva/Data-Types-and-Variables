using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                int diggit = number % 10;
                sum += diggit;
                number /= 10;
            }
            Console.WriteLine(sum);

        }
    }
}
