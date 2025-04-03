using System;
using System.Collections.Generic;

namespace FitnessApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running("2025-03-29", 30, 5.0f),
                new Cycling("2025-03-28", 60, 20.0f),
                new Swimming("2025-03-27", 45, 30)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
