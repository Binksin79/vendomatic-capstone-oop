using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.VendingMachineInterface
{
    class PurchaseSubmenu
    {
        public void Display()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1] Feed Money");
                Console.WriteLine("2] Select Product");
                Console.WriteLine("3] Finish Transaction");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine($"You have {finalBalance} remaining.");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Select a product: ");
                    string productInput = Console.ReadLine();
                    if ()
                    {
                        Console.WriteLine("That item is not stocked. Returning to main menu.");
                        break;
                    }
                    else if ()
                    {
                        Console.WriteLine("That item is sold out. Returning to main menu.");
                        break;
                    }
                    else
                    {
                        //remove that item from the list
                        //subtract the cost from the customer's balance
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Thank you for using Team 0's Vending Machine. Returning your change. Enjoy!");
                    //return change
                    //reset customer balance                      
                }


            }
                else if (input == "Q")
            {
                Console.WriteLine("Returning to main menu");
                break;
            }
            else
            {
                Console.WriteLine("Please try again");
            }

        }
    }
}
}
