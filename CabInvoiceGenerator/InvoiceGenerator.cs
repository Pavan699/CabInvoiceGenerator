using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        RideType ride;
        public RideRepository riderepository;

        //Consants
        private double Min_Cost_Per_Ride;
        private int Cost_Per_Time;
        private double Min_Fare;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ride"></param>
        public InvoiceGenerator(RideType ride)
        {
            this.ride = ride;
            this.riderepository = new RideRepository();
            try
            {
                if(ride.Equals(RideType.Premium))
                {
                    this.Min_Cost_Per_Ride = 15;
                    this.Cost_Per_Time = 2;
                    this.Min_Fare = 20;
                }
                else if(ride.Equals(RideType.Normal))
                {
                    this.Min_Cost_Per_Ride = 10;
                    this.Cost_Per_Time = 1;
                    this.Min_Fare = 5;
                }
            }
            catch(CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.CustomExcp.Invalid_RideType, "RideType Is Invalid");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public InvoiceGenerator()
        {

        }
        public double CalculateFare(double distance, int time)
        {
            double Total_Fare = 0;
            try
            {
                Total_Fare = distance * Min_Cost_Per_Ride + time * Cost_Per_Time;
            }
            catch(CabInvoiceException)
            {
                if(ride.Equals(null))
                {
                    throw new CabInvoiceException(CabInvoiceException.CustomExcp.Null_Ride, "Invalid Ride-Type");
                }
                if(distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.CustomExcp.Invalid_Distance, "Distance Is Invalid");
                }
                if(time < 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.CustomExcp.Invalid_Time, "Time Is Invalid");
                }
            }
            return Math.Max(Total_Fare,Min_Fare);
        }
    }
}
