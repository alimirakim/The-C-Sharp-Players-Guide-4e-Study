using System;
namespace Template;

/// <summary>
/// LEVEL 12: Arrays
/// </summary>
public static class Level12
{
  public static void CallAll()
  {
    TheReplicatorOfDTo();
    TheLawsOfFreach();
  }

  /// <summary>
  /// Challenge 1/2: The Replicator of D'To
  ///<br/> Along with the new-found tool of arrays, you have managed to uncover the ancient Replicator of the D'To. This can replicate the contents of any `int` array into another array, but it appears broken and needs a Programmer to reforge the magic that allows it to replicate once again.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Make a program that creates an array of length 5.
  ///<br/> [] Ask the user for five numbers and put them in the array.
  ///<br/> [] Make a second array of length 5.
  ///<br/> [] Use a loop to copy the values out of the original array and into the new one.
  ///<br/> [] Display the contents of both arrays one at a time to illustrate that the Replicator of D'To works again.
  /// </summary>
  public static void TheReplicatorOfDTo()
  {
    Utils.WriteTitle("The Replicator Of D'To");


  }

  /// <summary>
  /// Challenge 2/2: The Laws of Freach
  ///<br/> The town of  Freach recently had an awful looping disaster. The lead investigator found that it was a faulty `++` operator in an old `for` loop, but the town council has chosen to ban all loops but the `foreach` loop. Yet Freach uses the code presented earlier in this level to compute the minimum and the average value in an `int` array. They have hired you to rework their existing `for`-based code to use `foreach` loops instead.
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Start with the code for computing an array's minimum and average values in the section *Some Examples with Arrays*, starting on page 90 (see provided code below in TheLawsOfFreach).
  ///<br/> [] Modify the code to use `foreach` loops instead of `for` loops.
  /// </summary>
  public static void TheLawsOfFreach()
  {
    Utils.WriteTitle("The Laws Of Freach");
    int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

    // Some Examples With Arrays: computing array's minimum value
    int currentMinimum = int.MaxValue; // Start higher than anything in the array.
    for (int index = 0; index < array.Length; index++)
    {
      if (array[index] < currentMinimum)
        currentMinimum = array[index];
    }

    // Some Examples With Arrays: computing array's average value
    int total = 0;
    for (int index = 0; index < array.Length; index++)
      total += array[index];

    float average = (float)total / array.Length;
    Console.WriteLine(average);
  }
}