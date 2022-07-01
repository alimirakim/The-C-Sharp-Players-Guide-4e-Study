
/// <summary>
/// LEVEL 14: Memory Management 
/// </summary>
public static class Part1Level14
{
    public static void CallAll()
  {
    KnowledgeCheckMemory();
  }

  /// <summary>
  /// Knowledge Check: Memory 
  /// </summary>
  public static void KnowledgeCheckMemory()
  {
    Utils.WriteTitle("Knowledge Check - Memory");
   Console.WriteLine("Check your knowledge with the following questions: ");

    Console.WriteLine("1. True/False. You can access anything on the stack at any time. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer1}");

    Console.WriteLine("\n2. True/False. The stack keeps track of local variables. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer2}");

    Console.WriteLine("\n3. True/False. The contents of a value type can be placed on the heap. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer3}");

    Console.WriteLine("\n4. True/False. The contents of a value type are *always* placed on the heap. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer4}");

    Console.WriteLine("\n5. True/False. The contents of reference types are *always* placed on the heap. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer5}");

    Console.WriteLine("\n6. True/False. The garbage collector cleans up old, unused spaced on the heap and stack. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer6}");

    Console.WriteLine("\n7. True/False. If a and b are arrays that reference the same object, modifying a affects be as well. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer7}");

    Console.WriteLine("\n8. True/False. If a and b are ints with the same value, changing a will affect b as well. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer8}");

  }

  // ANSWERS TO KNOWLEDGE CHECK QUESTIONS
  private static string _answer1 = "False";
  private static string _answer2 = "True";
  private static string _answer3 = "True";
  private static string _answer4 = "False";
  private static string _answer5 = "True";
  private static string _answer6 = "False";
  private static string _answer7 = "True";
  private static string _answer8 = "False";

}