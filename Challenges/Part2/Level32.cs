using System;
namespace Template;

/// <summary>
/// LEVEL 32: Some Useful Types 
/// </summary>
public static class Level32
{
  public static void CallAll()
  {
    TheRobotPilot();
    TimeInTheCavern();
    ListsOfCommands();
  }

  /// <summary>
  /// Challenge 1/3: The Robot Pilot 
  ///<br/> When we first made the Hunting the Manticore game in Level 14, we required two human players: one to set up the Manticore's range from the  city and the other to destroy it. With `System.Random`, we can turn this into a single-player game by randomly picking the range for the   Manticore.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Modify your Hunting the Manticore game to be a single-player game by having the computer pick a random range between 0 and 100.
  ///<br/> [] Answer this question: How might you use inheritance, polymorphism, or interfaces to allow the game to be either a single player (the   computer randomly chooses the starting location and direction) or two players (the second human determines the starting location and direction)?
  /// </summary>
  public static void TheRobotPilot()
  {
    Utils.WriteTitle("The Robot Pilot");


  }

  ///<summary>
  /// Challenge 2/3: Time in the Cavern 
  ///<br/> With `System.DateTime` and `System.TimeSpan`, you can keep track of how much time a player spends in the Cavern of Objects to beat the game. With these tools, modify your Fountain of Objects game to display how much time a player spent exploring the caverns.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] When a new game begins, capture the current time using `System.DateTime`.
  ///<br/> [] When a game finishes (win or loss), capture the current time.
  ///<br/> [] Use `System.TimeSpan` to compute how much time elapsed and display that to the player.
  /// </summary>
  public static void TimeInTheCavern()
  {
    Utils.WriteTitle("Time in the Cavern");


  }

  ///<summary>
  /// Challenge 3/3: Lists of Commands 
  ///<br/> In Level 27, we encountered a robot that had an array to hold commands to run. But we could make the robot have as many commands as we want by turning the array into a list. Revisit that challenge to make the robot use a list instead of an array, and add commands to run until the user says to stop.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Change the `Robot` class to use a `List<IRobotCommand>` instead of an array for its `Commands` property. (Don't forget the `using` directive for `System.Collections.Generic`.)
  ///<br/> [] Instead of looping three times, go until the user types `stop`. Then run all of the commands created.
  /// </summary>
  public static void ListsOfCommands()
  {
    Utils.WriteTitle("Lists of Commands");


  }
}