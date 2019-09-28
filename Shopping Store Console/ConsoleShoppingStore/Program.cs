using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using ConsoleShoppingStore.UsefulClasses;
namespace ConsoleShoppingStore
{
    class Program
    {

        static ItemClass Ic = new ItemClass();
        static void Main(string[] args)
        {
            Ic.SetDetails();
            StartupClass Sc = new StartupClass();
            WelcomeHandler Wh = new WelcomeHandler();
            ItemManager Im = new ItemManager();
            List<ItemClass> AllList = Ic.Details().ToList();
            Im.Initializer(AllList);
            Sc.Welcome();
            Wh.Handler();
            Console.ReadLine();
        }
        

    }
}
