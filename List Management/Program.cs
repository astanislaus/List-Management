using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()     //static void Main(string[] args)
        {
            List<string> Groceries = new List<string>();
            string SelectionStr = "";
            string NewItem = "";
            while (SelectionStr !="q")
            {
                Console.Clear();
                DisplayHeader();
                
                //DisplayMenu();


                if (SelectionStr == "+")
                {
                 //   Console.WriteLine("You Entered :    +");
                    Console.WriteLine("Enter item to add :");
                    NewItem = Console.ReadLine();
                    Groceries.Add(NewItem);
                }
                else
                    if (SelectionStr == "-")
                {
                    Console.WriteLine("You Entered :    -");
                    Console.WriteLine("Enter item to remove :");
                    NewItem = Console.ReadLine();
                    Groceries.Remove(NewItem);
                }
                else if (SelectionStr == "--")
                {
                    Console.WriteLine("You Entered :    --");
                    Groceries.Clear();
                }

                else if (SelectionStr == "q")
                {
                    Console.WriteLine("You Entered :    q");
                }
                //  Substring(2)

                // print the full list

                Groceries.ForEach(Console.WriteLine);


                Console.Write("Enter command (+ item, - item, or -- to clear)): ");

                SelectionStr = Console.ReadLine();
            }
            Console.WriteLine("I am exiting because you Entered :    q");
            Console.WriteLine();
            Console.WriteLine("BYE!");
            
            Console.ReadLine();
            // additional code omitted



        }

        public static void DisplayHeader()
        {
            // display header
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("****  Grocery List *******************");
            Console.WriteLine("****  'q' to quit  *******************");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        }


        public static void DisplayMenu()
        { 
            // display the menu
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - View the Menu");
            Console.WriteLine("2 - Exit the Program");

        }
}


}
