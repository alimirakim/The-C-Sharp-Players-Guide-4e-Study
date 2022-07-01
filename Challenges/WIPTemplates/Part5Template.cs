namespace Template;

///<summary>
///<br/> PART 5: BONUS LEVELS
/// </summary>
public static class PartFive
{
  public static void CallAll()
  {
    KnowledgeCheckVisualStudio();
    KnowledgeCheckCompilerErrors();
    KnowledgeCheckDebugging();
  }

  public static void WriteTitle(string title)
  {
    string divider = "";
    for (int i = 0; i < title.Length; i++)
      divider += "-";

    Console.WriteLine("");
    Console.WriteLine(title);
    Console.WriteLine(divider);
  }

  // *************************************************************************************************

  ///<summary>
  ///<br/> LEVEL A: Visual Studio 
  ///<br/> Knowledge Check: Visual Studio 
  /// </summary>
  public static void KnowledgeCheckVisualStudio()
  {
    WriteTitle("Knowledge Check - Visual Studio");


  }

  // *************************************************************************************************

  ///<summary>
  ///<br/> LEVEL B: Compiler Errors 
  ///<br/> Knowledge Check: Compiler Errors 
  /// </summary>
  public static void KnowledgeCheckCompilerErrors()
  {
    WriteTitle("Knowledge Check - Compiler Errors");


  }

  // *************************************************************************************************

  ///<summary>
  ///<br/> LEVEL C: Debugging Your Code 
  ///<br/> Knowledge Check: Debugging 
  /// </summary>
  public static void KnowledgeCheckDebugging()
  {
    WriteTitle("Knowledge Check - Debugging");


  }
}
