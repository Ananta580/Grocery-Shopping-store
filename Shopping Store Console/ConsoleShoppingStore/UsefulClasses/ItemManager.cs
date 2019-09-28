using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace ConsoleShoppingStore.UsefulClasses
{
    public class ItemManager
    {
        int Q;
        static List<ItemClass> UserItem = new List<ItemClass>();
        static List<ItemClass> newList = new List<ItemClass>();

        public void Initializer(List<ItemClass> allList)
        {
            newList = allList;
        }
        public void ViewItem()
        {
            
                foreach (ItemClass item in newList)
                {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                int a = 10 - item.Name.Length;
                Console.Write("Name     : " + item.Name ); for (int j = 0; j < a; j++) { Console.Write(" "); }
                int b = 10 - item.Price.ToString().Length;
                Console.Write("Price    : " +  item.Price); for (int j = 0; j < b; j++) { Console.Write(" "); }
                int c = 10 - item.Quantity.ToString().Length;
                Console.Write("Quantity : " +  item.Quantity); for (int j = 0; j < c; j++) { Console.Write(" "); }
                int d = 10 - item.ItemNumber.ToString().Length;
                Console.WriteLine("Item No: : " + item.ItemNumber);
                }
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }

        public void AddItem(int item,int qty)
        {
            foreach (ItemClass value in newList)
            {
                if (value.Quantity >= qty)
                {
                    if (value.ItemNumber == item)
                    {
                        UserItem.Add(new ItemClass() { Name = value.Name, Brand = value.Brand, Price = value.Price, Quantity = qty, Discount = value.Discount, ItemNumber = value.ItemNumber });

                    }
                }
                else
                {
                    Console.WriteLine("Enter valid quantity");
                    Console.Clear();
                }
            }
            foreach (ItemClass van in newList)
            {
                if (van.ItemNumber == item)
                {
                    van.Quantity = van.Quantity - qty;

                }

            }

        }
        public  void ModifyItem()
        {
            Modifier Mf = new Modifier();
            var(User,List)= Mf.ModifiedItems(UserItem,newList).ToTuple();
            UserItem = User;
            newList = List;
        }
        public void RemoveItem(int item)
        {
            foreach (ItemClass Ic in UserItem.ToList())
            {
                if (Ic.ItemNumber == item)
                {
                    Q = Ic.Quantity;
                    UserItem.Remove(Ic);
                }
            }
            foreach (ItemClass I in newList)
            {
                if (I.ItemNumber == item)
                {
                    I.Quantity = Q + I.Quantity;
                }
            }
        }

        public void ViewBucket()
        {
            foreach (ItemClass item in UserItem)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                int a = 10 - item.Name.Length;
                Console.Write("Name     : " + item.Name); for (int j = 0; j < a; j++) { Console.Write(" "); }
                int b = 10 - item.Price.ToString().Length;
                Console.Write("Price    : " + item.Price); for (int j = 0; j < b; j++) { Console.Write(" "); }
                int c = 10 - item.Quantity.ToString().Length;
                Console.Write("Quantity : " + item.Quantity); for (int j = 0; j < c; j++) { Console.Write(" "); }
                int d = 10 - item.ItemNumber.ToString().Length;
                Console.WriteLine("Item No: : " + item.ItemNumber);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }

        public void ClearBucket()
        {
            UserItem.Clear();
        }
    }
}