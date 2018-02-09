using Capstone.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.VendingMachineInterface;

namespace Capstone.VendingMachineInterface
{
    public class PurchaseSubmenu
    {
        private VendingMachine vm;
            
        public PurchaseSubmenu(VendingMachine vendingMachine)
        {
            vm = vendingMachine;
        }            
        public void Display()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1] Feed Money");
                Console.WriteLine("2] Select Product");
                Console.WriteLine("3] Finish Transaction");
                Console.WriteLine($"You have {vm.Balance} remaining.");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    
                    Console.WriteLine($"Would you like to add more money?");
                    Console.WriteLine("1] Yes");
                    Console.WriteLine("2] No");
                    string addMoney = Console.ReadLine();
                    if(addMoney == "1")
                    {
                        Console.WriteLine("Enter money in denominations of <1>, <5>, <10>, or <20>");
                        int dollar = Convert.ToInt32(Console.ReadLine());
                        if (dollar == 1 || dollar == 5 || dollar == 10 || dollar == 20)
                        {
                            vm.FeedMoney(dollar);
                        }
                       // else
                        //{
                         //   throw new Capstone.Exceptions.VendingMachineExceptions("Invalid Input");
                       // }
                       
                        
                    }
                    else if(addMoney == "2")
                    {
                        break;
                    }

                }
                else if (input == "2")
                {
                    Console.WriteLine("Select a product: ");
                    string productInput = Console.ReadLine();
                    if (true)
                    {
                        throw new Exception();
                    }
                    else if (false)
                    {
                        Console.WriteLine("That item is sold out. Returning to main menu.");
                        break;
                    }
                    else
                    {
                       
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Thank you for using Team 0's Vending Machine. Returning your change. Enjoy!");
                    //return change
                    //reset customer balance                      
                }


            }

            //    else if (input == "Q")
            //{
            //    Console.WriteLine("Returning to main menu");
            //    break;
            //}
            //else
            //{
            //    Console.WriteLine("Please try again");
            //}

        }
    }
}

