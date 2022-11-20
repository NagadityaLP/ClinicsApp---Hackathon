using System;

namespace BusinessLogic
{
    public class LatitudeAndLongitudeNullException : ApplicationException
    {
        public LatitudeAndLongitudeNullException(string msg) : base(msg)
        {

        }
    }
}
