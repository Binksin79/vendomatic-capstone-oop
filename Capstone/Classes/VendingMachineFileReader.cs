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
            
            if (line[0].StartsWith("A"))
            {
                result.Add(new ChipItem(line[1], decimal.Parse(line[2])));
                result.Add(new ChipItem(line[1], decimal.Parse(line[2])));
                result.Add(new ChipItem(line[1], decimal.Parse(line[2])));
                result.Add(new ChipItem(line[1], decimal.Parse(line[2])));
                result.Add(new ChipItem(line[1], decimal.Parse(line[2])));
            }
            else if (line[0].StartsWith("B"))
            {
                result.Add(new CandyItem(line[1], decimal.Parse(line[2])));
                result.Add(new CandyItem(line[1], decimal.Parse(line[2])));
                result.Add(new CandyItem(line[1], decimal.Parse(line[2])));
                result.Add(new CandyItem(line[1], decimal.Parse(line[2])));
                result.Add(new CandyItem(line[1], decimal.Parse(line[2])));
            }            
            else if (line[0].StartsWith("C"))
            {
                result.Add(new BeverageItem(line[1], decimal.Parse(line[2])));
                result.Add(new BeverageItem(line[1], decimal.Parse(line[2])));
                result.Add(new BeverageItem(line[1], decimal.Parse(line[2])));
                result.Add(new BeverageItem(line[1], decimal.Parse(line[2])));
                result.Add(new BeverageItem(line[1], decimal.Parse(line[2])));
            }
            else if (line[0].StartsWith("D"))
            {
                result.Add(new GumItem(line[1], decimal.Parse(line[2])));
                result.Add(new GumItem(line[1], decimal.Parse(line[2])));
                result.Add(new GumItem(line[1], decimal.Parse(line[2])));
                result.Add(new GumItem(line[1], decimal.Parse(line[2])));
                result.Add(new GumItem(line[1], decimal.Parse(line[2])));
            }
            return result;
        }
    }
}
