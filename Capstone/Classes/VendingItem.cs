using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public abstract class VendingItem
    {
        // properties //

        public string ItemName { get; }
        public decimal ItemPrice { get; }
        
        // constructor //

        public VendingItem (string itemName, decimal itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        // methods //

        public abstract string Consume();
        
            
            
        

    }
}
