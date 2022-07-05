using System;
namespace Template;

/// <summary>
/// LEVEL 13: Methods
/// </summary>
public static class Level13
{
    public static void CallAll()
  {
    TakingANumber();
    Countdown();
  }

  /// <summary>
  /// Challenge 1/2: Taking a Number
  ///<br/> Many previous tasks have required getting a number from a user. To save time writing out this code over and over, you have decided to make a method to do this common task.
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Make a method with the signature `int AskForNumber(string text)`. Display the `text` parameter on the command line. Retrieve a response from the user, convert it to an `int`, and return it. Sample usage: `int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");`
  ///<br/> [] Make a method with the signature `int AskForNumberInRange(string text, int min, int max)`. Only return if the entered number is between `min` and `max` values. Otherwise, ask again.
  ///<br/> [] Place this method in at least one of your previous programs to improve it.
  /// </summary>
  public static void TakingANumber()
  {
    Utils.WriteTitle("Taking A Number");


  }

  /// <summary>
  /// Challenge 2/2: Countdown
  ///<br/> Note: this challenge requires that you have read *The Basics of Recursion* sidequest to attempt. (it's just a section explaining recursion concept)
  ///<br/> 
  ///<br/> The Council of Freach has summoned you. New writing has appeared on the Tomb of Algol the Wise, the last True Programmer to wander this land. The writing strikes fear and awe into the hearts of the loop-loving people of Freach: "The next True Programmer shall be able to write any looping code with a method call instead." The Senior Counselor, scared of a world without loops, asks you to put your skill to the test and rewrite the following code, which counts down from 10 to 1, with no loops:
  ///<br/> 
  ///<br/> SAMPLE CODE:
  ///<br/>   for (int x = 10; x > 0; x--)
  ///<br/>     Console.WriteLine(x);
  ///<br/> 
  ///<br/> As you consider the words on the Tomb of Algol the Wise, you begin to think that with recursion, you might be able to rewrite code to countdown from 10 to 1 using recursion instead of a loop.
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Write code that counts down from 10 to 1 using a recursive method.
  ///<br/> [] **Hint:** Remember that you must have a base case that ends the recursion and that every time you call the method recursively, you must be getting closer and closer to that base case.
  /// </summary>
  public static void Countdown()
  {
    Utils.WriteTitle("Countdown");


  }

}