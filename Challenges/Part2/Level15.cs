using System;
namespace Template;

/// <summary>
/// LEVEL 15: Object-Oriented Concepts 
/// </summary>
public static class Level15
{
  public static void WriteTitle()
  {
    Utils.WriteTitle("LEVEL 15: Object-Oriented Concepts");
  }
  public static void CallAll()
  {
    WriteTitle();
    KnowledgeCheckObjects();
  }

  public static void CallChallenges()
  {
    WriteTitle();
    Console.WriteLine("This level has no challenges :( .");
  }

  /// <summary>
  /// Knowledge Check: Objects 
  /// </summary>
  public static void KnowledgeCheckObjects()
  {
    Utils.WriteTitle("Knowledge Check - Objects");
    Console.WriteLine("Check your knowledge with the following questions: ");

    Console.Write("1. What two things does an object bundle together? ");
    string? reply1 = Console.ReadLine();
    Console.WriteLine($"Answer: {_answer1}");

    Console.Write("\n2. True/False. C# lets you define new types of objects. ");
    string? reply2 = Console.ReadLine();
    Console.WriteLine($"Answer: {_answer2}");


  }

  // ANSWERS TO QUESTIONS
  private static string _answer1 = "data and operations on that data";
  private static string _answer2 = "True";

}
