using System;
namespace Template;

/// <summary>
/// LEVEL 3: Hello World! Your First Program
/// </summary>
public class Level3 : Level
{

  public Level3() : base("Level 3: Hello World! Your First Program")
  {
    Sections = new Section[] {
      new HelloWorld(),
      new WhatComesNext(),
      new MakingsOfAProgrammer(),
      new ConsolasAndTelim(),
    };
  }


  /// <summary>
  /// Challenge 1/4: Hello World!
  ///<br/> TODO Add description
  ///<br/>
  ///<br/> OBJECTIVES:
  ///<br/> [] Create a new Hello World program from the C# Console Application template, targeting .NET 5.
  ///<br/> [] Run your program using any of the three methods described above.
  /// </summary>
  public class HelloWorld : Section
  {
    public HelloWorld() : base("Hello World!", SectionType.Challenge) { }

    public override void Run()
    {
      // TODO Fulfill objectives!
    }
  }

  /// <summary>
  /// Challenge 2/4: What Comes Next
  ///<br/> TODO add description
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Replace the file's contents with a `using System;` and `Console.WriteLine("Hello World!");`
  ///<br/> [] Change your program to say something (anything!) besides "Hello World!".
  /// </summary>
  public class WhatComesNext : Section
  {
    public WhatComesNext() : base("What Comes Next", SectionType.Challenge) { }

    public override void Run()
    {
      // TODO Fulfill objectives!
    }

  }


  /// <summary>
  /// Challenge 3/4: Makings of a Programmer
  ///<br/> TODO Add description
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Make a program with 5 `Console.WriteLine` statements in it.
  ///<br/> [] **Answer this question:** How many statements do you think a program can contain?
  ///<br/> 
  /// </summary>
  public class MakingsOfAProgrammer : Section
  {
    public MakingsOfAProgrammer() : base("Challenge: Makings Of A Programmer", SectionType.Challenge) { }

    public override void Run()
    {
      // TODO Fulfill objectives!
    }
  }

  /// <summary>
  /// Challenge 4/4: Consolas and Telim
  ///<br/> TODO Add description
  ///<br/> 
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   Bread is ready.
  ///<br/>   Who is the bread for?
  ///<br/>   RB
  ///<br/>   Noted: RB got bread.
  ///<br/> 
  ///<br/> OBJECTIVES:
  ///<br/> [] Make a program that runs as shown above, including taking a name from the user.
  /// </summary>
  public class ConsolasAndTelim : Section
  {
    public ConsolasAndTelim() : base("Challenge: ConsolasAndTelim", SectionType.Challenge) { }

    public override void Run()
    {
      // TODO Fulfill objectives!
    }
  }
}