
/// <summary>
/// LEVEL 1: The C# Programming Language 
/// </summary>
public static class Part1Level1
{
  public static void CallAll()
  {
    KnowledgeCheckCSharp();
  }

  /// <summary>
  /// Knowledge Check: C# 
  /// </summary>
  public static void KnowledgeCheckCSharp()
  {
    Utils.WriteTitle("Knowledge Check - C#");
    Console.WriteLine("Check your knowledge with the following questions: ");

    Console.Write("1. True/False. C# is a special-purpose language optimized for making web applications. ");
    string? reply1 = Console.ReadLine();
    Console.WriteLine($"Answer: {_answer1}");

    Console.Write("\n2. What is the name of the framework that C# runs on? ");
    string? reply2 = Console.ReadLine();
    Console.WriteLine($"Answer: {_answer2}");

  }

  // ANSWERS TO KNOWLEDGE CHECK QUESTIONS
  private static string _answer1 = "False";
  private static string _answer2 = ".NET";
}