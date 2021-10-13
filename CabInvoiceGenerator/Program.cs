using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.Normal);
            double fare = invoiceGenerator.CalculateFare(50.0, 5);
            Console.WriteLine($"Fare : {fare}");
        }
    }
}
