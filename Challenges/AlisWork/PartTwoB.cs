
using System;
using static System.Console;

namespace Complete;

public static class PartTwoB
{
  // UTILITY
  public static void WriteTitle(string title)
  {
    string divider = "";
    for (int i = 0; i < title.Length; i++)
      divider += "-";

    Console.WriteLine("");
    Console.WriteLine(title);
    Console.WriteLine(divider);
  }

  public static void CallAll()
  {
    PackingInventory();
    LabelingInventory();
    TheOldRobot();
    RoboticInterface();
    RoomCoordinates();
    WarPreparations();
    ColoredItems();
  }

  // *************************************************************************************************

  public class InventoryItem
  {
    public float Weight { get; }
    public float Volume { get; }

    public InventoryItem(float weight, float volume)
    {
      Weight = weight;
      Volume = volume;
    }

    public void WriteItem()
    {
      Console.Write($"{ToString(),-16}");
      Console.Write($"Volume: {$"{Volume:0.00}",-8}");
      Console.WriteLine($"Weight: {$"{Weight:0.0}lb",-8}");
    }

  }

  public class Arrow : InventoryItem
  {
    public Arrow() : base((float)0.1, (float)0.05) { }
    public override string ToString() => "Arrow";
  }

  public class Bow : InventoryItem
  {
    public Bow() : base(1, 4) { }
    public override string ToString() => "Bow";
  }

  public class Rope : InventoryItem
  {
    public Rope() : base(1, (float)1.5) { }
    public override string ToString() => "Rope";
  }
  public class Water : InventoryItem
  {
    public Water() : base(2, 3) { }
    public override string ToString() => "Water";
  }
  public class FoodRations : InventoryItem
  {
    public FoodRations() : base(1, (float)0.5) { }
    public override string ToString() => "FoodRations";
  }
  public class Sword : InventoryItem
  {
    public Sword() : base(5, 3) { }
    public override string ToString() => "Sword";
  }

  public class Pack
  {
    public InventoryItem[] Items { get; init; } = new InventoryItem[1];
    public int MaxCapacity { get; }
    public float MaxWeight { get; }
    public float MaxVolume { get; }
    public int ItemCount
    {
      get
      {
        for (int i = 0; i < Items.Length; i++)
          if (Items[i] == null) return i + 1;
        return Items.Length;
      }
    }
    public float Weight
    {
      get
      {
        float sumWeight = 0;
        for (int i = 0; i < Items.Length; i++)
        {
          if (Items[i] == null) return sumWeight;
          sumWeight += Items[i].Weight;
        }
        return sumWeight;
      }
    }
    public float Volume
    {
      get
      {
        float sumVolume = 0;
        for (int i = 0; i < Items.Length; i++)
        {
          if (Items[i] == null) return sumVolume;
          sumVolume += Items[i].Volume;
        }

        return sumVolume;
      }
    }

    public Pack(int maxCapacity, float maxWeight, float maxVolume)
    {
      Items = new InventoryItem[maxCapacity];
      MaxCapacity = maxCapacity;
      MaxWeight = maxWeight;
      MaxVolume = maxVolume;
    }

    public override string ToString()
    {
      string items = "";
      foreach (InventoryItem item in Items)
        if (item != null) items += item.ToString() + " ";
      return $"Pack {{ {items}}}";
    }

    public bool Add(InventoryItem item)
    {

      for (int i = 0; i < Items.Length; i++)
      {
        bool isItemLightEnough = Weight + item.Weight <= MaxWeight;
        bool isItemSmallEnough = Volume + item.Volume <= MaxVolume;
        if (Items[i] == null && isItemLightEnough && isItemSmallEnough)
        {
          Items[i] = item;
          return true;
        }
      }

      return false;
    }

    public void WritePackMaxAllowance() => Console.WriteLine($"Max Capacity: {MaxCapacity} Max Volume: {MaxVolume:0.00} Weight: {MaxWeight:0.0}");

    public void WritePackState() => Console.WriteLine($"{$"Item Slots: {ItemCount}/{MaxCapacity}",-18} Volume: {$"{Volume:0.00}",-8} Weight: {$"{Weight:0.0}lb",-8}");

    public void WritePackContents()
    {
      WritePackMaxAllowance();
      WritePackState();

      for (int i = 0; i < Items.Length; i++)
      {
        Console.Write(i + 1);
        Console.Write(". ");
        if (Items[i] != null) Items[i].WriteItem();
        else Console.WriteLine("(Empty Slot) ");
      }
    }

    public bool PromptAddPack()
    {
      Console.WriteLine(ToString());
      Console.Write("Choose an item number to add to your pack: ");
      InventoryItem? pickedItem = Convert.ToInt32(Console.ReadLine()) switch
      {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new FoodRations(),
        6 => new Sword(),
        _ => null
      };
      if (pickedItem != null)
      {
        bool isAdded = Add(pickedItem);
        if (isAdded)
        {
          Console.WriteLine($"Successfully added! \n");
          WritePackState();
        }
        else Console.WriteLine("The pack is too full! ");
        return true;
      }
      else
      {
        Console.WriteLine("Finished packing. ");
        return false;
      }
    }

    public void PromptFillPack()
    {
      WritePackContents();

      Console.WriteLine("Time to fill up your pack! Here are your options: ");
      Console.WriteLine(@$"
      1. Arrow
      2. Bow
      3. Rope
      4. Water
      5. Food Rations
      6. Sword
      Press any other number to quit.
      ");

      bool isActive = true;

      while (isActive && ItemCount < MaxCapacity && Volume < MaxVolume && Weight < MaxWeight)
      {
        isActive = PromptAddPack();
      }
      Console.WriteLine("\nCongrats, you've filled up your pack! ");

      WritePackContents();
    }
  }

  ///<summary>
  /// LEVEL 25: Inheritance 
  /// Challenge 1/1: Packing Inventory 
  /// You know you have a long, dangerous journey ahead of you to travel to and repair the Fountain of Objects. To prepare for the trip, you decide to build some classes and objects to manage your inventory.
  /// 
  /// You decide to create a `Pack` class to help you in holding your items. Each pack has three limits: the total number of items it can hold, the weight it can carry, and the volume it can hold. Each item has a weight and volume, and you must not overload a pack (too many items, too much weight, or too much volume).
  /// 
  /// There are many item types that you might add to your inventory, each their own class in the inventory system:
  /// (1) An arrow has a weight of 0.1 and a volume of 0.05.
  /// (2) A bow has a weight of 1 and a volume of 4.
  /// (3) Rope has a weight of 1 and a volume of 1.5.
  /// (4) Water has a weight of 2 and a volume of 3.
  /// (5) Food rations have a weight of 1 and a volume of 0.5.
  /// (6) A sword has a weight of 5 and a volume of 3.
  ///  
  /// **Objectives:** 
  /// [x] Create an `InventoryItem` class that represents any of the different item types. This item must represent the item's weight and volume, which it needs at a creation time (constructor).
  /// [x] Create derived classes for each of the types of items above. Each class should pass the correct weight and volume to the base class constructor but should be creatable themselves with a parameterless constructor (for example, `new Rope()` or `new Sword()`).
  /// [x] Build a `Pack` class that can store an array of items. The total number of items, the maximum weight, and the maximum volume are provided at creation time but cannot change afterward.
  /// [x] Make a `public bool Add(InventoryItem item)` method to `Pack` that allows you to add items of any type to the pack's contents. This method should fail (return `false` and not modify the pack's fields) if adding the item would cause it to exceed the pack's item, weight, or volume limit. 
  /// [x] Add properties to `Pack` that allow it to report the current item count, weight, and volume, and the limits of each.
  /// [x] Create a program that creates a new pack and then allow the user to add (or attempt to add) items chosen from a menu.
  /// </summary>
  public static void PackingInventory()
  {
    WriteTitle("Packing Inventory");

    new Pack(10, 10, 10).PromptFillPack();

  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 26: Polymorphism 
  /// Challenge 1/2: Labeling Inventory 
  /// You realize that your inventory items are not easy to sort through. If you could make it easy to label all of your inventory items, it would be easier to know what items you have in your pack.
  /// 
  /// Modify your inventory program from the previous level as described below.
  /// 
  /// **Objectives:** 
  /// [x] Override `ToString` on all of your inventory item subclasses to give them a name. For example, `new Rope().ToString()` should return "Rope".
  /// [x] Override `ToString` on the `Pack` class to display the contents of the pack. If a pack contains water, rope, and two arrows, then calling `ToString` on that `Pack` object should look something like "Pack containing Water Rope Arrow Arrow".
  /// [x] Before the user chooses the next item to add, display the pack's current contents via its new `ToString` method.
  /// </summary>
  public static void LabelingInventory()
  {
    WriteTitle("Labeling Inventory");


  }

  // *************************************************************************************************

  public class Robot
  {
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
    public bool IsPowered { get; set; } = false;
    public RobotCommand[] Commands { get; } = new RobotCommand[3];
    public void Run()
    {
      foreach (RobotCommand command in Commands)
      {
        command.Run(this);
        Console.WriteLine($"[{X} {Y} {IsPowered}]");
      }
    }

    public void PromptAddCommands()
    {
      int commandIndex = 0;

      Console.WriteLine(@"What 3 commands should I add?
        on
        off
        north
        east
        south
        west");
      while (commandIndex < 3)
      {
        RobotCommand? commandChoice = Console.ReadLine() switch
        {
          "on" => new OnCommand(),
          "off" => new OffCommand(),
          "north" => new NorthCommand(),
          "east" => new EastCommand(),
          "south" => new SouthCommand(),
          "west" => new WestCommand(),
          _ => null,
        };

        if (commandChoice != null)
        {
          Commands[commandIndex] = commandChoice;
          commandIndex++;
        }
      }
    }

    public void SetCommands(RobotCommand command1, RobotCommand command2, RobotCommand command3)
    {
      Commands[1] = command1;
      Commands[2] = command2;
      Commands[3] = command3;
    }
  }

  public abstract class RobotCommand
  {
    public abstract void Run(Robot robot);
  }

  public class OnCommand : RobotCommand
  {
    public override void Run(Robot robot) => robot.IsPowered = true;
  }

  public class OffCommand : RobotCommand
  {
    public override void Run(Robot robot) => robot.IsPowered = false;
  }

  public class NorthCommand : RobotCommand
  {
    public override void Run(Robot robot) => robot.Y += (robot.IsPowered ? 1 : 0);
  }

  public class SouthCommand : RobotCommand
  {
    public override void Run(Robot robot) => robot.X -= (robot.IsPowered ? 1 : 0);
  }

  public class WestCommand : RobotCommand
  {
    public override void Run(Robot robot) => robot.X -= (robot.IsPowered ? 1 : 0);
  }

  public class EastCommand : RobotCommand
  {
    public override void Run(Robot robot) => robot.X += robot.IsPowered ? 1 : 0;
  }

  ///<summary>
  /// LEVEL 26: Polymorphism 
  /// Challenge 2/2: The Old Robot 
  /// You spot something shiny, half-buried in the mud. You pull it out and realize that it seems to be some mechanical automaton with the words "Property of Dynamak" etched onto it. As you knock off the caked-on mud, you realize that it seems like this old automaton might even be programmable if you can give it the proper commands. The automaton seems to be structured like this:
  /// 
  /// **Sample Code:**
  ///   public class Robot
  ///   {
  ///     public int X { get; set; }
  ///     public int Y { get; set; }
  ///     public bool IsPowered { get; set; }
  ///     public RobotCommand[] Commands { get; } = new RobotCommand[3];
  ///     public void Run()
  ///     {
  ///       foreach (RobotCommand command in Commands)
  ///       {
  ///         command.Run(this);
  ///         Console.WriteLine($"[{X} {Y} {IsPowered}]");
  ///       }
  ///     }
  ///   }
  /// 
  /// You don't see a definition of that `RobotCommand` class. Still, you think you might be able to recreate it (some class with only an abstract `Run` command) and then make derived classes that extend `RobotCommand` that move it in each of the four directions and power it on and off. (You wish you could manufacture a whole army of these!)
  /// 
  /// **Objectives:** 
  /// [x] Copy the code above into a new project.
  /// [x] Create a `RobotCommand` class with a public and abstract `void Run(Robot robot)` method. (The code above should compile after this step.)
  /// [x] Make `OnCommand` and `OffCommand` classes that inherit from `RobotCommand` and turn the robot on or off.
  /// [x] Make a `NorthCommand`, `SouthCommand`, `WestCommand`, and `EastCommand` that move the robot 1 unit in the +Y direction, 1 unit in the -Y direction, 1 unit in the -X direction, and 1 unit in the +X direction, respectively. Also, ensure that these commands only work if the robot's `IsPowered` property is `true`.
  /// [x] Make your main method able to collect three commands from the console window. Generate new `RobotCommand` objects based on the text entered. After filling the robot's command set with these new `RobotCommand` objects, use the robot's `Run` method to execute them. For example:
  /// **Sample Program:**
  ///   on
  ///   north
  ///   west
  ///   
  ///   [0 0 True]
  ///   [0 1 True]
  ///   [-1 1 True]
  /// - Note: You might find this strategy for making commands that update other objects useful in some of the larger challenges in the coming levels.
  /// 
  /// </summary>
  public static void TheOldRobot()
  {
    WriteTitle("The Old Robot");

    Robot robot = new Robot();
    Console.WriteLine(robot);
    robot.PromptAddCommands();
    robot.Run();
  }

  // *************************************************************************************************

  public interface IRobotCommand
  {
    void Run(ARobot robot);
  }

  public class ARobot
  {
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
    public bool IsPowered { get; set; } = false;
    public IRobotCommand[] Commands { get; } = new IRobotCommand[3];
    public void Run()
    {
      foreach (IRobotCommand command in Commands)
      {
        command.Run(this);
        Console.WriteLine($"[{X} {Y} {IsPowered}]");
      }
    }

    public void PromptAddCommands()
    {
      int commandIndex = 0;

      Console.WriteLine(@"What 3 commands should I add?
        on
        off
        north
        east
        south
        west");
      while (commandIndex < 3)
      {
        IRobotCommand? commandChoice = Console.ReadLine() switch
        {
          "on" => new OnCommand2(),
          "off" => new OffCommand2(),
          "north" => new NorthCommand2(),
          "east" => new EastCommand2(),
          "south" => new SouthCommand2(),
          "west" => new WestCommand2(),
          _ => null,
        };

        if (commandChoice != null)
        {
          Commands[commandIndex] = commandChoice;
          commandIndex++;
        }
      }
    }
  }

  public class OnCommand2 : IRobotCommand
  {
    public void Run(ARobot robot) => robot.IsPowered = true;
  }

  public class OffCommand2 : IRobotCommand
  {
    public void Run(ARobot robot) => robot.IsPowered = false;
  }

  public class NorthCommand2 : IRobotCommand
  {
    public void Run(ARobot robot) => robot.Y += (robot.IsPowered ? 1 : 0);
  }

  public class SouthCommand2 : IRobotCommand
  {
    public void Run(ARobot robot) => robot.X -= (robot.IsPowered ? 1 : 0);
  }

  public class WestCommand2 : IRobotCommand
  {
    public void Run(ARobot robot) => robot.X -= (robot.IsPowered ? 1 : 0);
  }

  public class EastCommand2 : IRobotCommand
  {
    public void Run(ARobot robot) => robot.X += robot.IsPowered ? 1 : 0;
  }

  ///<summary>
  /// LEVEL 27: Interfaces
  /// Challenge 1/1: Robotic Interface 
  /// With your knowledge of interfaces, you realize you can refine the old robot you found in the mud to use interfaces instead of the original design. Instead of an abstract `RobotCommand` base class, it could become an `IRobotCommand` interface!
  /// 
  /// Building on your solution to the Old Robot challenge, perform the changes below:
  /// 
  /// **Objectives:** 
  /// [x] Change your abstract `RobotCommand` class into an `IRobotCommand` interface.
  /// [x] Remove the unnecessary `public` and `abstract` keywords from the `Run` method.
  /// [x] Change the `Robot` class to use `IRobotCommand` instead of `RobotCommand`.
  /// [x] Make all of your commands implement this new interface instead of extending the `RobotCommand` class that no longer exists. You will also want to remove the `override` keywords in these classes.
  /// [x] Ensure your program still compiles and runs.
  /// [x] Answer this question: Do you feel this is an improvement over using an abstract base class? Why or why not?
  /// </summary>
  public static void RoboticInterface()
  {
    WriteTitle("Robotic Interface");

    ARobot aRobot = new ARobot();
    Console.WriteLine(aRobot);
    aRobot.PromptAddCommands();
    aRobot.Run();
  }

  // *************************************************************************************************

  public struct Coordinate
  {
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
      Row = row;
      Column = column;
    }

    public bool CheckIsAdjacent(Coordinate coordinate)
    {
      bool isRowOrColumnSame = coordinate.Row == Row || coordinate.Column == Column;
      bool isRowAdjacent = coordinate.Row == Row + 1 || coordinate.Row == Row - 1;
      bool isColumnAdjacent = coordinate.Column == Column + 1 || coordinate.Column == Column - 1;
      if (isRowOrColumnSame && isRowAdjacent ^ isColumnAdjacent) return true;
      else return false;
    }
  }

  ///<summary>
  /// LEVEL 28: Structs
  /// Challenge 1/1: Room Coordinates 
  /// The time to enter the Fountain of Objects draws closer. While you don't know what to expect, you have found some scrolls that describe the area in ancient times. It seems to be structured as a set of rooms in a grid-like arrangement.
  /// 
  /// Locations of the room may be represented as a row and column, and you take it upon yourself to try to capture this concept with a new struct definition.
  /// 
  /// **Objectives:** 
  /// [x] Create a `Coordinate` struct that can represent a room coordinate with a row and column.
  /// [x] Ensure `Coordinate` is immutable.
  /// [x] Make a method to determine if one coordinate is adjacent to another (differing only by a single row or a single column).
  /// [x] Write a main method that creates a few coordinates and determines if they are adjacent to each other to prove that it is working correctly.
  /// </summary>
  public static void RoomCoordinates()
  {
    WriteTitle("Room Coordinates");

    Coordinate coordA = new Coordinate(1, 1);
    Coordinate coordB = new Coordinate(1, 2);
    Coordinate coordC = new Coordinate(2, 2);
    Coordinate coordD = new Coordinate(3, 2);
    Coordinate coordE = new Coordinate(0, 1);
    Coordinate coordF = new Coordinate(1, 0);

    Console.WriteLine($"{nameof(coordA)} is adjacent to {nameof(coordA)}? {coordA.CheckIsAdjacent(coordA)}");
    Console.WriteLine($"{nameof(coordA)} is adjacent to {nameof(coordB)}? {coordA.CheckIsAdjacent(coordB)}");
    Console.WriteLine($"{nameof(coordA)} is adjacent to {nameof(coordC)}? {coordA.CheckIsAdjacent(coordC)}");
    Console.WriteLine($"{nameof(coordA)} is adjacent to {nameof(coordD)}? {coordA.CheckIsAdjacent(coordD)}");
    Console.WriteLine($"{nameof(coordA)} is adjacent to {nameof(coordE)}? {coordA.CheckIsAdjacent(coordE)}");
    Console.WriteLine($"{nameof(coordA)} is adjacent to {nameof(coordF)}? {coordA.CheckIsAdjacent(coordF)}");
  }


  // *************************************************************************************************

  public enum SwordMaterial { Wood, Bronze, Iron, Steel, Binarium }
  public enum SwordGemstone { None, Emerald, Amber, Sapphire, Diamond, Bitstone }

  public record RSword(SwordMaterial Material, SwordGemstone Gemstone, int Length = 20, int CrossguardWidth = 5);


  ///<summary>
  /// LEVEL 29: Records 
  /// Challenge 1/1: War Preparations 
  /// As you pass through the city of Rocaard, two blacksmiths, Cygnus and Lyra, approach you. "We know where this is headed. A confrontation with the Uncoded One's forces," Lyra says. Cygnus continues, "You're going to need an army at your side--one prepared to do battle. We forge swords, and we will do everything we can to support your cause." Lyra interjects, "*Our* cause. We need the Power of Programming to flow unfettered too. We want to help. But we're only going to be able to equip an army if you can help us build a program to aid in crafting swords." They describe the program that would help speed up their sword forging, and you dive in to help.
  /// 
  /// **Objectives:** 
  /// [x] Swords can be made out of any of the following materials: wood, bronze, iron, steel, and the rare binarium. Create an enumeration to represent the material type.
  /// [x] Swords can have a gemstone attached to them that, through Cygnus and Lyra's touch, give them strange powers. Gemstone types include emerald, amber, sapphire, diamond, and the rare bitstone, but not all swords will have a gemstone attached. Create an enumeration to represent gemstone type (or lack thereof).
  /// [x] Create a `Sword` record, which defines a sword by its material, gemstone, length, and crossguard width.
  /// [x] In your main program, create a basic `Sword` instance made out of iron and with no gemstone. Then create two variations on the basic sword with `with` expressions.
  /// [x] Display all three sword instances on the command line with code like `Console.WriteLine(original);`.
  /// </summary>
  public static void WarPreparations()
  {
    WriteTitle("War Preparations");

    RSword basicSword = new RSword(SwordMaterial.Iron, SwordGemstone.None);
    RSword galaxyBrainSword = basicSword with { Material = SwordMaterial.Binarium };
    RSword fancySword = basicSword with { Material = SwordMaterial.Bronze, Gemstone = SwordGemstone.Amber };

    Console.WriteLine(basicSword);
    Console.WriteLine(galaxyBrainSword);
    Console.WriteLine(fancySword);

  }

  // *************************************************************************************************

  public class GSword { public override string ToString() { return "Sword"; } }
  public class GBow { public override string ToString() { return "Bow"; } }
  public class GAxe { public override string ToString() { return "Axe"; } }

  public class ColoredItem<T>
  {
    ConsoleColor Color { get; }

    public ColoredItem(ConsoleColor color)
    {
      Color = color;
    }

    public void Display()
    {
      Console.ForegroundColor = Color;
      // TODO Why does this not work Greeeeem :C 
      Console.WriteLine(this.ToString());
      Console.ResetColor();
    }
  }

  ///<summary>
  /// LEVEL 30: Generics 
  /// Challenge 1/1: Colored Items 
  /// You have a sword, a bow, and an axe in front of you, defined like this:
  /// 
  /// **Sample Code:**
  ///   public class Sword { }
  ///   public class Bow { }
  ///   public class Axe { }
  /// 
  /// You want to be able to associate a color with these items (or any item type). You could make `ColoredSword` derived from `Sword` that adds a `Color` property, but doing this for all three item types will be painstaking. Instead, you define a new generic `ColoredItem` class that does this for any item.
  /// 
  /// **Objectives:** 
  /// [x] Put the three class definitions above into a new project.
  /// [x] Define a generic class to represent a colored item. It must have properties for the item itself (generic in type) and a `ConsoleColor` associated with it.
  /// [x] Add a `void Display()` method to your colored item type that changes the console's foreground color to the item's color and displays the item in that color.
  /// [x] In your main method, create a new colored item containing a blue sword, a red bow, and a green axe. Display all three items to see each item displayed in its color.
  /// </summary>
  public static void ColoredItems()
  {
    WriteTitle("Colored Items");

    ColoredItem <GSword> blueSword = new ColoredItem<GSword>(ConsoleColor.DarkBlue);
    ColoredItem<GBow> redBow = new ColoredItem<GBow>(ConsoleColor.DarkRed);
    ColoredItem<GAxe> greenAxe = new ColoredItem<GAxe>(ConsoleColor.DarkGreen);

    blueSword.Display();
    redBow.Display();
    greenAxe.Display();
  }
}

  // *************************************************************************************************
