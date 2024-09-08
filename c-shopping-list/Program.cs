using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_shopping_list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Shopping List Application

            Objectives:
            - Generic Collections
            - Data Processing

            Task:
            Create a shopping list application that uses collections to store item names and prices. The menu of available items will be stored in a Dictionary, and the user's shopping list will be stored in a List.
            */

            //Step 1: Define the menu using a Dictionary<string, decimal> and initialize it with literals (items and their prices).

            Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
            {
                {"apple", 0.99m},
                {"banana", 0.59m},
                {"bread", 2.99m},
                {"milk", 3.49m},
                {"eggs", 1.99m},
                {"cheese", 4.99m},
                {"chicken", 5.99m},
                {"beef", 9.99m},
                {"pork", 7.99m},
                {"fish", 6.99m}
            };

            //Step 2: Create a List<string> to store the user's shopping list.

            List<string> shoppingList = new List<string>();

            //Step 3: Prompt the user for item names and check if the item exists in the menu. If it does, add it to the shopping list and display the price. If it doesn't, show an error message and prompt again.

            //Define input variable and bool for while loop
            string userInput;
            bool moreItems = true;

            Console.WriteLine("Lets Shop!");

            do
            {
                Console.WriteLine("Here are the items for sale");
                Console.WriteLine("\nItem\tPrice");
                foreach (KeyValuePair<string, decimal> item in menu)
                {
                    Console.WriteLine($"{item.Key}\t{item.Value}");
                }

                Console.WriteLine("What would you like to buy? ");
                userInput = Console.ReadLine().ToLower();

                if (menu.ContainsKey(userInput))
                {
                    shoppingList.Add(userInput);
                    Console.WriteLine($"{userInput} added to cart. Price: {menu[userInput]}");
                }
                else
                {
                    Console.WriteLine("Item not found. Please try again.");
                }
                //Step 4: Continue asking if the user wants to add more items, or exit when they are done.
                Console.WriteLine("Would you like to add more items? (y/n)");
                moreItems = Console.ReadLine().ToLower() == "y";//its a bool so make it an argument!

            }
            while (moreItems);


            //Step 5: When finished, display the list of items ordered with their prices, and show the total price.
            decimal totalPrice = 0;
            Console.WriteLine("Here is your shopping list!");
            Console.WriteLine("\nItem\tPrice");
            foreach (string item in shoppingList)
            {
                Console.WriteLine($"{item}\t{menu[item]}");//Looks at the value in the "Key Value" pair - sort of like a vlookup in excel
                totalPrice +=menu[item];
            }
            Console.WriteLine($"Total price for your gorcery list {totalPrice}");

        }//End Main
    }//End Class
}//End NameSpace
