using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string model = "";
            double biggerKeg = 0;
            double result = 0;

            for (int i = 0; i < number; i++)
            {
                string currentModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentResult = Math.PI * Math.Pow(radius, 2) * height;

                if (currentResult > result)
                {
                    result = currentResult;
                    model = currentModel;
                }
            }
            Console.WriteLine(model);

        }
    }
}
