using System;
namespace Template;

/// <summary>
/// LEVEL 2: Getting an IDE
/// </summary>
public class Level2 : Level
{
  public Level2() : base("Level 2: Getting an IDE") 
  {
    Sections = new Section[] {
      new GettingAnIDE(),
    };
  }
  
/// <summary>
/// Challenge 1/1: Install Visual Studio
/// <br/> 
/// <br/> OBJECTIVES:
/// <br/> [] Install Visual Studio Community edition (or any other IDE) and get it ready to start programming.
/// </summary>
  private class GettingAnIDE : Section
  {
    public GettingAnIDE() : base("Challenge: Getting an IDE", SectionType.Challenge) { }

    public override void Run()
    {
      Console.Write("Did you successfully install Visual Studio or another IDE? ");
      string? reply = Console.ReadLine();
      Console.WriteLine("Nice. ");
    }
  }
}
