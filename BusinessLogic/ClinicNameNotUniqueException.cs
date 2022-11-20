using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ClinicNameNotUniqueException : ApplicationException
    {
        public ClinicNameNotUniqueException(string message) : base(message)
        {

        }
    }
}
