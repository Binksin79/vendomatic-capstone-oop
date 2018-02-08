using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Change
    {
        public int Nickels { get; }
        public int Dimes { get; }
        public int Quarters { get; }
        public decimal Total { get; }

        public Change(decimal total)
        {
            
            Total = total;
            total = total * 100;
            if (total % 25 == 0)
            {
                // quarters = total / 25;
            }
            else if (total % 25 > 0)
            {
                // quarters = (total / 25);
                // total = total - (25 * quarters);
                if (total % 10 == 0)
                {
                    // dimes = total / 10;
                }
                else if (total % 10 > 0)
                {
                    // dimes = total / 10;
                    // total = total - (10 * dimes);
                    // nickels = total / 5;
                }
            }



        }


    }
}
