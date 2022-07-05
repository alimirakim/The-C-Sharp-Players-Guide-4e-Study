using System;
namespace Template;

/// <summary>
/// LEVEL 4: Comments
/// </summary>
public class Level4 : Level
{
  public Level4() : base("LEVEL 4: Comments")
  {
    Sections = new Section[] {
      new TheThingNamer3000(),
    };
  }

  /// <summary>
  /// Challenge 1/1: The Thing Namer 3000
  ///<br/> TODO Add description
  ///<br/> 
  ///<br/> SAMPLE CODE:
  ///<br/>   using System; // you don't need this line with .NET 6.0
  ///<br/>   
  ///<br/>   Console.WriteLine("What kind of thing are we talking about?");
  ///<br/>   string a = Console.ReadLine();
  ///<br/>   Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
  ///<br/>   string b = Console.ReadLine();
  ///<br/>   string c = "of Doom";
  ///<br/>   string d = "3000";
  ///<br/>   Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Rebuild the program above on your computer.
  ///<br/> [] Add comments near each of the four variables that describe what they store. You must use at least one of each comment type (`//` and `/* */`).
  ///<br/> [] Find the bug in the text displayed and fix it.
  ///<br/> [] **Answer this question:** Aside from comments, what is one other thing you could do to make this code more understandable.
  ///<br/> </summary>
  public class TheThingNamer3000 : Section
  {
    public TheThingNamer3000() : base("Challenge: The Thing Namer 3000", SectionType.Challenge) { }

    public override void Run()
    {
      Console.WriteLine("TODO: Fulfill objectives! ");
    }
  }

}