using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    class TransactionLogger
    {
        private string Filepath { get; }

        public TransactionLogger(string filepath)
        {
            Filepath = filepath;
        }

        public void RecordDeposit(decimal amount, decimal finalBalance)
        {
            //how much money the customer put in with each transaction
            //& how much total money the customer has fed into the machine.

            finalBalance = amount++;
        }
        public decimal RecordPurchase(string slot, string product, decimal initialBal, decimal finalBalance)
        {
            //recording product and slot, provide initial balance, subtract product cost return new final balance
            
        }
        public RecordCompleteTransaction(decimal remainingBalance)
        {
            //adding the final balance to the machine's balance
        }
    }
}
