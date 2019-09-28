using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleShoppingStore.UsefulClasses;

namespace ConsoleShoppingStore
{
    public partial class StartupClass
    {
        public void Welcome()
        {
            Console.WriteLine("**********************************POUDEL KIRANA PASAL************************************");
            Console.WriteLine("\nXXXXXXXXXXXXXXXXXX GET YOUR CHOICE  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\n\n");
            Console.WriteLine("1. View Items of our store"); 
            Console.WriteLine("2. Add item to your Bucket");
            Console.WriteLine("3. Modify item in your Bucket");
            Console.WriteLine("4. Remove item from Bucket");
            Console.WriteLine("5. View your Bucket");
            Console.WriteLine("6. Clear your Bucket");
            Console.WriteLine("7. Exit from PASAL\n\n");
        }
    }
    public partial class StartupClass
    {
        public  int choice;
        public int ChooseOption()
        {
            label1:
            Console.Write("################################  ENTER YOUR CHOICE  :::::::::::::::::::::::::::::::::::=>");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("ENTER VALID CHARACTER");
                goto label1;
            }
            return choice;
        }
    }
}
