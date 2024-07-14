using System;

class Program
{
    static void Main()
    {
        const double CourseFee = 25000;
        DateTime registrationLastDate = new DateTime(2024, 6, 20);

        Console.WriteLine("Enter subscriber name:");
        string subscriberName = Console.ReadLine();

        Console.WriteLine("Enter subscriber email:");
        string subscriberEmail = Console.ReadLine();

        Console.WriteLine("Enter registration date (yyyy-MM-dd):");
        DateTime registrationDate = DateTime.Parse(Console.ReadLine());

        double discountPercentage = 0;
        if (registrationDate < new DateTime(2024, 6, 10))
        {
            discountPercentage = 0.1; // 10% discount
        }
        else if (registrationDate < new DateTime(2024, 6, 15))
        {
            discountPercentage = 0.15; // 15% discount
        }
        else if (registrationDate > registrationLastDate)
        {
            discountPercentage = -0.05; // 5% late fee
        }

        double totalAmount = CourseFee * (1 - discountPercentage);

        Console.WriteLine();
        Console.WriteLine("Subscriber Details:");
        Console.WriteLine($"Name: {subscriberName}");
        Console.WriteLine($"Email: {subscriberEmail}");
        Console.WriteLine($"Registration Date: {registrationDate.ToShortDateString()}");
        Console.WriteLine($"Course Fee: INR {CourseFee:N2}");
        Console.WriteLine($"Discount Applied: {discountPercentage:P0}");
        Console.WriteLine($"Total Amount to Pay: INR {totalAmount:N2}");
    }
}
