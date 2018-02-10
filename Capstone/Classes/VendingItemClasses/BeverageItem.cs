using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class BeverageItem : VendingItem
    {
        public BeverageItem(string itemName, decimal itemPrice) : base(itemName, itemPrice)
        {
        }

        public override string Consume()
        {
            return "Glug Glug, Yum!";
        }
    }
}
