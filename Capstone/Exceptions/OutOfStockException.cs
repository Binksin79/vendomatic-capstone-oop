using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Exceptions
{
    public class OutOfStockException : VendingMachineExceptions
    {
        public OutOfStockException(string ex) : base(ex)
        {

        }
        public override string ExceptionMessage
        {
            get
            {
                return "That item is out of stock. Please select a different item.";
            }
        }
    }
}
