using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        
       
        public decimal Balance { get; private set; }
        private Dictionary<string, List<VendingItem>> Inventory()
        {
            /// inventory logger ///
        }        
        public string[] Slots { get; }




        public void FeedMoney(int dollars)
        {
            int dollarsInPennies = dollars * 100;
            customerTotal += dollars;
        }
        public VendingItem GetItemAtSlot (string slot)
        {

        }
        public int GetQuantityRemaining (string slot)
        {

        }
        public VendingItem Purchase(string slot)
        {

        }
        public Change GetChange()
        {

        }
        public string SoldOut()
        {

        }



}
}
