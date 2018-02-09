using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Change
    {
        int nickels = 0;
        int dimes = 0;
        int quarters = 0;
        decimal total;

        public int Nickels { get { return nickels; } }
        public int Dimes { get { return dimes; } }
        public int Quarters { get { return quarters; } }
        public decimal Total { get; }

        public Change(decimal total)
        {
            Total = total;
            this.total = total;
        }

        public string GiveChange()
        {
            decimal totalInCents = total * 100;
            

            while(totalInCents >= 25)
            {
                quarters++;
                totalInCents -= 25;

            }
            while(totalInCents >= 10)
            {
                dimes++;
                totalInCents -= 10;
            }
            while(totalInCents >= 5)
            {
                nickels++;
                totalInCents -= 5;
            }
            string output = $"The change is: {quarters} quarters, {dimes} dimes, and {nickels} nickels.";
            return output;
        }
    }
}

