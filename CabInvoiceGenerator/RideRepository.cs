using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        //Dictionary to store UserId and Rides int list
        readonly Dictionary<string, List<Ride>> userRides = null;
        /// <summary>
        /// Constructor to create dictionary.
        /// </summary>
        public RideRepository()
        {
            this.userRides = new Dictionary<string, List<Ride>>();
        }
        /// <summary>
        /// Functions to Adds the ride.
        /// </summary>
        public void AddRide(string userId, Ride[] rides)
        {
            bool rideList = this.userRides.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userRides.Add(userId, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.CustomExcp.Null_Ride, "Rides are null");
            }
        }
        /// <summary>
        /// Function to Gets the rides as an Array for specifies userId.
        /// </summary>
        public Ride[] getRides(string userId)
        {
            bool rideList = this.userRides.ContainsKey(userId);
            try
            {
                return this.userRides[userId].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.CustomExcp.Invalid_User_ID, "Invalid user ID");
            }
        }
    }
}
