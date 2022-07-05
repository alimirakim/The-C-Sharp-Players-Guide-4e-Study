using System;
namespace Template;

/// <summary>
/// LEVEL 25: Inheritance 
/// </summary>
public static class Level25
{
  public static void CallAll()
  {
    PackingInventory();
  }

  /// <summary>
  /// Challenge 1/1: Packing Inventory 
  ///<br/> You know you have a long, dangerous journey ahead of you to travel to and repair the Fountain of Objects. To prepare for the trip, you decide to build some classes and objects to manage your inventory.
  ///<br/> 
  ///<br/> You decide to create a `Pack` class to help you in holding your items. Each pack has three limits: the total number of items it can hold, the weight it can carry, and the volume it can hold. Each item has a weight and volume, and you must not overload a pack (too many items, too much weight, or too much volume).
  ///<br/> 
  ///<br/> There are many item types that you might add to your inventory, each their own class in the inventory system:
  ///<br/> (1) An arrow has a weight of 0.1 and a volume of 0.05.
  ///<br/> (2) A bow has a weight of 1 and a volume of 4.
  ///<br/> (3) Rope has a weight of 1 and a volume of 1.5.
  ///<br/> (4) Water has a weight of 2 and a volume of 3.
  ///<br/> (5) Food rations have a weight of 1 and a volume of 0.5.
  ///<br/> (6) A sword has a weight of 5 and a volume of 3.
  ///<br/>  
  ///<br/> OBJECTIVES: 
  ///<br/> [] Create an `InventoryItem` class that represents any of the different item types. This item must represent the item's weight and volume, which it needs at a creation time (constructor).
  ///<br/> [] Create derived classes for each of the types of items above. Each class should pass the correct weight and volume to the base class constructor but should be creatable themselves with a parameterless constructor (for example, `new Rope()` or `new Sword()`).
  ///<br/> [] Build a `Pack` class that can store an array of items. The total number of items, the maximum weight, and the maximum volume are provided at creation time but cannot change afterward.
  ///<br/> [] Make a `public bool Add(InventoryItem item)` method to `Pack` that allows you to add items of any type to the pack's contents. This method should fail (return `false` and not modify the pack's fields) if adding the item would cause it to exceed the pack's item, weight, or volume limit. 
  ///<br/> [] Add properties to `Pack` that allow it to report the current item count, weight, and volume, and the limits of each.
  ///<br/> [] Create a program that creates a new pack and then allow the user to add (or attempt to add) items chosen from a menu.
  /// </summary>
  public static void PackingInventory()
  {
    Utils.WriteTitle("Packing Inventory");


  }
}