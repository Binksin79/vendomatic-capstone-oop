using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class ChipItem : VendingItem
    {
        public ChipItem(string itemName, decimal itemPrice) : base(itemName, itemPrice) { }

        public override string Consume()
        {
            return "Crunch Crunch, Yum!";
        }
    }
}
