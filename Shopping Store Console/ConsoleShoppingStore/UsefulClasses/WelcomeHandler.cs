using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleShoppingStore;
using Controller;

namespace ConsoleShoppingStore.UsefulClasses
{
   public  class WelcomeHandler
    {
        public void Handler()
        {
            Program pg = new Program();
            string choice;
            ItemManager Im = new ItemManager();
            StartupClass Sc = new StartupClass();
            int Option = Sc.ChooseOption();
            switch(Option)
                {
                case 1:
                            Im.ViewItem();
                    Console.Write("Press any key to Shop...................................................................");
                    Console.ReadLine();
                            Console.Clear();
                            Sc.Welcome();
                            Handler();
                            break;
                case 2:
                            label:
                            Console.Write("Enter Item Number::=>  ");
                            int Item = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Quantity::=>  ");
                            int Qty = Convert.ToInt32(Console.ReadLine());
                            Im.AddItem(Item, Qty);
                            Console.Write("Want to shop more??     [Y/N]    ");
                            choice = Console.ReadLine();
                            if (choice == "Y"|| choice == "y" || choice == "yes"|| choice == "YES")
                            {
                                goto label;
                        
                            }
                    Console.Clear();
                            Sc.Welcome();
                            Handler();
                            break;
                case 3:
                            Im.ModifyItem();
                            break;
                case 4:
                            Console.Write("Input Item No::=>  ");
                            int item = Convert.ToInt32(Console.ReadLine());
                            Im.RemoveItem(item);
                    Console.Clear();
                            Sc.Welcome();
                            Handler();
                    break;
                case 5:
                            Im.ViewBucket();

                    Console.Write("Press any key to Continue...............................................................");
                    Console.ReadLine();
                    Console.Clear();
                            Sc.Welcome();
                            Handler();
                    break;
                case 6:
                            Im.ClearBucket();
                    Console.Write(".....................................................Clearing...........................");
                    Thread.Sleep(2000);
                    Console.Write("[[[[[Bucket Cleaned]]]]]");
                    Thread.Sleep(200);
                    Console.Clear();
                            Sc.Welcome();
                            Handler();
                    break;
                case 7:
                    Environment.Exit(1);
                    break;
            }
        }
    }
}
