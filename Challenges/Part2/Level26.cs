using System;
namespace Template;

/// <summary>
/// LEVEL 26: Polymorphism 
/// </summary>
public static class Level26
{
  public static void CallAll()
  {
    LabelingInventory();
    TheOldRobot();
  }


  /// <summary>
  /// Challenge 1/2: Labeling Inventory 
  ///<br/> You realize that your inventory items are not easy to sort through. If you could make it easy to label all of your inventory items, it would be easier to know what items you have in your pack.
  ///<br/> 
  ///<br/> Modify your inventory program from the previous level as described below.
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Override `ToString` on all of your inventory item subclasses to give them a name. For example, `new Rope().ToString()` should return "Rope".
  ///<br/> [] Override `ToString` on the `Pack` class to display the contents of the pack. If a pack contains water, rope, and two arrows, then calling `ToString` on that `Pack` object should look something like "Pack containing Water Rope Arrow Arrow".
  ///<br/> [] Before the user chooses the next item to add, display the pack's current contents via its new `ToString` method.
  /// </summary>
  public static void LabelingInventory()
  {
    Utils.WriteTitle("Labeling Inventory");


  }

  /// <summary>
  /// Challenge 2/2: The Old Robot 
  ///<br/> You spot something shiny, half-buried in the mud. You pull it out and realize that it seems to be some mechanical automaton with the words "Property of Dynamak" etched onto it. As you knock off the caked-on mud, you realize that it seems like this old automaton might even be programmable if you can give it the proper commands. The automaton seems to be structured like this:
  ///<br/> 
  ///<br/> SAMPLE CODE:
  ///<br/>   public class Robot
  ///<br/>   {
  ///<br/>     public int X { get; set; }
  ///<br/>     public int Y { get; set; }
  ///<br/>     public bool IsPowered { get; set; }
  ///<br/>     public RobotCommand[] Commands { get; } = new RobotCommand[3];
  ///<br/>     public void Run()
  ///<br/>     {
  ///<br/>       foreach (RobotCommand command in Commands)
  ///<br/>       {
  ///<br/>         command.Run(this);
  ///<br/>         Console.WriteLine($"[{X} {Y} {IsPowered}]");
  ///<br/>       }
  ///<br/>     }
  ///<br/>   }
  ///<br/> 
  ///<br/> You don't see a definition of that `RobotCommand` class. Still, you think you might be able to recreate it (some class with only an abstract `Run` command) and then make derived classes that extend `RobotCommand` that move it in each of the four directions and power it on and off. (You wish you could manufacture a whole army of these!)
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Copy the code above into a new project.
  ///<br/> [] Create a `RobotCommand` class with a public and abstract `void Run(Robot robot)` method. (The code above should compile after this step.)
  ///<br/> [] Make `OnCommand` and `OffCommand` classes that inherit from `RobotCommand` and turn the robot on or off.
  ///<br/> [] Make a `NorthCommand`, `SouthCommand`, `WestCommand`, and `EastCommand` that move the robot 1 unit in the +Y direction, 1 unit in the -Y direction, 1 unit in the -X direction, and 1 unit in the +X direction, respectively. Also, ensure that these commands only work if the robot's `IsPowered` property is `true`.
  ///<br/> [] Make your main method able to collect three commands from the console window. Generate new `RobotCommand` objects based on the text entered. After filling the robot's command set with these new `RobotCommand` objects, use the robot's `Run` method to execute them. For example:
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   on
  ///<br/>   north
  ///<br/>   west
  ///<br/>   
  ///<br/>   [0 0 True]
  ///<br/>   [0 1 True]
  ///<br/>   [-1 1 True]
  ///<br/> - Note: You might find this strategy for making commands that update other objects useful in some of the larger challenges in the coming levels.
  /// </summary>
  public static void TheOldRobot()
  {
    Utils.WriteTitle("The Old Robot");


  }
}