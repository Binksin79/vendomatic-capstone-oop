using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Exceptions
{
    public class OutOfStockException : VendingMachineExceptions
    {
        public OutOfStockException() : base("That item is SOLD OUT")
        {
        }
    }
}
