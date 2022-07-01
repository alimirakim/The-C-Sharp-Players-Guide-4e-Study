/// <summary>
/// LEVEL 6: The C# Type System
/// </summary>
public static class Part1Level6
{
  public static void CallAll()
  {
    TheVariableShop();
    TheVariableShopReturns();
    KnowledgeCheckTypeSystem();
  }

  ///<summary>
  /// Challenge 1/2: The Variable Shop
  ///<br/> TODO Add description
  ///<br/> 
  ///<br/> **Objectives:**
  ///<br/> [] Build a program with a variable of all fourteen types described in this level.
  ///<br/> [] Assign each of them a value using a literal of the correct type.
  ///<br/> [] Use `Console.WriteLine` to display the contents of each variable.
  /// </summary>
  public static void TheVariableShop()
  {
    Utils.WriteTitle("The Variable Shop");


  }


  /// <summary>
  /// Challenge 2/2: The Variable Shop Returns
  ///<br/> TODO
  ///<br/> 
  ///<br/> **Objectives:**
  ///<br/> [] Modify the *Variable Shop* program to assign a new, different literal value to each of the 14 original variables. Do not declare any additional variables.
  ///<br/> [] Use `Console.WriteLine` to display the updated contents of each variable.
  ///<br/> 
  /// </summary>
  public static void TheVariableShopReturns()
  {
    Utils.WriteTitle("The Variable Shop Returns");


  }


  /// <summary>
  /// Knowledge Check: Type System 
  /// </summary>
  public static void KnowledgeCheckTypeSystem()
  {
    Utils.WriteTitle("Knowledge Check - Type System");
    Console.WriteLine("Check your knowledge with the following questions: ");

    Console.Write("1. True/False. The int type can store any possible integer. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer1}");

    Console.Write("\n2. Order the following by how large their range is, from smallest to largest: short, long, int, byte. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer2}");

    Console.Write("\n3. True/False. The byte type is signed. ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer3}");

    Console.Write("\n4. Which can store higher numbers, int or uint? ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer4}");

    Console.Write("\n5. What three types can store floating-point numbers? ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer5}");

    Console.Write("\n6. Which of the options in question 5 can hold the largest numbers? ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer6}");

    Console.Write("\n7. Which of the options in question 5 is most precise? ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer7}");

    Console.Write("\n8. What type goes the literal value \"8\" (including the quotes) have? ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer8}");

    Console.Write("\n9. What type stores true or false values? ");
    Console.ReadLine();
    Console.WriteLine($"Answer: {_answer9}");
  }

  // ANSWERS TO KNOWLEDGE CHECK QUESTIONS
  private static string _answer1 = "False";
  private static string _answer2 = "byte,short,int,long";
  private static string _answer3 = "False";
  private static string _answer4 = "uint";
  private static string _answer5 = "float,double,decimal";
  private static string _answer6 = "double";
  private static string _answer7 = "decimal";
  private static string _answer8 = "string";
  private static string _answer9 = "bool";


}