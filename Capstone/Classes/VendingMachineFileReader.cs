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
                        temp.Add(line[0], LineIntoList(line));
                    }
                    
                }
            }
            catch (IOException ex) { }
            return temp;
        }

        private List<VendingItem> LineIntoList(string[] line)
        {
            List<VendingItem> result = new List<VendingItem>();
            decimal cost = decimal.Parse(line[2]);

            if (line[0].StartsWith("A"))
            {
                for (int i = 0; i < 5; i++)
                {
                     result.Add(new ChipItem(line[1], cost));
                }             
            }
            else if (line[0].StartsWith("B"))
            {
                for (int i = 0; i < 5; i++)
                {
                    result.Add(new CandyItem(line[1], cost));
                }
                
            }            
            else if (line[0].StartsWith("C"))
            {
                for (int i = 0; i < 5; i++)
                {
                    result.Add(new BeverageItem(line[1], cost));
                }
               
            }
            else if (line[0].StartsWith("D"))
            {
                for (int i = 0; i < 5; i++)
                {
                    result.Add(new GumItem(line[1], cost));
                }               
            }
            return result;
        }
    }
}
