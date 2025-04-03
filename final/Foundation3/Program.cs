using System;

namespace EventManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create Address instances for events
            Address lectureAddress = new Address("123 Main St", "Springfield", "IL", "USA");
            Address receptionAddress = new Address("456 Elm St", "Metropolis", "NY", "USA");
            Address outdoorAddress = new Address("789 Oak St", "Gotham", "NJ", "USA");

            // Create event instances
            Lecture lecture = new Lecture(
                "Tech Trends 2025",
                "A lecture on emerging technology trends.",
                "2025-05-15",
                "10:00 AM",
                lectureAddress,
                "Dr. Smith",
                100
            );

            Reception reception = new Reception(
                "Networking Reception",
                "An opportunity to network with industry professionals.",
                "2025-05-15",
                "6:00 PM",
                receptionAddress,
                "rsvp@example.com"
            );

            Outdoor outdoor = new Outdoor(
                "Outdoor Concert",
                "An outdoor concert featuring local bands.",
                "2025-06-20",
                "7:00 PM",
                outdoorAddress,
                "Sunny with a chance of clouds"
            );

            // Display details for each event
            Console.WriteLine("Lecture Standard Details:\n" + lecture.GetStandardDetails() + "\n");
            Console.WriteLine("Lecture Full Details:\n" + lecture.GetFullDetails() + "\n");
            Console.WriteLine("Lecture Short Description:\n" + lecture.GetShortDescription() + "\n");

            Console.WriteLine("Reception Standard Details:\n" + reception.GetStandardDetails() + "\n");
            Console.WriteLine("Reception Full Details:\n" + reception.GetFullDetails() + "\n");
            Console.WriteLine("Reception Short Description:\n" + reception.GetShortDescription() + "\n");

            Console.WriteLine("Outdoor Standard Details:\n" + outdoor.GetStandardDetails() + "\n");
            Console.WriteLine("Outdoor Full Details:\n" + outdoor.GetFullDetails() + "\n");
            Console.WriteLine("Outdoor Short Description:\n" + outdoor.GetShortDescription() + "\n");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
