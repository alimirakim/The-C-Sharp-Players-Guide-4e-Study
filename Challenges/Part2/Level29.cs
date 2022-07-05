using System;
namespace Template;

/// <summary>
/// LEVEL 29: Records
/// </summary>
public static class Level29
{
  public static void CallAll()
  {
    WarPreparations();
  }

  /// <summary>
  /// Challenge 1/1: War Preparations 
  ///<br/> As you pass through the city of Rocaard, two blacksmiths, Cygnus and Lyra, approach you. "We know where this is headed. A confrontation with the Uncoded One's forces," Lyra says. Cygnus continues, "You're going to need an army at your side--one prepared to do battle. We forge swords, and we will do everything we can to support your cause." Lyra interjects, "*Our* cause. We need the Power of Programming to flow unfettered too. We want to help. But we're only going to be able to equip an army if you can help us build a program to aid in crafting swords." They describe the program that would help speed up their sword forging, and you dive in to help.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Swords can be made out of any of the following materials: wood, bronze, iron, steel, and the rare binarium. Create an enumeration to represent the material type.
  ///<br/> [] Swords can have a gemstone attached to them that, through Cygnus and Lyra's touch, give them strange powers. Gemstone types include emerald, amber, sapphire, diamond, and the rare bitstone, but not all swords will have a gemstone attached. Create an enumeration to represent gemstone type (or lack thereof).
  ///<br/> [] Create a `Sword` record, which defines a sword by its material, gemstone, length, and crossguard width.
  ///<br/> [] In your main program, create a basic `Sword` instance made out of iron and with no gemstone. Then create two variations on the basic sword with `with` expressions.
  ///<br/> [] Display all three sword instances on the command line with code like `Console.WriteLine(original);`.
  /// </summary>
  public static void WarPreparations()
  {
    Utils.WriteTitle("War Preparations");


  }

}