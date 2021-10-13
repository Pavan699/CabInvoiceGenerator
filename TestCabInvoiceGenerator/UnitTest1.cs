using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace TestCabInvoiceGenerator
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoiceGenerator = null;
        [TestMethod]
        public void CheckingInvoiceGeneratorNormalFare()
        {
            //Create instance of InvoiceGenerator for normal Ride
            invoiceGenerator = new InvoiceGenerator(RideType.Normal);
            double distance = 2;
            int time = 5;

            //Calculate Fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            //Assert
            Assert.AreEqual(expected, fare);
        }

        [TestMethod]
        public void CheckingInvoiceGeneratorPremiumFare()
        {
            //Create instance of InvoiceGenerator for normal Ride
            invoiceGenerator = new InvoiceGenerator(RideType.Premium);
            double distance = 2;
            int time = 5;

            //Calculate Fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 40;

            //Assert
            Assert.AreEqual(expected, fare);
        }

    }
}
