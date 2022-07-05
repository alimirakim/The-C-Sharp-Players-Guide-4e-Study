using System;
namespace Template;

/// <summary>
/// LEVEL 8: Console 2.0
/// </summary>
public static class Level8
{
  public static void CallAll()
  {
    TheDefenseOfConsolas();
  }

  /// <summary>
  /// Challenge 1/1: The Defense of Consolas
  ///<br/> The Uncoded One has begun an assault on the city of Consolas; the situation is dire. From a moving airship called the Manticore, massive fireballs capable of destroying city blocks are being catapulted into the city. 
  ///<br/> 
  ///<br/> The city is arranged in blocks numbered like a chess board. The city's only defense is a immovable magical barrier, operated by squad of four that can protect a single city block by putting themselves in each of the target's for adjacent blocks as shown in the picture to the right (no pic sorry).
  ///<br/> 
  ///<br/> For example, to protect the city block at (Row 6, Column 5), the crew deploys themselves to (Row 6, Column 4). (Row 5, Column 5), (Row 6, Column 6), and (Row 7, Column 5).
  ///<br/> 
  ///<br/> The good news is that if we can compute the deployment locations fast enough, the crew could be deployed around the target in time to prevent catastrophic damage to the city for as long as the seige lasts. The City of Consolas needs a program to tell the squad where to deploy, given the anticipated target. Something like this:
  ///<br/> 
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   Target Row? 6
  ///<br/>   Target Column? 5
  ///<br/>   Deploy to:
  ///<br/>   (6, 4)
  ///<br/>   (5, 5)
  ///<br/>   (6, 6)
  ///<br/>   (7, 5)
  ///<br/>   
  ///<br/> OBJECTIVES:
  ///<br/> [] Ask the user for the target row and columns.
  ///<br/> [] Compute the neighboring rows and columns of where to deploy the squad.
  ///<br/> [] Display the deployment instructions in a different color of your choosing.
  ///<br/> [] Change the window title to be "Defense of Consolas".
  ///<br/> [] Play a sound with `Console.Beep` when the results have been computed and displayed.
  /// </summary>
  public static void TheDefenseOfConsolas()
  {
    Utils.WriteTitle("The Defense Of Consolas");


  }

}