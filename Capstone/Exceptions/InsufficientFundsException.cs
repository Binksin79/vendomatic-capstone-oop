using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Exceptions
{
    public class InsufficientFundsException : VendingMachineExceptions
    {
        public InsufficientFundsException() : base("Insufficient funds.  Please add more money.")
        {
        }
    }
}

