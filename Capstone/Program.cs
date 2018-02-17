using Capstone.Classes;
using Capstone.VendingMachineInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserInterface ui = new UserInterface();
                ui.Display();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error operating the vending machine. Out of service.");
            }
        }
    }
}
