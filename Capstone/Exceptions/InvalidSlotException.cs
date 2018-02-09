using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Exceptions
{
    public class InvalidSlotException : VendingMachineExceptions
    {
        public InvalidSlotException() : base("That slot does not exist on this machine. Please select another item.")
        {           
        }
    }
}
