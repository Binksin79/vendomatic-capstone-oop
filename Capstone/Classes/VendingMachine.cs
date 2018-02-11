using Capstone.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        VendingMachineFileReader invoke = new VendingMachineFileReader("vendingmachine.csv");
        TransactionLogger logger = new TransactionLogger("log.txt");

        public VendingMachine()
        {
            Inventory = invoke.GetInventory();
        }

        public decimal Balance { get; private set; } = 0;

        private Dictionary<string, List<VendingItem>> Inventory { get; set; }

        public string[] Slots
        {
            get { return Inventory.Keys.ToArray(); }
        }

        public void FeedMoney(int dollars)
        {
            Balance += dollars;
            logger.RecordDeposit((decimal)dollars, Balance);
        }

        public VendingItem GetItemAtSlot(string slot)
        {
            if (Inventory[slot].Count == 0) { throw new OutOfStockException(); }
            if (Inventory[slot].Count > 0)
            {

                VendingItem itemAtSlot = Inventory[slot][0];
                return itemAtSlot;
            }
            else
            {
                throw new OutOfStockException();
            }
        }

        public int GetQuantityRemaining(string slot)
        {
            return Inventory[slot].Count;
        }

        public VendingItem Purchase(string slot)
        {
            if (!Slots.Contains(slot)) { throw new InvalidSlotException(); }
            if (Balance - GetItemAtSlot(slot).ItemPrice < 0) { throw new InsufficientFundsException(); }
            if (Inventory[slot].Count <= 0) { throw new OutOfStockException(); }

            decimal initialBal = Balance;
            Balance -= GetItemAtSlot(slot).ItemPrice;

            if (Inventory[slot].Count > 0)
            {
                VendingItem temp = Inventory[slot][0];
                Inventory[slot].RemoveAt(0);
                logger.RecordPurchase(slot, GetItemAtSlot(slot).ItemName, initialBal, Balance);
                return temp;
            }
            else
            {
                throw new OutOfStockException();
            }          
        }

        public Change GetChange()
        {
            logger.RecordCompleteTransaction(Balance);
            Change change = new Change(Balance);
            return change;
        }
    }
}
