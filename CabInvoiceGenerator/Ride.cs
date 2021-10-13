using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Class to decalre the variables and set data for a ride
    /// </summary>
    public class Ride
    {
        //Variable declaration
        public double distance;
        public int time;

        /// <summary>
        /// Constructor for the Ride class to set the data
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Ride(double distance,int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
    
}
