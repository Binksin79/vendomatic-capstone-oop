﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        VendingMachineFileReader invoke = new VendingMachineFileReader("vendingmachine.csv");


        public VendingMachine()
        {
            Inventory = invoke.GetInventory();
        }

        public decimal Balance { get; private set; }

        private Dictionary<string, List<VendingItem>> Inventory { get; set; }
        
        public string[] Slots
        {
            get
            {
                string[] slots = new string[Inventory.Count];
                int incrementer = 0;
                foreach (string key in Inventory.Keys)
                {
                    slots[incrementer] = key;
                    incrementer++;
                }
                return slots;
            }
        }


        public void FeedMoney(int dollars)
        {
            Balance += (decimal)dollars;
        }

        public VendingItem GetItemAtSlot(string slot)
        {
            VendingItem itemAtSlot = Inventory[slot][0];
            return itemAtSlot;

        }
        public int GetQuantityRemaining(string slot)
        {
            return Inventory[slot].Count;
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
