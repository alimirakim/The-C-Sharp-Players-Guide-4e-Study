
/// <summary>
/// LEVEL 21: Static 
/// </summary>
public static class Part2Level21
{
  public static void CallAll()
  {
    ArrowFactories();
  }

  /// <summary>
  /// Challenge 1/1: Arrow Factories 
  ///<br/> Vin Fletcher sometimes makes custom-ordered arrows, but these are rare. Most of the time, he sells one of the following standard arrows: 
  ///<br/> 
  ///<br/> - The Elite Arrow, made from a steel arrowhead, plastic fletching, and a 95 cm shaft.
  ///<br/> - The Beginner Arrow, made from a wood arrowhead, goose feathers, and a 75 cm shaft.
  ///<br/> - The Marksman Arrow, made from a steel arrowhead, goose feathers, and a 65 cm shaft.
  ///<br/> 
  ///<br/> You can make static methods so that making these as specific variations of arrows is easy.
  ///<br/> 
  ///<br/> **Objectives:** 
  ///<br/> [] Modify your `Arrow` class one final time to include static methods of the form `public static Arrow CreateEliteArrow() { ... }` for each of the following three above arrow types.
  ///<br/> [] Modify the program to allow a user to choose one of these predefined types for a custom arrow. If they select one of the predefined styles, produce an `Arrow` instance using one of the new static methods. If they choose to make a custom arrow, use the original code to get their custom data about the desired arrow.
  /// </summary>
  public static void ArrowFactories()
  {
    Utils.WriteTitle("Arrow Factories");


  }

}