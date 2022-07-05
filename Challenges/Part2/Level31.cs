using System;
namespace Template;

/// <summary>
/// LEVEL 31: The Fountain of Objects 
/// </summary>
public class Level31
{
  public static void CallAll()
  {
    TheFountainOfObjects(); // The other challenges extend this core game challenge
  }


  /// <summary>
  /// Boss Battle (Core) 1/7: The Fountain of Objects 
  /// The game The Fountain of Objects is a 2D grid-based world full of rooms. Most rooms are empty, but a few are unique rooms. One room is the cavern entrance. One room is the fountain room, containing the Fountain of Objects.
  /// 
  /// The player moves through the cavern system, one room at a time to find the Fountain of Objects. They activat it and then return to the entrance room. If they do this without falling into a pit, they win the game.
  /// 
  /// Unnatural darkness pervades the caverns, preventing both natural and human-made light. The player must navigate the caverns in the dark, relying on their sense of smell and hearing to determine what room they are in and what dangers lurk in nearby rooms.
  /// 
  /// This challenge serves as the basis for the other challenges in this level. It must be completed before the others can be started. The requirements of this game are listed below.
  /// **Objectives:** 
  /// [] The world consists of a grid of rooms, where each room can be referenced by its row and column. North is up, east is right, south is down, and west is left:
  /// **Image:** 
  ///   |----|----|----|----|
  ///   |    |    |    |    | 0                 
  ///   |----|----|----|----|                 North
  ///   |    |    |    |    | 1  R              ^ 
  ///   |----|----|----|----|    o       West < + > East
  ///   |    |    |    |    | 2  w              v
  ///   |----|----|----|----|                 South
  ///   |    |    |    |    | 3
  ///   |----|----|----|----|
  ///     0    1    2    3
  ///          Column
  ///        
  /// [] The games flow works like this: The player is told what they can sense in the dark (see, here, smell). Then the player gets a chance to perform some action by typing it in. Then their chosen action is resolved (the player moves, the state of things in the game changes, checking for a win or loss, etc.). Then the loop repeats.
  /// [] Most rooms are empty rooms, and there is nothing to sense. 
  /// [] The player is in one of the rooms and can move between them by running the following commands: "move north", "move south", "move east", and "move west". The player should not be able to move past the edge of the map.
  /// [] The room at (Row=0, Column=0) is the cavern entrance (and exit). The player should start here. The player can sense light coming from outside the cavern when in this room. ("You see light in this room coming from outside the cavern. This is the entrance.") 
  /// [] The room at (Row=0, Column=2) is the fountain room, containing the Fountain of Objects itself. The Fountain can be either enabled or disabled. The player can hear the fountain but hears different things depending on if it is on or not.("You hear water dripping in this room. The Fountain of Objects is here!" or "You hear the rushing waters from the Fountain of Objects. It has been reactivated!" The fountain is off initially in the fountain room. The player can type the command "enable fountain" to enable it. If the player is not in the fountain room, there should be no effect, and the player should be told so.
  /// [] The player wins by moving to the fountain room, enabling the Fountain of Objects, and then moving to the cavern entrance. If the player is in the entrance and the fountain is on, the player wins.
  /// [] Use different colors to display the different types of text in the console window. For example, narrative items (intro, ending, etc.) may be magenta, descriptive text in white, input from the user in cyan, text describing entrance light in yellow, messages about the fountain in blue.
  /// An example of what the program might look like is shown below:
  /// **Sample Program:**
  ///   You are in the room at (Row=0, Column=0).
  ///   You see light coming from the cavern entrance. 
  ///   What do you want to do? move east
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=1).
  ///   What do you want to do? move east
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=2).
  ///   You hear water dripping in this room. The Fountain of Objects is here!
  ///   What do you want to do? enable fountain
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=2).
  ///   You hear the rushing waters from the Fountain of Objects. It has been reactivated!
  ///   What do you want to do? move west
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=1).
  ///   What do you want to do? move west
  ///   ----------------------------------------------
  ///   You are in the room at (Row=0, Column=0).
  ///   The Fountain of Objects has been reactivated, and you have escaped with your life!
  ///   You win!
  ///   
  /// - Hint: You may find two-dimensional arrays(Level 12) helpful and representing a 2D grid-based game world.
  /// - Hint: Remember your training! You do not need to solve this entire problem all at once, and you do not have to get it right in your first attempt. Pick an item or two to start, then plot a course to solve just those items. Rework until you're happy with it, then add in the next item or two.
  /// </summary>
  public static void TheFountainOfObjects()
  {
    Utils.WriteTitle("The Fountain of Objects");


  }

  /// <summary>
  ///<br/> Boss Battle (Expansion) 2/7: Small, Medium, or Large 
  ///<br/> The larger the Cavern of Objects is, the more difficult the game becomes. The basic game only requires a small 4x4 world, but we will add a   medium 6x6 world and a larger 8x8 world to complete this challenge.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Before the game begins, ask the player whether they want to play a small, medium, or large game. Create a 4x4 world if they choose a   small world, a 6x6 world if they choose a medium world, and an 8x8 world if they choose a large world.
  ///<br/> [] Pick an appropriate location for both the Fountain Room and the Entrance room.
  ///<br/> - Note: When combined with the Amaroks, Maelstroms, or Pits challenges, you will need to adapt the game to handle adding amaroks,   maelstroms, and pits to all three sizes.
  /// </summary>
  public static void SmallMediumOrLarge()
  {
    Utils.WriteTitle("Small, Medium, or Large");


  }

  /// <summary>
  ///<br/> Boss Battle (Expansion) 3/7: Pits 
  ///<br/> The Cavern of Objects is a dangerous place. Some rooms upen up to bottomless pits. Entering a pit means death. The player can sense a pit is  in an adjacent room decause a draft of air pushes through the pits into adjacent rooms. Add pit rooms to the game and end the game if the player   stumbles into one.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Add a pit room to your 4x4 cavern in a location of your choice, except the fountain and entrance rooms.
  ///<br/> [] Players can sense the draft pushing out of pits in adjacent rooms (all eight directions): "You feel a draft. There is a pit in a nearby  room."
  ///<br/> [] If a player ends their turn in a room with a pit, they lose the game.
  ///<br/> [] Note: When combined with the Small, Medium, or Large challenge, add one pit to the 4x4 world, two pits to the 6x6 world, and four pits to  the 8x8 world, in locations of your choice.
  /// </summary>
  public static void Pits()
  {
    Utils.WriteTitle("Pits");


  }

  /// <summary>
  /// Boss Battle (Expansion) 4/7: Maelstroms 
  ///<br/> TODO Add description
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Add a maelstrom to the small 4x4 game in a location of your choice.
  ///<br/> [] The player can sense maelstroms by hearing them in adjacent rooms. ("You hear the growling and groaning of a maelstrom nearby.")
  ///<br/> If a player enters a room with a maelstrom, the player moves one space north and two spaces east, while the maelstrom moves one space south   and two spaces west. When the player is moved like this, tell them so. If this would move the player or maelstrom beyond the map's edge, ensure   they stay on the map.
  ///<br/> [] Note: When combined with the Small, Medium, or Large challenge, place one maelstrom into the medium-sized game and two into the  large-sized game.
  /// </summary>
  public static void Maelstroms()
  {
    Utils.WriteTitle("Maelstroms");


  }

  /// <summary>
  ///<br/> Boss Battle (Expansion) 5/7: Amaroks 
  ///<br/> TODO Add description
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] The placement of amaroks is at your discretion. Pick a room to place an amarok aside from the entrance or fountain room in the small 4x4   world.
  ///<br/> [] When a player is in one of the eight spaces adjacent to an amarok, a message should be displayed when sensing surrounding that indicate  that the player can smell the amarok nearby. For example, "You can smell the rotten stench of an amarok in a nearby room."
  ///<br/> [] When a player enters a room with an amarok, the player dies and loses the game.
  ///<br/> [] Note: When combined with the Small, Medium, or Large challenge, place two amaroks in the medium level and three in the large level in  locations of your choosing.
  /// </summary>
  public static void Amaroks()
  {
    Utils.WriteTitle("Amaroks");


  }

  /// <summary>
  ///<br/> Boss Battle (Expansion) 6/7: Getting Armed 
  ///<br/> TODO Add description
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Add the following commands that allow a player to shoot in any of the foor directions: shoot north, shoot east, shoot south, and shoot   west. When the player shoots in one of the four directions, an arrow is fired into the room in that direction. If a monster is in that room, it   is killed and should not affect the game anymore. (They can no longer sense it, and it should not affect the player.)
  ///<br/> [] The player only has a limited number of arrows (5) and cannot shoot when they are out of arrows. Display the number of arrows the player   has when displaying the game's status before asking for their action.
  /// </summary>
  public static void GettingArmed()
  {
    Utils.WriteTitle("Getting Armed");


  }

  /// <summary>
  ///<br/> Boss Battle (Expansion) 7/7: Getting Help 
  ///<br/> TODO Add description
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] When the game starts, display text that describes the game shown below:
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search
  ///<br/>   of the Fountain of Objects.
  ///<br/>   Light is visible only in the entrance, and no other light is seen anywhere in the caverns.
  ///<br/>   You must navigate the Caverns with your other senses.
  ///<br/>   Find the Fountain of Objects, activate it, and return to the entrance.
  ///<br/> [] If you choose to to the Pits challenge, add the following to the description: "Look out for pits. You will feel a breeze if a pit is in  an adjacent room. If you enter a room with a pit, you will die."
  ///<br/> [] If you chose to do the Maelstroms challenge, add the following to the description: "Maelstroms are violent forces of sentient wind.  Entering a room with one could transport you to any other location in the caverns. You will be able to hear their growling and groaning in   nearby rooms."
  ///<br/> [] If you chose to do the Getting Armed challenge, add the following to the description: "You carry with you a bow and a quiver of arrows.  You can use them to shoot monsters in the caverns but be warned: you have a limited supply."
  ///<br/> [] When the player types the command `help`, display all available commands and a short description of what each does. The complete list of   commands will depend on what challenges you complete.
  /// </summary>
  public static void GettingHelp()
  {
    Utils.WriteTitle("Getting Help");


  }
}