using System;
namespace Template;

/// <summary>
/// LEVEL 10: Switches
/// </summary>
public static class Level10
{
    public static void CallAll()
  {
    BuyingInventory();
    DiscountingInventory();
  }

  /// <summary>
  /// Challenge 1/2: Buying Inventory
  ///<br/> It is time to resupply. A nearby outfitter shop has the supplies you need, but it is so disorganized that they cannot sell things to you. "Can't sell if I can't find the price list," Tortuga, the owner, tells you as he turns over and attempts to go back to sleep.
  ///<br/> 
  ///<br/> There's a simple solution: use your programming powers to build something to report the prices of various pieces of equipment, based on the user selection:
  ///<br/> 
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   The following items are available:
  ///<br/>   1 - Rope
  ///<br/>   2 - Torches
  ///<br/>   3 - Climbing Equipment
  ///<br/>   4 - Clean Water
  ///<br/>   5 - Machete
  ///<br/>   6 - Canoe
  ///<br/>   7 - Food Supplies
  ///<br/>   What number do you want to see the price of? 2
  ///<br/>   Torches cost 15 gold.
  ///<br/>   
  ///<br/> You search around the shop and find ledgers that show the following prices for these items: Rope: 10 gold, Torches: 15 gold, Climbing Equipment: 25 gold, Clean Water: 1 gold, Machete: 20 gold, Canoe: 200 gold, Food Supplies: 1 gold.
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Build a program that will show the menu illustrated above.
  ///<br/> [] Ask the user to enter a number from the menu.
  ///<br/> [] Using the information above, use a switch (either type) to show the item's cost.
  /// </summary>
  public static void BuyingInventory()
  {
    Utils.WriteTitle("Buying Inventory");


  }

  // *************************************************************************************************

  /// <summary>
  /// Challenge 2/2: Discounting Inventory
  ///<br/> After sorting through tortugas outfitter shop and making it viable again, Tortuga realizes you've put him back in business. He wants to repay the favor by giving you a 50% discount on anything you buy from him and he wants you to modify your program to reflect that.
  ///<br/> 
  ///<br/> After asking the user for a number, the program should also ask the user for their name. If the name supplied is your name then cut the price in half before reporting it to the user
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Modify your program from before to also ask the user for their name.
  ///<br/> [] If their name equals your name, divide the cost in half.
  /// </summary>
  public static void DiscountingInventory()
  {
    Utils.WriteTitle("Discounting Inventory");


  }

}