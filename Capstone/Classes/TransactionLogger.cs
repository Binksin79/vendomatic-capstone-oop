using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            //hwhen the customer deposits money, record this

            try
            {
                using (StreamWriter sw = new StreamWriter(Filepath))
                {
                    sw.WriteLine($"{DateTime.Now} FEED MONEY {amount} {finalBalance}");
                }
            }
            catch
            {

            }


        }
        public decimal RecordPurchase(string slot, string product, decimal initialBal, decimal finalBalance)
        {


            //when the customer makes a purchase, record this
            try
            {
                using (StreamWriter sw = new StreamWriter(Filepath))
                {
                    sw.WriteLine($"{DateTime.Now} {product} {slot} {initialBal} {finalBalance}");
                }
            }
            catch
            {

            }
        }
        public RecordCompleteTransaction(decimal remainingBalance)
        {
            // when the customer completes their transaction, record this
            try
            {
                using (StreamWriter sw = new StreamWriter(Filepath))
                {
                    sw.WriteLine($"{DateTime.Now} GIVE CHANGE {remainingBalance}");
                }
            }
            catch
            {

            }


        }


    }
}
