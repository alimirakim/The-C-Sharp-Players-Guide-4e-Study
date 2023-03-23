
using System;
using static Complete.PartTwoC;
using static System.Console;

namespace Complete;

public static class PartTwoC
{
  // UTILITY
  public static void WriteTitle(string title)
  {
    string divider = "";
    for (int i = 0; i < title.Length; i++)
      divider += "-";

    Console.WriteLine("");
    Console.WriteLine(title);
    Console.WriteLine(divider);
  }

  public static void CallAll()
  {
    TheFountainOfObjects();
    SmallMediumOrLarge();
    Pits();
    Maelstroms();
    Amaroks();
    GettingArmed();
    GettingHelp();
    TheRobotPilot();
    TimeInTheCavern();
    ListsOfCommands();
  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Core) 1/7: The Fountain of Objects 
  /// The game The Fountain of Objects is a 2D grid-based world full of rooms. Most rooms are empty, but a few are unique rooms. One room is the cavern entrance. One room is the fountain room, containing the Fountain of Objects.
  /// 
  /// The player moves through the cavern system, one room at a time to find the Fountain of Objects. They activate it and then return to the entrance room. If they do this without falling into a pit, they win the game.
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
  /// [x] The games flow works like this: The player is told what they can sense in the dark (see, here, smell). Then the player gets a chance to perform some action by typing it in. Then their chosen action is resolved (the player moves, the state of things in the game changes, checking for a win or loss, etc.). Then the loop repeats.
  /// [x] Most rooms are empty rooms, and there is nothing to sense. 
  /// [x] The player is in one of the rooms and can move between them by running the following commands: "move north", "move south", "move east", and "move west". The player should not be able to move past the edge of the map.
  /// [x] The room at (Row=0, Column=0) is the cavern entrance (and exit). The player should start here. The player can sense light coming from outside the cavern when in this room. ("You see light in this room coming from outside the cavern. This is the entrance.") 
  /// [x] The room at (Row=0, Column=2) is the fountain room, containing the Fountain of Objects itself. The Fountain can be either enabled or disabled. The player can hear the fountain but hears different things depending on if it is on or not.("You hear water dripping in this room. The Fountain of Objects is here!" or "You hear the rushing waters from the Fountain of Objects. It has been reactivated!" The fountain is off initially in the fountain room. The player can type the command "enable fountain" to enable it. If the player is not in the fountain room, there should be no effect, and the player should be told so.
  /// [x] The player wins by moving to the fountain room, enabling the Fountain of Objects, and then moving to the cavern entrance. If the player is in the entrance and the fountain is on, the player wins.
  /// [x] Use different colors to display the different types of text in the console window. For example, narrative items (intro, ending, etc.) may be magenta, descriptive text in white, input from the user in cyan, text describing entrance light in yellow, messages about the fountain in blue.
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
  ///   
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
  /// 

// Record/Interface Location??
// type = entrance, pit, fountain
// description
// unique interaction??
// effect??
// state?? 
// ability to sense adjacent rooms
// ability to emit side-effects for adjacent rooms

    // Map
    //   Tracks map size
    //   Tracks location of items inside
    //   Tracks adjacencies



    // Items of interest? - entrance, fountain, pits
    //   Tracks its state (on, off, etc)
    //   Description (state-dependent)
    //   Associated color
    //   Possible interactions?

    // Game
    //   Runs game
    //   Houses everything together

    // UI
    //   Menu options
    //   Controls colors?

    // Player
    //   Tracks location
    //   



//public interface GameMap
//    {
//        public MapItem[,] Map;
//        public GameMapSize Size;
//
//        public void PrintMap()
//        public void InsertItemAt(MapItem item, Coordinate coordinate)
//        public Coordinate FindItemCoordinate(MapItem item)
//        public MapItem[] CheckAdjacentCoordinates(Coordinate coordinate)
//        public void MoveItem(Coordinate itemCoordinate, Coordinate newItemCoordinate)
//
//    }

// public interface IMapItem
// {
//     ConsoleColor Color { get; }
//     string Name { get; }
//     string Description { get; }
// 
//     void WriteDescription();
// }
// 
// public class Fountain : IMapItem
//     {
//         public ConsoleColor Color { get; } = ConsoleColor.Blue;
// 
//     }

public enum Direction { North, East, South, West }

public enum GameMapSize { None, Small, Medium, Large }

public enum GameColorStatus { Default, Warning, Death, Prompt, PlayerInput, Water, Light, Descriptive }

public enum RoomType { Empty, Entrance, Fountain, Pit }

public record Vector(int X, int Y);

public record GamePlayer(Vector Coordinate, bool IsAlive);

// TODO Does populating 2D array with records fill it with default records or null?
public record MapItem(
    RoomType Type=RoomType.Empty,
    string Description="The room is empty.", 
    ConsoleColor Color=ConsoleColor.Gray
    );

public class GameMap
    {
        public static readonly Vector FountainCoordinateSmall = new Vector(1,1);
        public static readonly Vector FountainCoordinateMedium = new Vector(4,4);
        public static readonly Vector FountainCoordinateLarge = new Vector(8,8);

        public MapItem[,] Map { get; init; }
        public GameMapSize Size { get; init; }
        public Vector FountainCoordinate { get; set; }

        public GameMap(GameMapSize size)
        {
            Size = size;

            int dimension = size switch
            {
                GameMapSize.Small => 4,
                GameMapSize.Medium => 6,
                GameMapSize.Large => 8,
            };
            Map = new MapItem[dimension, dimension];
            PopulateMap();
        }

        public void PopulateMap()
        {
            MapItem entrance = new MapItem(
                RoomType.Entrance,
                "You see light coming from the cavern entrance.",
                ConsoleColor.Yellow
            );
            MapItem fountain = new MapItem(
                RoomType.Fountain,
                "You hear water dripping in this room. The Fountain of Objects is here!", 
                ConsoleColor.Cyan
            );

            Map[0,0] = entrance;

            FountainCoordinate = Size switch
            {
                GameMapSize.Small => GameMap.FountainCoordinateSmall,
                GameMapSize.Medium => GameMap.FountainCoordinateMedium,
                GameMapSize.Large => GameMap.FountainCoordinateLarge,
                _ => new Vector(1,1)
            };

            Map[FountainCoordinate.X, FountainCoordinate.Y] = fountain;
        }

        public void EnableFountain()
        {
            Map[FountainCoordinate.X, FountainCoordinate.Y] = Map[FountainCoordinate.X, FountainCoordinate.Y] 
                with { Description = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!"};
        }

        public void AddPits()
        {
            MapItem pit = new MapItem(
                RoomType.Pit,
                "It was a trap! You fell into a pit and died.",
                ConsoleColor.Red
            );

            switch (Size)
            {
                case GameMapSize.Small:
                    Map[0,1] = pit;
                    break;
                case GameMapSize.Medium:
                    Map[2,3] = pit;
                    break;
                case GameMapSize.Large:
                    Map[6,6] = pit;
                    break;
                default:
                    break;
            }
        }

        public RoomType GetAdjacentRoomType(Vector coordinate, Direction direction)
        {
            Vector adjacentCoordinate = AttemptMove(coordinate, direction);

            // prevent logic bug that treats current room as an adjacent room
            if (coordinate == adjacentCoordinate) 
                return RoomType.Empty;

            return Map[adjacentCoordinate.X, adjacentCoordinate.Y]?.Type ?? RoomType.Empty;
        }

        public bool CheckAdjacentRoomsForPits(Vector coordinate)
        {
            RoomType northRoom = GetAdjacentRoomType(coordinate, Direction.North);
            RoomType eastRoom = GetAdjacentRoomType(coordinate, Direction.East);
            RoomType southRoom = GetAdjacentRoomType(coordinate, Direction.South);
            RoomType westRoom = GetAdjacentRoomType(coordinate, Direction.West);
            RoomType[] adjacentRoomTypes = { northRoom, eastRoom, southRoom, westRoom };

            bool isNearPit = Array.Exists(adjacentRoomTypes, roomType => roomType == RoomType.Pit);

            return isNearPit;
        }

        public void PrintMap()
        {
            // TODO
        }

        // Return new coordinate if move in direction is valid on map.
        // Else return original coordinate.
        public Vector AttemptMove(Vector coordinate, Direction direction)
        {
            Vector newCoordinate = direction switch
            {
                Direction.North => coordinate with { X = coordinate.X + 1 },
                Direction.East => coordinate with { Y = coordinate.Y + 1 },
                Direction.South => coordinate with { X = coordinate.X - 1 },
                Direction.West => coordinate with { Y = coordinate.Y - 1 },
            };

            if (newCoordinate.X < 0 || newCoordinate.X > Map.GetLength(0) || newCoordinate.Y < 0 || newCoordinate.Y > Map.GetLength(1)) 
                return coordinate;
            else 
                return newCoordinate;
        }

        public bool CheckIsMovingOutside(Vector coordinate, Direction direction)
        {
            if (coordinate.X == 0 && coordinate.Y == 0 && direction == Direction.South) 
                return true;
            else
                return false;
        }
    }

public static class GameUI
    {
        // methods
        public static void IntroduceGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("THE FOUNTAIN OF OBJECTS GAME");
            Console.WriteLine("============================");
            Console.WriteLine(@"
Welcome, hero. You have entered a cavern filled with maze-like rooms.
You must find the fountain of objects, activate, and return to the entrance safely to win.
Good luck...
");
            SetGameColor();

            Console.WriteLine("menu:");
            DescribeMenu();
        }

        public static GameMapSize PromptPlayerChooseGameSize()
        {
            Console.WriteLine(@"1 - Small (4x4)
2 - Medium (6x6)
3 - Large (8x8)
");

            GameMapSize selectedMapSize = default(GameMapSize);

            while (selectedMapSize == GameMapSize.None)
            {
                SetGameColor(GameColorStatus.Prompt);
                Console.Write("What size map do you want to play in? ");
                SetGameColor(GameColorStatus.PlayerInput);
                string option = Console.ReadLine();
                SetGameColor();

                switch (option)
                {
                    case "1":
                        selectedMapSize = GameMapSize.Small;
                        break;
                    case "2":
                        selectedMapSize = GameMapSize.Medium;
                        break;
                    case "3":
                        selectedMapSize = GameMapSize.Large;
                        break;
                    default:
                        Console.WriteLine("That's not an option.");
                        break;
                }

                DrawBorder();
                Console.WriteLine();
            }
            return selectedMapSize;
        }

        public static void DescribePlayerCoordinate(Vector coordinate)
        {
            Console.WriteLine($"You are in the room at (Row={coordinate.X} Column={coordinate.Y}).");
        }

        public static void SetGameColor(GameColorStatus status=GameColorStatus.Default)
        {
            Console.ForegroundColor = status switch
            {
                GameColorStatus.Warning => ConsoleColor.DarkRed,
                GameColorStatus.Death => ConsoleColor.Red,
                GameColorStatus.Prompt => ConsoleColor.DarkMagenta,
                GameColorStatus.PlayerInput => ConsoleColor.Magenta,
                GameColorStatus.Water => ConsoleColor.Cyan,
                GameColorStatus.Light => ConsoleColor.Yellow,
                GameColorStatus.Descriptive => ConsoleColor.DarkGray,
                _ => ConsoleColor.White,
            };
        }

        public static void DescribeRoom(MapItem roomContent)
        {   
            if (roomContent == null)
            {
                SetGameColor(GameColorStatus.Descriptive);
                Console.WriteLine("The room is empty.");
            } else
            {
                Console.ForegroundColor = roomContent.Color;
                Console.WriteLine(roomContent.Description);
            }

            SetGameColor();
        }

        public static void DescribeNearbyHazard(RoomType nearbyRoomType)
        {
            if (nearbyRoomType == RoomType.Pit)
            {
                Console.WriteLine();
                SetGameColor(GameColorStatus.Warning);
                Console.WriteLine("You feel a draft. There is a pit in a nearby  room....");
                SetGameColor();
                Console.WriteLine();
            }
        }

        public static void DescribeWin()
        {
            SetGameColor(GameColorStatus.Light);
            Console.WriteLine(@"
You activated the Fountain of Objects and escaped with your life!
You win!");
        }

        public static void DescribeLoss()
        {
            SetGameColor(GameColorStatus.Death);
            Console.WriteLine("You lose.");

        }

        public static void DescribeEnableFountain(bool isAbsent, bool isDisabled)
        {
            SetGameColor(GameColorStatus.Descriptive);
            if (isAbsent && isDisabled)
                Console.WriteLine("The Fountain of Objects isn't here. Keep searching!");
            else if (isDisabled)
                Console.WriteLine("You activated the Fountain of Objects! Good job!");
            else 
                Console.WriteLine("You already activated the Fountain of Objects. Now find your way out!");
            SetGameColor();
            Console.WriteLine();
        }

        public static void DescribeAttemptMove(bool isAttemptingExit, bool isAttemptingOutOfBounds, Direction direction)
        {
            SetGameColor(GameColorStatus.Descriptive);

            if (isAttemptingExit) 
                Console.WriteLine("You can't leave! You haven't activated the Fountain of Objects yet!");
            else if (isAttemptingOutOfBounds) 
                Console.WriteLine("You feel a wall in the way. You can't go in that direction.");
            else
                Console.WriteLine("You walk into the " + direction + " room.");

            Console.WriteLine();
            SetGameColor();
        }

        public static void DescribeDenyAction()
        {
            SetGameColor(GameColorStatus.Descriptive);
            Console.WriteLine("You can't do that.");
            Console.WriteLine();
            SetGameColor();
        }

        public static void DescribeMenu()
        {
            SetGameColor(GameColorStatus.Descriptive);
            Console.WriteLine("quit | menu | go north | go east | go south | go west | enable fountain");
            Console.WriteLine();
            SetGameColor();
        }

        public static string PromptPlayerAction()
        {
            SetGameColor(GameColorStatus.Prompt);
            Console.Write("What do you want to do? ");
            
            SetGameColor(GameColorStatus.PlayerInput);
            string action = Console.ReadLine().ToLowerInvariant();

            SetGameColor();
            DrawBorder();

            return action;
        }

        public static void DrawBorder()
        {
            Console.WriteLine("=================================");

        }
    }

    public class GameFountainOfObjects
    {
        // properties
        public bool IsGameActive { get; set; } = true;
        public bool IsFountainActive { get; set; } = false;
        public GamePlayer Player { get; set; } = new GamePlayer(new Vector(0,0), true); 
        public GameMap Map { get; set; }

        // methods
        public void RunGame()
        {
            GameUI.IntroduceGame();
            Map = new GameMap(GameUI.PromptPlayerChooseGameSize());
            Map.AddPits();
            
             while (IsGameActive)
            {
                GameUI.DescribePlayerCoordinate(Player.Coordinate);
                GameUI.DescribeRoom(Map.Map[Player.Coordinate.X, Player.Coordinate.Y]);
                bool isNearbyPit = Map.CheckAdjacentRoomsForPits(Player.Coordinate);
                
                GameUI.DescribeNearbyHazard(isNearbyPit ? RoomType.Pit : RoomType.Empty);

                if (CheckWin()) 
                {
                    GameUI.DescribeWin();
                    IsGameActive = false;
                    break;
                }
                if (CheckLoss())
                {
                    GameUI.DescribeLoss();
                    IsGameActive = false;
                    break;
                }

                string action = GameUI.PromptPlayerAction();
                switch (action)
                {
                    case "quit":
                        IsGameActive = false;
                        break;

                    case "menu":
                        GameUI.DescribeMenu();
                        break;

                    case "enable fountain":
                        AttemptEnableFountain();
                        break;

                    case "go north":
                        AttemptMove(Direction.North);
                        break;
                    case "go east":
                        AttemptMove(Direction.East);
                        break;
                    case "go south":
                        AttemptMove(Direction.South);
                        break;
                    case "go west":
                        AttemptMove(Direction.West);
                        break;

                    default:
                        GameUI.DescribeDenyAction();
                        break;
                }
            }
             Console.ReadLine();
        }

        public void AttemptEnableFountain()
        {
            bool isFountainHere = CheckLocation() == RoomType.Fountain;

            // Must do this before changing IsFountainActive status.
            GameUI.DescribeEnableFountain(!isFountainHere, !IsFountainActive);

            if (isFountainHere && !IsFountainActive) 
            {
                IsFountainActive = true;
                Map.EnableFountain();
            }
            
        }
            
        public void AttemptMove(Direction direction)
        {
            Vector originalCoordinate = Player.Coordinate;
            Player = Player with { Coordinate = Map.AttemptMove(Player.Coordinate, direction) };

            bool isTargetOutside = Map.CheckIsMovingOutside(originalCoordinate, direction);
            bool isTargetOutOfBounds = originalCoordinate == Player.Coordinate;

            GameUI.DescribeAttemptMove(isTargetOutside, isTargetOutOfBounds, direction);
        }

        public RoomType? CheckLocation()
        {
            return Map.Map[Player.Coordinate.X, Player.Coordinate.Y]?.Type;
        }

        public bool CheckLoss()
        {
            if (CheckLocation() == RoomType.Pit) return true;
            else return false;
        }

        public bool CheckWin()
        {
            return IsFountainActive && CheckLocation() == RoomType.Entrance;
        }
    }

  public static void TheFountainOfObjects()
  {
    WriteTitle("The Fountain of Objects");

    GameFountainOfObjects game = new GameFountainOfObjects();
    game.RunGame();
  }






  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 2/7: Small, Medium, or Large 
  /// The larger the Cavern of Objects is, the more difficult the game becomes. The basic game only requires a small 4x4 world, but we will add a medium 6x6 world and a larger 8x8 world to complete this challenge.
  /// 
  /// **Objectives:** 
  /// [] Before the game begins, ask the player whether they want to play a small, medium, or large game. Create a 4x4 world if they choose a small world, a 6x6 world if they choose a medium world, and an 8x8 world if they choose a large world.
  /// [] Pick an appropriate location for both the Fountain Room and the Entrance room.
  /// - Note: When combined with the Amaroks, Maelstroms, or Pits challenges, you will need to adapt the game to handle adding amaroks, maelstroms, and pits to all three sizes.
  /// </summary>
  public static void SmallMediumOrLarge()
  {
    WriteTitle("Small, Medium, or Large");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 3/7: Pits 
  /// The Cavern of Objects is a dangerous place. Some rooms upen up to bottomless pits. Entering a pit means death. The player can sense a pit is  in an adjacent room decause a draft of air pushes through the pits into adjacent rooms. Add pit rooms to the game and end the game if the player   stumbles into one.
  /// 
  /// **Objectives:** 
  /// [] Add a pit room to your 4x4 cavern in a location of your choice, except the fountain and entrance rooms.
  /// [] Players can sense the draft pushing out of pits in adjacent rooms (all eight directions): "You feel a draft. There is a pit in a nearby  room."
  /// [] If a player ends their turn in a room with a pit, they lose the game.
  /// [] Note: When combined with the Small, Medium, or Large challenge, add one pit to the 4x4 world, two pits to the 6x6 world, and four pits to  the 8x8 world, in locations of your choice.
  /// </summary>
  public static void Pits()
  {
    WriteTitle("Pits");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 4/7: Maelstroms 
  /// TODO Add description
  /// 
  /// **Objectives:** 
  /// [] Add a maelstrom to the small 4x4 game in a location of your choice.
  /// [] The player can sense maelstroms by hearing them in adjacent rooms. ("You hear the growling and groaning of a maelstrom nearby.")
  /// If a player enters a room with a maelstrom, the player moves one space north and two spaces east, while the maelstrom moves one space south   and two spaces west. When the player is moved like this, tell them so. If this would move the player or maelstrom beyond the map's edge, ensure they stay on the map.
  /// [] Note: When combined with the Small, Medium, or Large challenge, place one maelstrom into the medium-sized game and two into the  large-sized game.
  /// </summary>
  public static void Maelstroms()
  {
    WriteTitle("Maelstroms");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 5/7: Amaroks 
  /// TODO
  /// 
  /// **Objectives:** 
  /// [] The placement of amaroks is at your discretion. Pick a room to place an amarok aside from the entrance or fountain room in the small 4x4   world.
  /// [] When a player is in one of the eight spaces adjacent to an amarok, a message should be displayed when sensing surrounding that indicate  that the player can smell the amarok nearby. For example, "You can smell the rotten stench of an amarok in a nearby room."
  /// [] When a player enters a room with an amarok, the player dies and loses the game.
  /// [] Note: When combined with the Small, Medium, or Large challenge, place two amaroks in the medium level and three in the large level in  locations of your choosing.
  /// </summary>
  public static void Amaroks()
  {
    WriteTitle("Amaroks");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 6/7: Getting Armed 
  /// TODO
  /// 
  /// **Objectives:** 
  /// [] Add the following commands that allow a player to shoot in any of the foor directions: shoot north, shoot east, shoot south, and shoot   west. When the player shoots in one of the four directions, an arrow is fired into the room in that direction. If a monster is in that room, it is killed and should not affect the game anymore. (They can no longer sense it, and it should not affect the player.)
  /// [] The player only has a limited number of arrows (5) and cannot shoot when they are out of arrows. Display the number of arrows the player   has when displaying the game's status before asking for their action.
  /// </summary>
  public static void GettingArmed()
  {
    WriteTitle("Getting Armed");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 7/7: Getting Help 
  /// 
  /// 
  /// **Objectives:** 
  /// [] When the game starts, display text that describes the game shown below:
  /// **Sample Program:**
  ///   You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search
  ///   of the Fountain of Objects.
  ///   Light is visible only in the entrance, and no other light is seen anywhere in the caverns.
  ///   You must navigate the Caverns with your other senses.
  ///   Find the Fountain of Objects, activate it, and return to the entrance.
  /// [] If you choose to to the Pits challenge, add the following to the description: "Look out for pits. You will feel a breeze if a pit is in  an adjacent room. If you enter a room with a pit, you will die."
  /// [] If you chose to do the Maelstroms challenge, add the following to the description: "Maelstroms are violent forces of sentient wind.  Entering a room with one could transport you to any other location in the caverns. You will be able to hear their growling and groaning in   nearby rooms."
  /// [] If you chose to do the Getting Armed challenge, add the following to the description: "You carry with you a bow and a quiver of arrows.  You can use them to shoot monsters in the caverns but be warned: you have a limited supply."
  /// [] When the player types the command `help`, display all available commands and a short description of what each does. The complete list of   commands will depend on what challenges you complete.
  /// </summary>
  public static void GettingHelp()
  {
    WriteTitle("Getting Help");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 32: Some Useful Types 
  /// Challenge 1/3: The Robot Pilot 
  /// When we first made the Hunting the Manticore game in Level 14, we required two human players: one to set up the Manticore's range from the  city and the other to destroy it. With `System.Random`, we can turn this into a single-player game by randomly picking the range for the   Manticore.
  /// 
  /// **Objectives:** 
  /// [] Modify your Hunting the Manticore game to be a single-player game by having the computer pick a random range between 0 and 100.
  /// [] Answer this question: How might you use inheritance, polymorphism, or interfaces to allow the game to be either a single player (the   computer randomly chooses the starting location and direction) or two players (the second human determines the starting location and direction)?
  /// </summary>
  public static void TheRobotPilot()
  {
    WriteTitle("The Robot Pilot");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 32: Some Useful Types <br/>
  /// Challenge 2/3: Time in the Cavern 
  /// With `System.DateTime` and `System.TimeSpan`, you can keep track of how much time a player spends in the Cavern of Objects to beat the game. With these tools, modify your Fountain of Objects game to display how much time a player spent exploring the caverns.
  /// 
  /// **Objectives:** 
  /// [] When a new game begins, capture the current time using `System.DateTime`.
  /// [] When a game finishes (win or loss), capture the current time.
  /// [] Use `System.TimeSpan` to compute how much time elapsed and display that to the player.
  /// </summary>
  public static void TimeInTheCavern()
  {
    WriteTitle("Time in the Cavern");


  }

  // *************************************************************************************************

  ///<summary>
  /// LEVEL 32: Some Useful Types 
  /// Challenge 3/3: Lists of Commands 
  /// In Level 27, we encountered a robot that had an array to hold commands to run. But we could make the robot have as many commands as we want by turning the array into a list. Revisit that challenge to make the robot use a list instead of an array, and add commands to run until the user says to stop.
  /// 
  /// **Objectives:** 
  /// [] Change the `Robot` class to use a `List<IRobotCommand>` instead of an array for its `Commands` property. (Don't forget the `using` directive for `System.Collections.Generic`.)
  /// [] Instead of looping three times, go until the user types `stop`. Then run all of the commands created.
  /// </summary>
  public static void ListsOfCommands()
  {
    WriteTitle("Lists of Commands");


  }
}