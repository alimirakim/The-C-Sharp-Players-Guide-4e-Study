

/// <summary>
/// LEVEL 2: Getting an IDE
/// </summary>
public static class Part1Level2
{
  public static void CallAll()
  {
    GettingAnIDE();
  }

  /// <summary>
  /// Challenge 1/1: Install Visual Studio
  /// <br/> 
  /// <br/> **Objective:**
  /// <br/> [] Install Visual Studio Community edition (or any other IDE) and get it ready to start programming.
  /// </summary>
  public static void GettingAnIDE()
  {
    Utils.WriteTitle("Challenge: Getting an IDE");

    Console.Write("Did you successfully install Visual Studio or another IDE? ");
    string? reply = Console.ReadLine();
    Console.WriteLine("Nice. ");
  }

}