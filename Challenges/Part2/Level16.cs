using System;
namespace Template;

///<summary>
/// LEVEL 16: Enumerations 
///</summary>
public static class Level16
{
  public static void CallAll()
  {
    SimulasTest();
  }

  /// <summary>
  /// Challenge 1/1: Simula's Test 
  ///<br/> As you move through the village of Enumerant, you notice a short, cloaked figure following you. Not being one to enjoy a mysterious figure tailing you, you seize a moment to confront the figure "Don't be alarmed," she says, "I am Simula. They are saying you're a Programmer. Is this true?" You answer in the affirmative, and Simula's eyes widen. "If you are truly a programmer, you will be able to help me. Follow me." She leads you back to a street and into a dimly lit hovel. She hands you a small locked chest "We haven't seen any programmers in these lands in a long time and especially not ones that can craft types. If you were a true programmer, you will want what is in that chest. And if you are a true programmer, I'll gladly give it to you to aid you in your quest."
  ///<br/> 
  ///<br/> The chest is a small box you can hold in your hand. The lid can be open, closed but unlocked, or locked. Normally you'd be able to go between these states, opening, closing, locking, and unlocking the box, but the box is broken. You need to create a program with an enumeration to recreate this locking mechanism. The image below shows how you can move between three states:
  ///<br/> 
  ///<br/> **Image:**
  ///<br/>   --------------------------------------------------
  ///<br/>   |      | close => |        | lock =>   |         |
  ///<br/>   | OPEN |          | CLOSED |           |  LOCKED |
  ///<br/>   |      | <= open  |        | <= unlock |         |
  ///<br/>   --------------------------------------------------
  ///<br/> 
  ///<br/> If you attempt an impossible action in the current state (like opening a locked box), nothing happens.
  ///<br/> 
  ///<br/> The program below shows what using this might look like:
  ///<br/> 
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   The chest is locked. What do you want to do? unlock 
  ///<br/>   The chest is unlocked. What do you want to do? open
  ///<br/>   The chest is open. What do you want to do? close
  ///<br/>   The chest is unlocked. What do you want to do?
  ///<br/>   
  ///<br/> OBJECTIVES: 
  ///<br/> [] Define an enumeration for the state of the chest. 
  ///<br/> [] Make a variable whose type is this new enumeration.
  ///<br/> [] Write code to allow you to manipulate the chest with the `lock`, `unlock`, `open`, and `close` commands, but ensure that you don't transition between states that don't support it.
  ///<br/> [] Loop forever, asking for the next command.
  /// </summary>
  public static void SimulasTest()
  {
    // Note: Enums can be defined in a class, but not inside a method!
    Utils.WriteTitle("Simula's Test");


  }
}




// public static class Level16
// {
//   // Where to define new types (like enumerations):
//   // Either after other code in the main method or in another file

//   // DEFINING ENUMERATION
//   // Example
//   enum Season { Winter, Spring, Summer, Fall }

//   // Compact style
//   enum EnumCompact { First, Second, Third }

//   // Expanded style
//   enum EnumExpanded
//   {
//     First,
//     Second,
//     Third
//   }

//   // With manually-provided value and auto-assigned values
//   enum EnumWithAssignedValues
//   {

//     First = 1,
//     Second, // 2
//     Third, // 3
//     Unknown = 0, // The default first auto-assigned value is 0, which also identifies an enumeration's default member.
//   }

//   // With all manually-provided values
//   // Since we manually override this enumeration's default, this enum has no legal default value anymore.
//   enum EnumWithNoDefault
//   {
//     First = 1,
//     Second = 20,
//     Third = 300
//   }

//   public static void Snippets()
//   {
//     Console.WriteLine(typeof(Enumerable));
//     // Console.WriteLine(Enumerable.ToArray<Season>(Season));

//     // DECLARING A VARIABLE WITH AN ENUMERATION TYPE
//     Season current;

//     // USING AN ENUMERATION MEMBER AS A VALUE
//     current = Season.Summer;

//     // USING ENUMERATION-TYPE VARIABLES IN EXPRESSIONS LIKE WITH OTHER VALUE TYPES
//     if (current == Season.Summer || current == Season.Winter) // Enumerations have much in common with integers.
//       Console.WriteLine("Happy solstice!");
//     else
//       Console.WriteLine("Happy equinox!");

//     // USING A BUILT-IN ENUMERATION
//     Console.ForegroundColor = ConsoleColor.Magenta;

//     Enum.
//   }

//   public static void Experiments()
//   {
//     // TODO
//     // Check underlying types
//     // Test casting and converting types of ints/enums
//     // Test comparisons between enums and ints
//     // Test comparisons between different enums with same underlying values
//     // Check what happens with a non-legitimate number for a cast enumeration?
//     // Check how can I use an enum's default?
//     // Check what happens if an enum default is invalid?
//     // Explore built-in `Enum`
//   }
// }

// public static class Level16Example
// {
//   public enum MaterialMetal { Gold, Silver, Bronze }
//   public enum Place 
//   { 
//     First = 1, 
//     Second, 
//     Third, 
//     Unknown = 0 
//     }

//   public static MaterialMetal Metal { get; set; } = MaterialMetal.Gold;
  
//   public static void UseEnum(Place place)
//   {
//     if (place == Place.First)
//       Console.WriteLine("I win! ");

//     // TODO Add logic to cast to int and check what the next place is, then write 'You suck, runneruphere!'
    
//   }

// }