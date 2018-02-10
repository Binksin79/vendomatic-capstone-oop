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
            try
            {
                using (StreamWriter sw = new StreamWriter(Filepath, true))
                {
                    sw.WriteLine("{0,-23}{1,-20}{2,-4}{3,7}{4, 9}", $"{DateTime.Now}", "FEED MONEY", "", $"{amount.ToString("C")}", $"{finalBalance.ToString("C")}");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Well, you screwed up somewhere.");
            }
        }

        public decimal RecordPurchase(string slot, string product, decimal initialBal, decimal finalBalance)
        {                       
            try
            {
                using (StreamWriter sw = new StreamWriter(Filepath, true))
                {
                    sw.WriteLine("{0,-23}{1,-20}{2,-4}{3,7}{4, 9}", $"{DateTime.Now}", $"{product}", $"{slot}", $"{initialBal.ToString("C")}", $"{finalBalance.ToString("C")}");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Well, you screwed up somewhere.");
            }
            return finalBalance;
        }

        public decimal RecordCompleteTransaction(decimal remainingBalance)
        {           
            try
            {
                using (StreamWriter sw = new StreamWriter(Filepath, true))
                {
                    sw.WriteLine("{0,-23}{1,-20}{2,-4}{3,7}{4, 9}", $"{DateTime.Now}", "GIVE CHANGE", "", $"{remainingBalance.ToString("C")}", "$0.00");
                }
            }
            catch(IOException)
            {
                Console.WriteLine("Well, you screwed up somewhere.");
            }
            return remainingBalance;
        }
    }
}
