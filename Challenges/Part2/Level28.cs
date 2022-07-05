using System;
namespace Template;

/// <summary>
/// LEVEL 28: Structs
/// </summary>
public static class Level28
{
  public static void CallAll()
  {
    RoomCoordinates();
  }

  /// <summary>
  /// Challenge 1/1: Room Coordinates 
  ///<br/> The time to enter the Fountain of Objects draws closer. While you don't know what to expect, you have found some scrolls that describe the area in ancient times. It seems to be structured as a set of rooms in a grid-like arrangement.
  ///<br/> 
  ///<br/> Locations of the room may be represented as a row and column, and you take it upon yourself to try to capture this concept with a new struct definition.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Create a `Coordinate` struct that can represent a room coordinate with a row and column.
  ///<br/> [] Ensure `Coordinate` is immutable.
  ///<br/> [] Make a method to determine if one coordinate is adjacent to another (differing only by a single row or a single column).
  ///<br/> [] Write a main method that creates a few coordinates and determines if they are adjacent to each other to prove that it is working correctly.
  /// </summary>
  public static void RoomCoordinates()
  {
    Utils.WriteTitle("Room Coordinates");


  }
}