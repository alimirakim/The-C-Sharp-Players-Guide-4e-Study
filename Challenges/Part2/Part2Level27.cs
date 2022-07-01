

/// <summary>
/// LEVEL 27: Interfaces
/// </summary>
public static class Part2Level27
{
  public static void CallAll()
  {
    RoboticInterface();
  }

  /// <summary>
  /// Challenge 1/1: Robotic Interface 
  ///<br/> With your knowledge of interfaces, you realize you can refine the old robot you found in the mud to use interfaces instead of the original design. Instead of an abstract `RobotCommand` base class, it could become an `IRobotCommand` interface!
  ///<br/> 
  ///<br/> Building on your solution to the Old Robot challenge, perform the changes below:
  ///<br/> 
  ///<br/> **Objectives:** 
  ///<br/> [] Change your abstract `RobotCommand` class into an `IRobotCommand` interface.
  ///<br/> [] Remove the unnecessary `public` and `abstract` keywords from the `Run` method.
  ///<br/> [] Change the `Robot` class to use `IRobotCommand` instead of `RobotCommand`.
  ///<br/> [] Make all of your commands implement this new interface instead of extending the `RobotCommand` class that no longer exists. You will also want to remove the `override` keywords in these classes.
  ///<br/> [] Ensure your program still compiles and runs.
  ///<br/> [] Answer this question: Do you feel this is an improvement over using an abstract base class? Why or why not?
  /// </summary>
  public static void RoboticInterface()
  {
    Utils.WriteTitle("Robotic Interface");


  }
}