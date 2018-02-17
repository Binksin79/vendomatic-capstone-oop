using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    public class VendingMachineFileReader
    {
        private string Filepath { get; }
        private const int SlotId = 0;
        private const int InitialQuantity = 5;
        private const int Name = 1;
        private const int Cost = 2;

        public VendingMachineFileReader(string filepath)
        {
            Filepath = filepath;
        }

        public Dictionary<string, List<VendingItem>> GetInventory()
        {
            Dictionary<string, List<VendingItem>> temp = new Dictionary<string, List<VendingItem>>();

            try
            {
                using (StreamReader sr = new StreamReader(Filepath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split('|');
                        temp.Add(line[SlotId], LineIntoList(line));
                    }
                    
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("There was an error opening the file: " + ex.Message);
                throw;
            }

            return temp;
        }

        private List<VendingItem> LineIntoList(string[] line)
        {
            List<VendingItem> result = new List<VendingItem>();
            decimal cost = decimal.Parse(line[Cost]);

            if (line[SlotId].StartsWith("A"))
            {
                for (int i = 0; i < InitialQuantity; i++)
                {
                     result.Add(new ChipItem(line[SlotId], cost));
                }             
            }
            else if (line[SlotId].StartsWith("B"))
            {
                for (int i = 0; i < InitialQuantity; i++)
                {
                    result.Add(new CandyItem(line[SlotId], cost));
                }
                
            }            
            else if (line[SlotId].StartsWith("C"))
            {
                for (int i = 0; i < InitialQuantity; i++)
                {
                    result.Add(new BeverageItem(line[SlotId], cost));
                }
               
            }
            else if (line[SlotId].StartsWith("D"))
            {
                for (int i = 0; i < InitialQuantity; i++)
                {
                    result.Add(new GumItem(line[SlotId], cost));
                }               
            }
            return result;
        }
    }
}
