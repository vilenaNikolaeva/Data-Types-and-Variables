using System;

namespace Sum_Of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string letters = string.Empty;

            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                letters = Console.ReadLine();
                char character = char.Parse(letters);
                int toNumber = Convert.ToInt32(character);
                sum += toNumber;
            }
            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
