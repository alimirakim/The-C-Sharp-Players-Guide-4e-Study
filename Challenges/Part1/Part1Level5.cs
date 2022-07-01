/// <summary>
/// LEVEL 5: Variables 
/// </summary>
public static class Part1Level5
{
  public static void CallAll()
  {
    KnowledgeCheckVariables();
  }

  /// <summary>
  /// Knowledge Check: Variables 
  /// </summary>
  public static void KnowledgeCheckVariables()
  {
    Utils.WriteTitle("Knowledge Check - Variables");
    Console.WriteLine("Check your knowledge with the following questions: ");

    Console.Write("1. Name the three things all variables have. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer1}");

    Console.Write("\n2. True/False. Variables must always be declared before being used. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer2}");

    Console.Write("\n3. Can you redeclare a variable? ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer3}");

    Console.Write("\n4. Which of the following are legal C# variable names? answer,1stValue,value1,$message,delete-me,delete_me,PI ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer4}");
  }

  // ANSWERS TO KNOWLEDGE CHECK QUESTIONS
  private static string _answer1 = "name, type, value";
  private static string _answer2 = "True";
  private static string _answer3 = "No";
  private static string _answer4 = "answer,value1,delete_me,PI";
}