using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Class for the Custom Exceptions
    /// </summary>
    class CabInvoiceException : Exception
    {
        /// <summary>
        /// Enum Class for excp type
        /// </summary>
        public enum CustomExcp
        {
            Invalid_RideType,
            Invalid_Distance,
            Invalid_Time,
            Null_Ride,
            Invalid_User_ID
        }
        CustomExcp excp;
        /// <summary>
        /// Parameter Constructor 
        /// </summary>
        /// <param name="excp"></param>
        /// <param name="msg"></param>
        public CabInvoiceException(CustomExcp excp,string msg):base (msg)
        {
            this.excp = excp;
        }
    }
}
