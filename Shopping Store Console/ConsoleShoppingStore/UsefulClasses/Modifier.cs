using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace ConsoleShoppingStore.UsefulClasses
{
    
    public class Modifier
    {
        int Q;
        static List<ItemClass> AllList = new List<ItemClass>();
        static List<ItemClass> newList = new List<ItemClass>();

        public (List<ItemClass>,List<ItemClass>) ModifiedItems(List<ItemClass> items, List<ItemClass> allitems)
        {
           newList = items.ToList();
           AllList = allitems.ToList();

            StartupClass Sc = new StartupClass();
            WelcomeHandler Wh = new WelcomeHandler();
        label:
            Console.WriteLine("                                         Your List                                           ");
            foreach (ItemClass item in newList)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                int a = 10 - item.Name.Length;
                Console.Write("Name     : " + item.Name); for (int j = 0; j < a; j++) { Console.Write(" "); }
                int b = 10 - item.Price.ToString().Length;
                Console.Write("Price    : " + item.Price); for (int j = 0; j < b; j++) { Console.Write(" "); }
                int c = 10 - item.Quantity.ToString().Length;
                Console.Write("Quantity : " + item.Quantity); for (int j = 0; j < c; j++) { Console.Write(" "); }
                int d = 10 - item.ItemNumber.ToString().Length;
                Console.WriteLine("Item No: : " + item.ItemNumber);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            
            
            Console.WriteLine(" 1.Add Quantity Of Item:");
            Console.WriteLine(" 2.Remove Item:");
            Console.WriteLine(" 3.Reduce Quantity Of Item:");
            Console.WriteLine(" 4.<=Go Back:");
            Console.Write(" ENTER YOUR CHOICE::=>  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    Console.Write(" ENTER ITEM NUMBER::=>  ");
                    int itemed = Convert.ToInt32(Console.ReadLine());
                    Console.Write("--How Much Quantity to be Add--");
                    int qty = Convert.ToInt32(Console.ReadLine());
                    AddQuantity(itemed, qty);
                    Console.Clear();
                    goto label;
                case 2:

                    Console.Write(" ENTER ITEM NUMBER::=>  ");
                    int itemeds = Convert.ToInt32(Console.ReadLine());
                    RemoveItem(itemeds);
                    goto label;
                case 3:

                    Console.Write(" ENTER ITEM NUMBER::=>  ");
                    int iteme = Convert.ToInt32(Console.ReadLine());
                    Console.Write("--How Much Quantity to Reduce--");
                    int qt = Convert.ToInt32(Console.ReadLine());
                    ReduceQuantity(iteme, qt);
                    goto label;
                case 4:
                    Console.Clear();
                    Sc.Welcome();
                    Wh.Handler();
                    break;

            }
            return (newList,AllList);
        }
        public  void AddQuantity(int item,int qty)
        {
            foreach (ItemClass Ic in newList)
            {
                if(Ic.ItemNumber==item)
                {
                    Ic.Quantity = qty + Ic.Quantity;
                }

            }
            foreach (ItemClass I in AllList)
            {
                if (I.ItemNumber == item)
                {
                    I.Quantity = I.Quantity - qty; ;
                }
            }
        }
        public void  RemoveItem(int item)
        {
            
            foreach (ItemClass Ic in newList)
            {
                if (Ic.ItemNumber == item)
                {
                    Q = Ic.Quantity;
                    newList.Remove(Ic);
                    
                }
            }
            foreach (ItemClass I in AllList)
            {
                if (I.ItemNumber == item)
                {
                    I.Quantity = Q + I.Quantity;
                }
            }
        }
        public void  ReduceQuantity(int item, int qty)
        {
            foreach (ItemClass Ic in newList)
            {
                if (Ic.ItemNumber == item)
                {
                    Ic.Quantity = Ic.Quantity - qty;

                }
            }
            foreach (ItemClass I in AllList)
            {
                if (I.ItemNumber == item)
                {
                    I.Quantity = qty + I.Quantity;
                }
            }
        }
    }
}
