using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Exceptions
{
    public class InsufficientFundsException : VendingMachineExceptions
    {
        public InsufficientFundsException(string ex) : base(ex)
        {

        }
        public override string ExceptionMessage
        {
            get
                {
                return "Insufficient funds to purchase this item. Please add more money.";
                }
        }
    }
}
