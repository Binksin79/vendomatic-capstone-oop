using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        Dictionary<string, string> vendingMachine = new Dictionary<string, string>();
        //public string StockItems()
        //{
        //    stock the dictionary
        //}
        public decimal Balance { get; private set; }
        private Dictionary<string, List<VendingItem>> Inventory()
        {

        }        
        public string[] Slots { get; }

        public void FeedMoney(int dollars)
        {

        }
        public VendingItem GetItemAtSlot (string slot)
        {

        }
        public int GetQuantityRemaining (string slot)
        {

        }
        public VendingItem Purchase (string slot)
        {

        }
        public Change ReturnChange()
        {

        }
        public string SoldOut()
        {

        }



}
}
