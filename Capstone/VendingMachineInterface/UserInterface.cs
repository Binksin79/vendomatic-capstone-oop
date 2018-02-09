using Capstone.VendingMachineInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;
using Capstone.Exceptions;


namespace Capstone.VendingMachineInterface
{   
    public class UserInterface
    {
        private VendingMachine vendingMachine = new VendingMachine();
        

        public void Display()
        {
            PrintHeader();

            while (true)
            {
                Console.WriteLine();                
                Console.WriteLine("1] Display Vending Machine Items");
                Console.WriteLine("2] Purchase");
                Console.WriteLine("Press Q to quit");
                
                

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    foreach(var slot in vendingMachine.Slots)
                    {
                        try
                        {
                            Console.WriteLine($"{slot} {vendingMachine.GetItemAtSlot(slot).ItemName} {vendingMachine.GetQuantityRemaining(slot)}");
                        }
                        catch(OutOfStockException ex)
                        {
                            Console.WriteLine($"{slot} - {ex.Message}");
                        }
                    }
                   
                }
                else if (input == "2")
                {
                    PurchaseSubmenu submenu = new PurchaseSubmenu(vendingMachine);
                    
                    submenu.Display();
                    
                }
                else if (input == "Q" || input == "q")
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
