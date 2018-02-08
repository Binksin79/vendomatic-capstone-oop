using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class CandyItem : VendingItem
    {
        public CandyItem(string itemName, decimal itemPrice) : base(itemName, itemPrice)
        {
        }

        public override string Consume()
        {
            return "Munch Munch, Yum!";
        }
    }
}
