using Capstone.VendingMachineInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    class UserInterface
    {
        private VendingMachine vendingMachine;

        public void Display()
        {
            PrintHeader();

            while (true)
            {
                Console.WriteLine();                
                Console.WriteLine("1] Display Vending Machine Items");
                Console.WriteLine("2] Purchase");
                

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("[[DISPLAY ITEMS]]");
                }
                else if (input == "2")
                {
                    PurchaseSubmenu submenu = new PurchaseSubmenu();
                    submenu.Display();
                }
                else if (input == "Q")
                {
                    Console.WriteLine("Quitting");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
            }
        }

        private void PrintHeader()
        {
            Console.WriteLine("Welcome to the .NET Team 0 Vending Machine!");
        }

        //public void Run();
    }
}
