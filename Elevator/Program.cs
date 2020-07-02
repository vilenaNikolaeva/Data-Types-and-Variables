using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());

            int courses = people / capacityElevator;
            int extraCourses = people % capacityElevator;

            if (extraCourses != 0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
