/// <summary>
/// LEVEL 17: Tuples 
/// </summary>
public static class Part2Level17
{
  public static void CallAll()
  {
    SimulasSoups();
  }

  /// <summary>
  /// Challenge 1/1: Simula's Soups 
  ///<br/> Simula is impressed with how you reconstructed the box with an enumeration. When the box opened, you saw that inside was a glowing emerald gem. You don't know what it is, but it seems important. Also in the box with three vials of powder labeled  HOT, SALTY, and  SWEET.
  ///<br/> 
  ///<br/> "Finally! I can make soup again!" Simula says. She casually tosses the small glowing gem to you but is wholly focused on the powders "You stick around and help me make soup, and I'll tell you what that gem of yours does."
  ///<br/> 
  ///<br/> She pulls out three small pots and begins making three different food pots, explaining what she's doing "I can make soup stew and gumbo. I can use mushrooms, chicken, carrots, or potatoes and I can add spicy, salty, or sweet seasoning to each. Why don't you whip up a little program to help us keep track of what we make."
  ///<br/> 
  ///<br/> **Objectives:** 
  ///<br/> [] Define enumerations for the three variations of food type (soup, stew, gumbo) the main ingredient (mushrooms, chicken, carrots, potatoes), and seasoning (spicy, salty, sweet).
  ///<br/> [] Make an array of length 3 to store tuples represent the soups, where each tuple is composed of three elements, one of each of the above enumeration types. 
  ///<br/> [] Allow the user to enter a type, the main ingredient, and one seasoning from the allowed choices for each of the three pots (repeat it three times, one for each spot in the array).
  ///<br/> [] When done, display all three soups in a form such as "Sweet Chicken Gumbo" (if you display in enumeration value, it will display the enumeration member's text representation, so you don't have to convert it to a string yourself).
  /// </summary>
  public static void SimulasSoups()
  {
    Utils.WriteTitle("Simula's Soups");


  }
}