using System;
namespace Template;

/// <summary>
/// LEVEL 18: Classes 
/// </summary>
public static class Level18
{
  public static void CallAll()
  {
    VinFletchersArrows();
  }

  /// <summary>
  /// Challenge 1/1: Vin Fletcher's Arrows 
  ///<br/> Vin Fletcher is a skilled arrow maker. He asks for help to build a new class to represent arrows and determine how much he should sell them for. "A tiny fragment of my soul goes into each arrow; I care not for the money; I just need to be able to recoup my costs and get food on the table," he says.
  ///<br/> 
  ///<br/> Each arrow has three parts: the Arrowhead (steel, wood, or obsidian), the shaft (a length between 60 and 100cm long), and the fletching (plastic, turkey feathers, or goose feathers).
  ///<br/> 
  ///<br/> His costs are as follows: 
  ///<br/> For arrowheads, steel costs 10 gold, wood costs three gold, an obsidian costs 5 gold. 
  ///<br/> For fletching, plastic costs 10 gold, turkey feathers cost 5 gold, and goose feathers cost 3 gold. 
  ///<br/> For the shaft, the price depends on the length: 0.05 gold per centimeter.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Define a new `Arrow` class that has instance variables for arrowhead type, fletching type, and length. (Hint: Arrowhead types and fletching types might be good enumerations.)
  ///<br/> [] Allow a user to pick the arrowhead, fletching type, and length and then create a new `Arrow` instance. 
  ///<br/> [] Add a `GetCost` method that returns its cost as a `float` based on the numbers above, and use this to display the arrows cost.
  /// </summary>
  public static void VinFletchersArrows()
  {
    Utils.WriteTitle("Vin Fletcher's Arrows");


  }
}