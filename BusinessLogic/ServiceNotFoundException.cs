using System;

namespace BusinessLogic
{
    public class ServiceNotFoundException : ApplicationException
    {
        public ServiceNotFoundException(string message) : base(message)
        {

        }
    }
}
