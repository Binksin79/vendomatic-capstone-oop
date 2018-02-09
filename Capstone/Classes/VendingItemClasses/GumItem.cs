using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    class GumItem : VendingItem
    {
        public GumItem(string itemName, decimal itemPrice) : base(itemName, itemPrice) { }

        public override string Consume()
        {
            return "Chew Chew, Yum!";
        }
    }
}
