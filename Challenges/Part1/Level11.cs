using System;
namespace Template;

/// <summary>
/// LEVEL 11: Looping
/// </summary>
public static class Level11
{
  public static void CallAll()
  {
    ThePrototype();
    TheMagicCannon();
  }

  /// <summary>
  /// Challenge 1/2: The Prototype
  ///<br/> Mylara, the captain of the Guard of Consolas, has approached you with the beginnings of a plan to hunt down the Uncoded One's airship. "If we're going to be able to track this thing down," she says, "we need you to make us a program that can help us home in on a location." She lays out a plan for a program to help with the hunt. One user representing the pilot of the airship picks a number between zero and 100. Another user, the Hunter, will then attempt to guess the number. The program will tell the hunter that they guess correctly or that the number was too high or too low. The program repeats until the hunter guesses the number correctly. Mylar claims "If we can build this program, we can use what we learn to build a better version to hunt down the Uncoded One's airship".
  ///<br/> 
  ///<br/> SAMPLE PROGRAM: 
  ///<br/>   User 1, enter a number between 0 and 100: 27
  ///<br/>   <clear the screen>
  ///<br/>   User 2, guess the number.
  ///<br/>   What is your next guess? 50
  ///<br/>   50 is too high.
  ///<br/>   What is your next guess? 25
  ///<br/>   25 is too low.
  ///<br/>   What is your next guess? 27
  ///<br/>   You guessed the number!
  ///
  ///<br/> OBJECTIVES: 
  ///<br/> [] Build a program that will allow a user, the pilot, to enter a number.
  ///<br/> [] If the number is above 100 or less than 0, keep asking.
  ///<br/> [] Clear the screen once the program has collected a good number.
  ///<br/> [] Ask a second user, the hunter, to guess numbers.
  ///<br/> [] Indicate whether the user guessed too high, too low, or guessed right.
  ///<br/> [] Loop until they get it right, then end the program.
  /// </summary>
  public static void ThePrototype()
  {
    Utils.WriteTitle("The Prototype");


  }

  /// <summary>
  /// Challenge 2/2: The Magic Cannon
  ///<br/> Skorin, a member of Consolas's wall guard, has constructed a magic cannon that draws power from two gems: a fire gem and an electric gem. Every third turn of the crank, the fire gem activates, and the cannon produces a fire blast. Every fifth turn of the crank, the electric gem activates, and the cannon makes an electric blast. When the two line up, it generates a potent combined blast. Skorin would like your help to produce a program that can give the crew a warning about which turns of the crank will produce the different blasts before they do it.
  ///<br/> 
  ///<br/> A partial output of the desired program looks like this:
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   1: Normal
  ///<br/>   2: Normal
  ///<br/>   3: Fire
  ///<br/>   4: Normal
  ///<br/>   5: Electric
  ///<br/>   6: Fire
  ///<br/>   7: Normal
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Write a program that will loop through the values between 1 and 100 and display what kind of blast the crew should expect. (The % operator may be of use.)
  // [] Change the color of the output based on the the type of blast. (For example, red for Fire, yellow for Electric, and blue for Electric and Fire).
  /// </summary>
  public static void TheMagicCannon()
  {
    Utils.WriteTitle("The Magic Cannon");


  }

}