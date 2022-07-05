using System;
namespace Template;

/// <summary>
/// LEVEL 6: The C# Type System
/// </summary>
public class Level6 : Level
{
  public Level6() : base("Level 6: The C# Type System")
  {
    Sections = new Section[] {
      new TheVariableShop(),
      new TheVariableShopReturns(),
      new KnowledgeCheckTypeSystem(),
    };
  }

  ///<summary>
  /// Challenge 1/2: The Variable Shop
  ///<br/> TODO Add description
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Build a program with a variable of all fourteen types described in this level.
  ///<br/> [] Assign each of them a value using a literal of the correct type.
  ///<br/> [] Use `Console.WriteLine` to display the contents of each variable.
  /// </summary>
  public class TheVariableShop : Section
  {
    public TheVariableShop() : base("The Variable Shop", SectionType.Challenge) { }

    public override void Run()
    {
      Console.WriteLine("TODO: Fulfill objectives! ");

    }
  }


  /// <summary>
  /// Challenge 2/2: The Variable Shop Returns
  ///<br/> TODO
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Modify the *Variable Shop* program to assign a new, different literal value to each of the 14 original variables. Do not declare any additional variables.
  ///<br/> [] Use `Console.WriteLine` to display the updated contents of each variable.
  /// </summary>
  public class TheVariableShopReturns : Section
  {
    public TheVariableShopReturns() : base("The Variable Shop Returns", SectionType.Challenge) { }

    public override void Run()
    {
      Console.WriteLine("TODO: Fulfill objectives! ");

    }
  }

  /// <summary>
  /// Knowledge Check: Type System 
  /// </summary>
  private class KnowledgeCheckTypeSystem : Quiz
  {
    public KnowledgeCheckTypeSystem() : base(
      "Knowledge Check - Type System",
      SectionType.KnowledgeCheck,
      new (string question, string answer)[] {
      (
        question: "1. True/False. The int type can store any possible integer.",
        answer: "False"
      ),
      (
        question: "2. Order the following by how large their range is, from smallest to largest: short, long, int, byte.",
        answer: "byte, short, int, long"
      ),
      (
        question: "3. True/False. The byte type is signed. ",
        answer: "False"
      ),
      (
        question: "4. Which can store higher numbers, int or uint?",
        answer: "uint"
      ),
      (
        question: "5. What three types can store floating-point numbers?",
        answer: "float,double,decimal"
      ),
      (
        question: "6. Which of the options in question 5 can hold the largest numbers?",
        answer: "double"
      ),
      (
        question: "7. Which of the options in question 5 is most precise?",
        answer: "decimal"
      ),
      (
        question: "8. What type goes the literal value \"8\" (including the quotes) have?",
        answer: "string"
      ),
      (
        question: "9. What type stores true or false values?",
        answer: "bool"
      ),
    }
    ) { }
  } 
  

}