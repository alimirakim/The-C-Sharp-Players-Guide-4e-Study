namespace Template;

/// <summary>
/// LEVEL 1: The C# Programming Language 
/// </summary>
public class Level1 : Level
{
  Quiz knowledgeCheckCSharp = new Quiz(
    "Knowledge Check - C#",
    SectionType.KnowledgeCheck,
    new (string question, string answer)[]
    {
      (question: "1. True/False. C# is a special-purpose language optimized for making web applications.",
      answer: "False"),
      (question: "2. What is the name of the framework that C# runs on? ",
      answer: ".NET"),
    }
  );

  public Level1() : base("Level 1: The C# Programming Language ")
  {
    Sections = new Section[] {
      knowledgeCheckCSharp
    };
  }
}