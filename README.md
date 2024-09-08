# Shopping List Application

## Objectives:
- Generic Collections
- Data Processing

## Task:
Create a shopping list application that uses collections to store item names and prices. One collection will store the menu of available items, and another will store the user's shopping list.

## What the Application Will Do:
1. Display a menu with at least 8 item names and their prices.
2. Ask the user to enter an item name.
   - If the item exists, display the item and price, and add it to the user's shopping list.
   - If the item doesn't exist, display an error message and re-prompt the user (you can display the menu again).
3. After adding an item, ask if the user wants to add another item and repeat the process. (The user can enter an item more than once.)
4. When the user is done, display the list of all ordered items with prices.
5. Display the total price of all items ordered.

## Build Specifications:
- **2 Points:** Use a `Dictionary<string, decimal>` to keep track of the menu of items. Code it with literals.
- **1 Point:** Use a `List<string>` for the shopping list and store the names of the items ordered.
- **1 Point:** Respond appropriately if the user enters an item that doesn't exist.
- **1 Point:** Add the item name to the shopping list if it exists.
- **1 Point:** Prompt the user to continue or quit, looping as necessary.
- **2 Points:** Display the list of ordered items with their prices.
- **1 Point:** Calculate and display the correct total receipt by summing the item prices using the shopping list.

## Extended Challenges:
- Implement a menu system where users can enter a letter or number for an item.
- Display the most and least expensive item ordered.
- Display the items in the shopping list in order of price.

## Example Console Preview:

