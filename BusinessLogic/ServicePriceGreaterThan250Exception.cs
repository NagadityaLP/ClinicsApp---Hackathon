using System;

namespace BusinessLogic
{
    public class ServicePriceGreaterThan250Exception : ApplicationException
    {
        public ServicePriceGreaterThan250Exception(string message) : base(message)
        {

        }
    }
}
