
using System;

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

  public enum TestyEnum { First=1, Second, Third}

  public static void CallAll()
  {
    TestyEnum testy = default;
    TestyEnum testerinos = (TestyEnum)500;
    Console.WriteLine(testerinos);

    string result = testy switch
    {
      TestyEnum.First => "first!",
      TestyEnum.Second => "second sucks",
      TestyEnum.Third => "i am last :C",
      _ => "what am i",
    };
    Console.WriteLine(result);

    // PackingInventory();
    // LabelingInventory();
    // TheOldRobot();
    // RoboticInterface();
    // RoomCoordinates();
    // WarPreparations();
    // ColoredItems();
    // TheFountainOfObjects();
    // SmallMediumOrLarge();
    // Pits();
    // Maelstroms();
    // Amaroks();
    // GettingArmed();
    // GettingHelp();
    // TheRobotPilot();
    // TimeInTheCavern();
    // ListsOfCommands();
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

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Core) 1/7: The Fountain of Objects 
  /// The game The Fountain of Objects is a 2D grid-based world full of rooms. Most rooms are empty, but a few are unique rooms. One room is the cavern entrance. One room is the fountain room, containing the Fountain of Objects.
  /// 
  /// The player moves through the cavern system, one room at a time to find the Fountain of Objects. They activate it and then return to the entrance room. If they do this without falling into a pit, they win the game.
  /// 
  /// Unnatural darkness pervades the caverns, preventing both natural and human-made light. The player must navigate the caverns in the dark, relying on their sense of smell and hearing to determine what room they are in and what dangers lurk in nearby rooms.
  /// 
  /// This challenge serves as the basis for the other challenges in this level. It must be completed before the others can be started. The requirements of this game are listed below.
  /// **Objectives:** 
  /// [] The world consists of a grid of rooms, where each room can be referenced by its row and column. North is up, east is right, south is down, and west is left:
  /// **Image:** 
  ///   |----|----|----|----|
  ///   |    |    |    |    | 0                 
  ///   |----|----|----|----|                 North
  ///   |    |    |    |    | 1  R              ^ 
  ///   |----|----|----|----|    o       West < + > East
  ///   |    |    |    |    | 2  w              v
  ///   |----|----|----|----|                 South
  ///   |    |    |    |    | 3
  ///   |----|----|----|----|
  ///     0    1    2    3
  ///          Column
  ///        
  /// [] The games flow works like this: The player is told what they can sense in the dark (see, here, smell). Then the player gets a chance to perform some action by typing it in. Then their chosen action is resolved (the player moves, the state of things in the game changes, checking for a win or loss, etc.). Then the loop repeats.
  /// [] Most rooms are empty rooms, and there is nothing to sense. 
  /// [] The player is in one of the rooms and can move between them by running the following commands: "move north", "move south", "move east", and "move west". The player should not be able to move past the edge of the map.
  /// [] The room at (Row=0, Column=0) is the cavern entrance (and exit). The player should start here. The player can sense light coming from outside the cavern when in this room. ("You see light in this room coming from outside the cavern. This is the entrance.") 
  /// [] The room at (Row=0, Column=2) is the fountain room, containing the Fountain of Objects itself. The Fountain can be either enabled or disabled. The player can hear the fountain but hears different things depending on if it is on or not.("You hear water dripping in this room. The Fountain of Objects is here!" or "You hear the rushing waters from the Fountain of Objects. It has been reactivated!" The fountain is off initially in the fountain room. The player can type the command "enable fountain" to enable it. If the player is not in the fountain room, there should be no effect, and the player should be told so.
  /// [] The player wins by moving to the fountain room, enabling the Fountain of Objects, and then moving to the cavern entrance. If the player is in the entrance and the fountain is on, the player wins.
  /// [] Use different colors to display the different types of text in the console window. For example, narrative items (intro, ending, etc.) may be magenta, descriptive text in white, input from the user in cyan, text describing entrance light in yellow, messages about the fountain in blue.
  /// An example of what the program might look like is shown below:
  /// **Sample Program:**
  ///   You are in the room at (Row=0, Column=0).
  ///   You see light coming from the cavern entrance. 
  ///   What do you want to do? move east
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=1).
  ///   What do you want to do? move east
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=2).
  ///   
  ///   You hear water dripping in this room. The Fountain of Objects is here!
  ///   What do you want to do? enable fountain
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=2).
  ///   You hear the rushing waters from the Fountain of Objects. It has been reactivated!
  ///   What do you want to do? move west
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=1).
  ///   What do you want to do? move west
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=0).
  ///   The Fountain of Objects has been reactivated, and you have escaped with your life!
  ///   You win!
  ///   
  /// - Hint: You may find two-dimensional arrays(Level 12) helpful and representing a 2D grid-based game world.
  /// - Hint: Remember your training! You do not need to solve this entire problem all at once, and you do not have to get it right in your first attempt. Pick an item or two to start, then plot a course to solve just those items. Rework until you're happy with it, then add in the next item or two.
  /// </summary>
  public static void TheFountainOfObjects()
  {
    WriteTitle("The Fountain of Objects");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 32: Some Useful Types 
  /// Challenge /: The Robot Pilot 
  /// When we first made the Hunting the Manticore game in Level 14, we required two human players: one to set up the Manticore's range from the  city and the other to destroy it. With `System.Random`, we can turn this into a single-player game by randomly picking the range for the   Manticore.
  /// 
  /// **Objectives:** 
  /// [] Modify your Hunting the Manticore game to be a single-player game by having the computer pick a random range between 0 and 100.
  /// [] Answer this question: How might you use inheritance, polymorphism, or interfaces to allow the game to be either a single player (the   computer randomly chooses the starting location and direction) or two players (the second human determines the starting location and direction)?
  /// </summary>
  public static void TheRobotPilot()
  {
    WriteTitle("The Robot Pilot");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 2/7: Small, Medium, or Large 
  /// The larger the Cavern of Objects is, the more difficult the game becomes. The basic game only requires a small 4x4 world, but we will add a   medium 6x6 world and a larger 8x8 world to complete this challenge.
  /// 
  /// **Objectives:** 
  /// [] Before the game begins, ask the player whether they want to play a small, medium, or large game. Create a 4x4 world if they choose a   small world, a 6x6 world if they choose a medium world, and an 8x8 world if they choose a large world.
  /// [] Pick an appropriate location for both the Fountain Room and the Entrance room.
  /// - Note: When combined with the Amaroks, Maelstroms, or Pits challenges, you will need to adapt the game to handle adding amaroks,   maelstroms, and pits to all three sizes.
  /// </summary>
  public static void SmallMediumOrLarge()
  {
    WriteTitle("Small, Medium, or Large");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 3/7: Pits 
  /// The Cavern of Objects is a dangerous place. Some rooms upen up to bottomless pits. Entering a pit means death. The player can sense a pit is  in an adjacent room decause a draft of air pushes through the pits into adjacent rooms. Add pit rooms to the game and end the game if the player   stumbles into one.
  /// 
  /// **Objectives:** 
  /// [] Add a pit room to your 4x4 cavern in a location of your choice, except the fountain and entrance rooms.
  /// [] Players can sense the draft pushing out of pits in adjacent rooms (all eight directions): "You feel a draft. There is a pit in a nearby  room."
  /// [] If a player ends their turn in a room with a pit, they lose the game.
  /// [] Note: When combined with the Small, Medium, or Large challenge, add one pit to the 4x4 world, two pits to the 6x6 world, and four pits to  the 8x8 world, in locations of your choice.
  /// </summary>
  public static void Pits()
  {
    WriteTitle("Pits");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 4/7: Maelstroms 
  /// TODO Add description
  /// 
  /// **Objectives:** 
  /// [] Add a maelstrom to the small 4x4 game in a location of your choice.
  /// [] The player can sense maelstroms by hearing them in adjacent rooms. ("You hear the growling and groaning of a maelstrom nearby.")
  /// If a player enters a room with a maelstrom, the player moves one space north and two spaces east, while the maelstrom moves one space south   and two spaces west. When the player is moved like this, tell them so. If this would move the player or maelstrom beyond the map's edge, ensure   they stay on the map.
  /// [] Note: When combined with the Small, Medium, or Large challenge, place one maelstrom into the medium-sized game and two into the  large-sized game.
  /// </summary>
  public static void Maelstroms()
  {
    WriteTitle("Maelstroms");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 5/7: Amaroks 
  /// TODO
  /// 
  /// **Objectives:** 
  /// [] The placement of amaroks is at your discretion. Pick a room to place an amarok aside from the entrance or fountain room in the small 4x4   world.
  /// [] When a player is in one of the eight spaces adjacent to an amarok, a message should be displayed when sensing surrounding that indicate  that the player can smell the amarok nearby. For example, "You can smell the rotten stench of an amarok in a nearby room."
  /// [] When a player enters a room with an amarok, the player dies and loses the game.
  /// [] Note: When combined with the Small, Medium, or Large challenge, place two amaroks in the medium level and three in the large level in  locations of your choosing.
  /// </summary>
  public static void Amaroks()
  {
    WriteTitle("Amaroks");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 6/7: Getting Armed 
  /// TODO
  /// 
  /// **Objectives:** 
  /// [] Add the following commands that allow a player to shoot in any of the foor directions: shoot north, shoot east, shoot south, and shoot   west. When the player shoots in one of the four directions, an arrow is fired into the room in that direction. If a monster is in that room, it   is killed and should not affect the game anymore. (They can no longer sense it, and it should not affect the player.)
  /// [] The player only has a limited number of arrows (5) and cannot shoot when they are out of arrows. Display the number of arrows the player   has when displaying the game's status before asking for their action.
  /// </summary>
  public static void GettingArmed()
  {
    WriteTitle("Getting Armed");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 7/7: Getting Help 
  /// 
  /// 
  /// **Objectives:** 
  /// [] When the game starts, display text that describes the game shown below:
  /// **Sample Program:**
  ///   You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search
  ///   of the Fountain of Objects.
  ///   Light is visible only in the entrance, and no other light is seen anywhere in the caverns.
  ///   You must navigate the Caverns with your other senses.
  ///   Find the Fountain of Objects, activate it, and return to the entrance.
  /// [] If you choose to to the Pits challenge, add the following to the description: "Look out for pits. You will feel a breeze if a pit is in  an adjacent room. If you enter a room with a pit, you will die."
  /// [] If you chose to do the Maelstroms challenge, add the following to the description: "Maelstroms are violent forces of sentient wind.  Entering a room with one could transport you to any other location in the caverns. You will be able to hear their growling and groaning in   nearby rooms."
  /// [] If you chose to do the Getting Armed challenge, add the following to the description: "You carry with you a bow and a quiver of arrows.  You can use them to shoot monsters in the caverns but be warned: you have a limited supply."
  /// [] When the player types the command `help`, display all available commands and a short description of what each does. The complete list of   commands will depend on what challenges you complete.
  /// </summary>
  public static void GettingHelp()
  {
    WriteTitle("Getting Help");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 32: Some Useful Types <br/>
  /// Challenge 2/3: Time in the Cavern 
  /// With `System.DateTime` and `System.TimeSpan`, you can keep track of how much time a player spends in the Cavern of Objects to beat the game. With these tools, modify your Fountain of Objects game to display how much time a player spent exploring the caverns.
  /// 
  /// **Objectives:** 
  /// [] When a new game begins, capture the current time using `System.DateTime`.
  /// [] When a game finishes (win or loss), capture the current time.
  /// [] Use `System.TimeSpan` to compute how much time elapsed and display that to the player.
  /// </summary>
  public static void TimeInTheCavern()
  {
    WriteTitle("Time in the Cavern");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 32: Some Useful Types 
  /// Challenge 3/3: Lists of Commands 
  /// In Level 27, we encountered a robot that had an array to hold commands to run. But we could make the robot have as many commands as we want by turning the array into a list. Revisit that challenge to make the robot use a list instead of an array, and add commands to run until the user says to stop.
  /// 
  /// **Objectives:** 
  /// [] Change the `Robot` class to use a `List<IRobotCommand>` instead of an array for its `Commands` property. (Don't forget the `using` directive for `System.Collections.Generic`.)
  /// [] Instead of looping three times, go until the user types `stop`. Then run all of the commands created.
  /// </summary>
  public static void ListsOfCommands()
  {
    WriteTitle("Lists of Commands");


  }
}