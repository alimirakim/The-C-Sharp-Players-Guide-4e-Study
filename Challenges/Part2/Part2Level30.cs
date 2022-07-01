

/// <summary>
/// LEVEL 30: Generics 
/// </summary>
public static class Part2Level30
{
  public static void CallAll()
  {
    ColoredItems();
  }

  /// <summary>
  /// Challenge 1/1: Colored Items 
  ///<br/> You have a sword, a bow, and an axe in front of you, defined like this:
  ///<br/> 
  ///<br/> **Sample Code:**
  ///<br/>   public class Sword { }
  ///<br/>   public class Bow { }
  ///<br/>   public class Axe { }
  ///<br/> 
  ///<br/> You want to be able to associate a color with these items (or any item type). You could make `ColoredSword` derived from `Sword` that adds a `Color` property, but doing this for all three item types will be painstaking. Instead, you define a new generic `ColoredItem` class that does this for any item.
  ///<br/> 
  ///<br/> **Objectives:** 
  ///<br/> [] Put the three class definitions above into a new project.
  ///<br/> [] Define a generic class to represent a colored item. It must have properties for the item itself (generic in type) and a `ConsoleColor` associated with it.
  ///<br/> [] Add a `void Display()` method to your colored item type that changes the console's foreground color to the item's color and displays the item in that color.
  ///<br/> [] In your main method, create a new colored item containing a blue sword, a red bow, and a green axe. Display all three items to see each item displayed in its color.
  /// </summary>
  public static void ColoredItems()
  {
    Utils.WriteTitle("Colored Items");


  }
}