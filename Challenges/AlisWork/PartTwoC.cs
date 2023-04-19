
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
    // TheFountainOfObjects();
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

  // ***********************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Core) 1/7: The Fountain of Objects 
  /// The game The Fountain of Objects is a 2D grid-based world full of rooms. Most rooms are empty, but a few are unique rooms. One room is the cavern entrance. One room is the fountain room, containing the Fountain of Objects.
  /// 
  /// The player moves through the cavern system, one room at a time to find the Fountain of Objets. They activate it and then return to the entrance room. If they do this without falling into a pit, they win the game.
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

  // TODO Make monster hazards functional
  // Must check map for IMoveableEntity in rooms through map array
  // Must make maelstroms have collision effect of moving player and self

  // ###############################################################################################
  // ENUMS
  public enum GameColorStatus { Default, Warning, Death, Prompt, PlayerInput, Water, Light, Descriptive }

  public enum GameMapSize { Small, Medium, Large }

  public enum GameStatus { Inactive, Active, Won, Lost }

  // ###############################################################################################
  // RECORDS
  public record PromptOption(string Input, string Description);

  // TODO Ask greem why this doesn't work; get a 'constant needed' type error
  public record Command()
  {
    public static readonly string Quit = "quit";
    public static readonly string Help = "help";
    public static readonly string GoNorth = "go north";
    public static readonly string GoEast = "go east";
    public static readonly string GoSouth = "go south";
    public static readonly string GoWest = "go west";
    public static readonly string EnableFountain = "enable fountain";
  }

  public record Vector(int X = 0, int Y = 0)
  {
    public static readonly Vector Origin = new Vector(0, 0);
    public static readonly Vector North = new Vector(1, 0);
    public static readonly Vector East = new Vector(0, 1);
    public static readonly Vector South = new Vector(-1, 0);
    public static readonly Vector West = new Vector(0, -1);
    public static readonly Vector[] Directions = { North, East, South, West };

    public Vector Add(Vector vector) => this with { X = this.X + vector.X, Y = this.Y + vector.Y };

    public bool CheckIsValid(int mapSize) => !(X < 0 || Y < 0 || X >= mapSize || Y >= mapSize);
  }

  public record Player(Vector Location, bool IsAlive = true) : IMoveableEntity
  {
    public IMoveableEntity Move(Vector direction) => this with { Location = this.Location.Add(direction) };
  }

  public record RoomEmpty() : IDescriptive
  {
    public string Description => "The room is empty. ";
    public ConsoleColor Color => ConsoleColor.DarkGray;
  }

  public record RoomEntrance() : IDescriptive
  {
    public string Description => "You see light coming from the cavern entrance.";
    public ConsoleColor Color => ConsoleColor.Yellow;
  }

  public record RoomPit() : IDescriptive, IHazard
  {
    public string Description => "It was a trap! You fell into a pit and died.";
    public string DescriptionNearby { get; } = "You feel a draft. There is a pit in a nearby  room....";
    public ConsoleColor Color => ConsoleColor.Red;
  }

  public record RoomFountain(bool IsEnabled = false) : IDescriptive
  {
    public string Description => "You hear water dripping in this room. The Fountain of Objects is here!";
    public string DescriptionEnabled => "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
    public ConsoleColor Color => ConsoleColor.Cyan;
  }

  public record MonsterMaelstrom(Vector Location) : IMonster
  {
    public string DescriptionNearby { get; } = "You hear the growling and groaning of a maelstrom nearby.";
    public string Description { get; } = "You encounter a maelstrom in the room! It blows you away!";
    public ConsoleColor Color => ConsoleColor.Red;

    public void CollideWithPlayerEffect()
    {
      throw new NotImplementedException();
    }

    public IMoveableEntity Move(Vector direction) => this with
    {
      Location = this.Location.Add(direction)
    };
  }

  public record MonsterAmarok(Vector Location) : IMonster
  {

    public string DescriptionNearby { get; } = "You can smell the rotten stench of an amarok in a nearby room.";
    public string Description { get; } = "You encounter an amarok! It chases you down and kills you.";
    public ConsoleColor Color => ConsoleColor.Red;

    public void CollideWithPlayerEffect()
    {
      throw new NotImplementedException();
    }

    public IMoveableEntity Move(Vector direction) => this with
    {
      Location = this.Location.Add(direction)
    };
  }

  // ###############################################################################################
  // STRUCTS

  public struct Map
  {
    // properties
    public IDescriptive[,] Matrix { get; init; }
    public IMoveableEntity PlayerEntity { get; set; } = new Player(new Vector());
    public IMoveableEntity[] MoveableEntities { get; }

    // constructor
    public Map(GameMapSize size)
    {
      IDescriptive _ = new RoomEmpty();
      IDescriptive E = new RoomEntrance();
      IDescriptive F = new RoomFountain();
      IDescriptive P = new RoomPit();

      switch (size)
      {
        case GameMapSize.Large:
          Matrix = new IDescriptive[,]
          {
                    { E, _, _, _, _, _, _, _ },
                    { F, _, _, _, _, _, _, _ },
                    { _, _, _, _, _, _, _, _ },
                    { P, _, _, _, _, _, _, _ },
                    { _, _, _, _, _, _, _, _ },
                    { _, _, _, _, _, _, _, _ },
                    { _, P, _, _, _, _, _, _ },
                    { _, _, _, _, _, _, _, _ },
          };

          MoveableEntities = new IMoveableEntity[]
          {
                    new MonsterMaelstrom(new Vector(2,0)),
                    new MonsterAmarok(new Vector(0,2)),
          };
          break;

        case GameMapSize.Medium:
          Matrix = new IDescriptive[,]
      {
                { E, _, _, _, _, _ },
                { _, _, _, _, _, _ },
                { _, _, _, _, _, _ },
                { _, _, F, _, _, _ },
                { _, P, _, _, _, _ },
                { _, _, _, _, _, _ },
      };

          MoveableEntities = new IMoveableEntity[]
          {
                    new MonsterMaelstrom(new Vector(2,0)),
                    new MonsterAmarok(new Vector(0,2)),
          };
          break;

        default:
          Matrix = new IDescriptive[,]
      {
                { E, P, _, _ },
                { _, F, _, _ },
                { _, _, _, _ },
                { _, _, _, _ },
      };

          MoveableEntities = new IMoveableEntity[]
          {
                    new MonsterMaelstrom(new Vector(2,0)),
                    new MonsterAmarok(new Vector(0,2)),
          };
          break;
      }
    }

    // methods
    public bool CheckIsFountainEnabled()
    {
      Vector fountainLocation = GetFountainLocation();
      // TY denexapp this is how to explicitly cast inline
      return ((RoomFountain)Matrix[fountainLocation.X, fountainLocation.Y]).IsEnabled;
    }

    public bool AttemptEnableFountain()
    {

      Vector fountainLocation = GetFountainLocation();
      bool isAtFountain = PlayerEntity.Location == fountainLocation;

      if (isAtFountain)
      {
        Matrix[fountainLocation.X, fountainLocation.Y] = new RoomFountain(true);
        return true;
      }
      else
        return false;
    }

    public Vector GetFountainLocation()
    {
      for (int x = 0; x < Matrix.GetLength(0); x++)
      {
        for (int y = 0; y < Matrix.GetLength(1); y++)
        {
          if (Matrix[x, y] is RoomFountain)
          {
            return new Vector(x, y);
          }
        }
      }

      // TODO This is to avoid error for not returning a value, but game logic means there should always be a fountain to find
      // How to deal with such situations?
      return new Vector(1, 1);
    }

    public bool MoveItem(IMoveableEntity item, Vector direction)
    {
      for (int i = 0; i < MoveableEntities.Length; i++)
      {
        if (item != MoveableEntities[i])
          continue;

        IMoveableEntity updatedItem = item.Move(direction);
        bool isMoveValid = updatedItem.Location.CheckIsValid(Matrix.GetLength(0));

        if (isMoveValid)
          MoveableEntities[i] = updatedItem;

        return isMoveValid;
      }
      return false;
    }

    public bool MovePlayer(Vector direction)
    {
      IMoveableEntity updatedPlayerEntity = PlayerEntity.Move(direction);
      bool isMoveValid = updatedPlayerEntity.Location.CheckIsValid(Matrix.GetLength(0));

      if (isMoveValid)
        PlayerEntity = updatedPlayerEntity;

      return isMoveValid;
    }

    public void DescribePlayerLocation()
    {
      Console.WriteLine($"You are in the room at (Row={PlayerEntity.Location.X} Column={PlayerEntity.Location.Y}).");
    }

    public bool CheckAdjacentRoomsForRoomT<T>(Vector location)
    {
      Vector[] directions = { Vector.North, Vector.East, Vector.South, Vector.West };
      IDescriptive[] adjacentRooms = new IDescriptive[4];

      for (int i = 0; i < directions.Length; i++)
      {
        Vector adjacentLocation = PlayerEntity.Location.Add(directions[i]);
        bool isAdjacentLocationValid = adjacentLocation.CheckIsValid(Matrix.GetLength(0));
        adjacentRooms[i] = isAdjacentLocationValid
          ? Matrix[adjacentLocation.X, adjacentLocation.Y]
          : new RoomEmpty();
      }

      bool isAdjacentRoomT = Array.Exists(adjacentRooms, room => room is T);
      return isAdjacentRoomT;
    }

    public bool CheckAdjacentRoomsForEntityT<T>(Vector location)
    {
      Vector[] directions = { Vector.North, Vector.East, Vector.South, Vector.West };
      IDescriptive[] adjacentRooms = new IDescriptive[4];

      for (int i = 0; i < directions.Length; i++)
      {
        Vector adjacentLocation = PlayerEntity.Location.Add(directions[i]);
        foreach (IMoveableEntity monster in MoveableEntities)
        {
          if (monster is T && monster.Location == adjacentLocation) return true;
        }
      }

      return false;
    }

    public IMoveableEntity? CheckRoomForEntity()
    {
      foreach (IMoveableEntity monster in MoveableEntities)
      {
        if (monster.Location == PlayerEntity.Location)
          return monster;
      }
      return null;
    }
  }

  // ###############################################################################################
  // INTERFACES
  public interface IDescriptive
  {
    //properties
    public string Description { get; }
    public ConsoleColor Color { get; }
  }

  public interface IMoveableEntity
  {
    // properties
    public Vector Location { get; }

    // methods
    public IMoveableEntity Move(Vector direction);
  }

  public interface IHazard : IDescriptive
  {
    // properties
    public string DescriptionNearby { get; }
  }

  public interface IMonster : IMoveableEntity, IHazard
  {
    // methods
    public void CollideWithPlayerEffect();
  }

  // ###############################################################################################
  // CLASSES
  public static class GameUI
  {
    // methods
    public static void IntroduceGame()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("");
      Console.WriteLine("THE FOUNTAIN OF OBJECTS GAME");
      DrawBorder();
      Console.WriteLine(@"
Welcome, hero. You have entered a cavern filled with maze-like rooms.
You must find the fountain of objects, activate, and return to the entrance safely to win.
Good luck...
");
      SetGameColor();
    }

    public static GameMapSize PromptPlayerChooseGameSize(Prompt prompt)
    {
      SetGameColor();
      prompt.PrintOptionsFull();

      SetGameColor(GameColorStatus.Prompt);
      string option = prompt.PromptPlayer();
      SetGameColor();

      GameMapSize selectedMapSize = option switch
      {
        "1" => GameMapSize.Small,
        "2" => GameMapSize.Medium,
        "3" => GameMapSize.Large,
      };

      return selectedMapSize;
    }

    public static void DescribePlayerCoordinate(Vector coordinate)
    {
      SetGameColor(GameColorStatus.Descriptive);
      Console.WriteLine($"You are in the room at (Row={coordinate.X} Column={coordinate.Y}).");
      SetGameColor();
    }

    public static void SetGameColor(GameColorStatus status = GameColorStatus.Default)
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

    public static void DescribeRoom(IDescriptive room)
    {
      Console.ForegroundColor = room.Color;
      if (room is RoomFountain && ((RoomFountain)room).IsEnabled)
        Console.WriteLine(((RoomFountain)room).DescriptionEnabled);
      else
        Console.WriteLine(room.Description);
      SetGameColor();
    }

    public static void DescribeNearbyHazard(IHazard nearbyHazard)
    {
      Console.WriteLine();
      Console.ForegroundColor = nearbyHazard.Color;
      Console.WriteLine(nearbyHazard.DescriptionNearby);
      SetGameColor();
    }

    public static void DescribeWin()
    {
      SetGameColor(GameColorStatus.Light);
      Console.WriteLine(@"
You activated the Fountain of Objects and escaped with your life!
You win!");
      Console.ReadLine();
    }

    public static void DescribeLoss()
    {
      SetGameColor(GameColorStatus.Death);
      Console.WriteLine("You lose.");
      Console.ReadLine();
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

    public static void DescribeAttemptMove(bool isAttemptingExit, bool isAttemptingOutOfBounds, Vector direction)
    {
      SetGameColor(GameColorStatus.Descriptive);

      string directionWord = "next";
      // TODO Ask green why this doesn't work. 'a constant value is expected'.
      // string directionWord = direction switch
      // {
      //     Vector.North => "north",
      //     Vector.East => "east",
      //     Vector.South => "south",
      //     Vector.West => "west",
      //     _ => "unknown",
      // };

      if (isAttemptingExit)
        Console.WriteLine("You can't leave! You haven't activated the Fountain of Objects yet!");
      else if (isAttemptingOutOfBounds)
        Console.WriteLine("You feel a wall in the way. You can't go in that direction.");
      else
        Console.WriteLine("You walk into the " + directionWord + " room.");

      Console.WriteLine();
      SetGameColor();
    }

    // TODO decide if i keep this or not
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
      Console.WriteLine("========================================================================");
    }
  }


  public class Game
  {
    // properties
    public GameStatus Status { get; set; } = GameStatus.Active;

    // methods
    public void Run()
    {

      Prompt promptForGameSize = new Prompt("gameSize");
      Prompt promptForCommand = new Prompt();
      GameUI.IntroduceGame();

      GameMapSize mapSize = GameUI.PromptPlayerChooseGameSize(promptForGameSize);
      Map map = new Map(mapSize);

      while (Status == GameStatus.Active)
      {
        // TODO Refactor fountain/location logic into their own methods
        Vector playerLocation = map.PlayerEntity.Location;

        GameUI.DrawBorder();
        GameUI.DescribePlayerCoordinate(playerLocation);
        GameUI.DescribeRoom(map.Matrix[playerLocation.X, playerLocation.Y]);

        bool isNearPit = map.CheckAdjacentRoomsForRoomT<RoomPit>(playerLocation);
        if (isNearPit) GameUI.DescribeNearbyHazard(new RoomPit());
        bool isNearMaelstrom = map.CheckAdjacentRoomsForEntityT<MonsterMaelstrom>(playerLocation);
        if (isNearMaelstrom) GameUI.DescribeNearbyHazard(new MonsterMaelstrom(new Vector()));

        // TODO Check if this works and do CollideWithPlayerEffect
        IMonster? monster = (IMonster)map.CheckRoomForEntity();
        monster?.CollideWithPlayerEffect();

        string input = promptForCommand.PromptPlayer();
        Vector? direction = null;
        bool isFountainEnabled = map.CheckIsFountainEnabled();

        switch (input)
        {
          //case Command.Quit:
          case "quit":
            Status = GameStatus.Inactive;
            break;
          case "help":
            promptForCommand.PrintOptionsRibbon();
            break;
          case "go north":
            direction = Vector.North;
            break;
          case "go east":
            direction = Vector.East;
            break;
          case "go south":
            direction = Vector.South;
            break;
          case "go west":
            direction = Vector.West;
            break;
          case "enable fountain":
            bool isAtFountain = map.AttemptEnableFountain();
            GameUI.DescribeEnableFountain(!isAtFountain, !isFountainEnabled);
            isFountainEnabled = map.CheckIsFountainEnabled();
            break;
        }

        if (direction != null)
        {
          bool isMoveValid = map.MovePlayer(direction);
          bool isAttemptingOutOfBounds = playerLocation == new Vector(0, 0) && direction == Vector.South;
          GameUI.DescribeAttemptMove(isAttemptingOutOfBounds, !isMoveValid, direction);

          playerLocation = map.PlayerEntity.Location;
          IDescriptive currentRoom = map.Matrix[playerLocation.X, playerLocation.Y];
          bool isInPit = currentRoom is RoomPit;
          bool hasWon = isFountainEnabled && playerLocation == new Vector(0, 0);

          if (isInPit)
            Status = GameStatus.Lost;
          else if (hasWon)
            Status = GameStatus.Won;

          switch (Status)
          {
            case GameStatus.Lost:
              GameUI.DescribeRoom(currentRoom);
              GameUI.DescribeLoss();
              Status = GameStatus.Inactive;
              break;
            case GameStatus.Won:
              GameUI.DescribeRoom(currentRoom);
              GameUI.DescribeWin();
              Status = GameStatus.Inactive;
              break;
          }
        }
      }
    }
  }

  public class Prompt
  {
    // properties
    string Title { get; init; }
    string DescriptionPrompt { get; init; }
    string DescriptionInvalidInput { get; init; } = "That's not an option.";
    PromptOption[] Options { get; init; }

    // constructors
    public Prompt()
    {
      Title = "Commands";
      DescriptionPrompt = "What do you want to do?";
      Options = new PromptOption[]
      {
            new PromptOption(Command.Quit, "Quit the game"),
            new PromptOption(Command.Help, "See all command options"),
            new PromptOption(Command.GoNorth, "Go up one room"),
            new PromptOption(Command.GoEast, "Go right one room"),
            new PromptOption(Command.GoSouth, "Go down one room"),
            new PromptOption(Command.GoWest, "Go left one room"),
            new PromptOption(Command.EnableFountain, "Turn on the fountain (only works if it's in the room)"),
      };
    }

    // TODO Make this less jank
    // void Prompt(string "gameSize")
    public Prompt(string promptType)
    {

      Title = "Game Size Options";
      DescriptionPrompt = "What size map do you want to play in?";
      Options = new PromptOption[]
      {
            new PromptOption("1", "Small (4x4)"),
            new PromptOption("2", "Medium (6x6)"),
            new PromptOption("3", "Large (8x8)"),
      };
    }

    public Prompt(string title, string descriptionPrompt, PromptOption[] options, string descriptionInvalidInput = "That's not an option.")
    {
      Title = title;
      DescriptionPrompt = descriptionPrompt;
      DescriptionInvalidInput = descriptionInvalidInput;
      Options = options;
    }

    // methods
    public string PromptPlayer()
    {
      string input = null;
      bool isInputValid = false;

      while (!isInputValid)
      {
        GameUI.SetGameColor(GameColorStatus.Prompt);
        Console.WriteLine();
        Console.Write(DescriptionPrompt + " ");

        GameUI.SetGameColor(GameColorStatus.PlayerInput);
        input = Console.ReadLine();
        GameUI.SetGameColor();

        isInputValid = Array.Exists(Options, option => option.Input == input);
        if (!isInputValid) Console.WriteLine(DescriptionInvalidInput);
      }

      return input;
    }

    public void PrintOptionsFull()
    {
      Console.WriteLine();
      Console.WriteLine(Title);

      foreach (PromptOption option in Options)
        Console.WriteLine("    " + option.Input + " - " + option.Description);
      Console.WriteLine();
    }

    public void PrintOptionsRibbon()
    {
      Console.WriteLine();
      Console.WriteLine(Title);

      for (int i = 0; i < Options.Length; i++)
      {
        Console.Write(Options[i].Input);
        if (i != Options.Length - 1) Console.Write(" | ");
      }
      Console.WriteLine();
    }
  }



  public static void TheFountainOfObjects()
  {
    WriteTitle("The Fountain of Objects");

    new Game().Run();
  }






  // *************************************************************************************************

  ///<summary>
  /// LEVEL 31: The Fountain of Objects 
  /// Boss Battle (Expansion) 2/7: Small, Medium, or Large 
  /// The larger the Cavern of Objects is, the more difficult the game becomes. The basic game only requires a small 4x4 world, but we will add a medium 6x6 world and a larger 8x8 world to complete this challenge.
  /// 
  /// **Objectives:** 
  /// [x] Before the game begins, ask the player whether they want to play a small, medium, or large game. Create a 4x4 world if they choose a small world, a 6x6 world if they choose a medium world, and an 8x8 world if they choose a large world.
  /// [x] Pick an appropriate location for both the Fountain Room and the Entrance room.
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
  /// [x] Add a pit room to your 4x4 cavern in a location of your choice, except the fountain and entrance rooms.
  /// [x] Players can sense the draft pushing out of pits in adjacent rooms (all eight directions): "You feel a draft. There is a pit in a nearby  room."
  /// [x] If a player ends their turn in a room with a pit, they lose the game.
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
  /// [X] Add a maelstrom to the small 4x4 game in a location of your choice.
  /// [X] The player can sense maelstroms by hearing them in adjacent rooms. ("You hear the growling and groaning of a maelstrom nearby.")
  /// [] If a player enters a room with a maelstrom, the player moves one space north and two spaces east, while the maelstrom moves one space south and two spaces west.
  /// [] When the player is moved like this, tell them so. If this would move the player or maelstrom beyond the map's edge, ensure they stay on the map.
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
  /// [x] The placement of amaroks is at your discretion. Pick a room to place an amarok aside from the entrance or fountain room in the small 4x4   world.
  /// [x] When a player is in one of the eight spaces adjacent to an amarok, a message should be displayed when sensing surrounding that indicate  that the player can smell the amarok nearby. 
  /// For example, "You can smell the rotten stench of an amarok in a nearby room."
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
  /// [x] When the player types the command `help`, display all available commands and a short description of what each does. The complete list of   commands will depend on what challenges you complete.
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

    Random random = new Random();
    
    // randon positive int value
    Console.WriteLine(random.Next());
    Console.WriteLine(random.Next());
    Console.WriteLine(random.Next());

    // random positive int value capped at arg ceiling non-inclusive
    Console.WriteLine(random.Next(10));
    Console.WriteLine($"Rolling a six-sided die: {random.Next(6) + 1}");

    // including floor and ceiling
    Console.WriteLine(random.Next(1, 7));

    // random floating-point value between 0 to 0.99999...
    Console.WriteLine(random.NextDouble());

    // random float between 0 to 10
    Console.WriteLine(random.NextDouble() * 10);

    // random float between -10 to +10
    Console.WriteLine(random.NextDouble() * 20 - 10);

    Random seededRandom = new Random(0459);
    Console.WriteLine(seededRandom.Next());
    Console.WriteLine(seededRandom.Next());
    Console.WriteLine(seededRandom.Next());
    Random seededRandom2 = new Random(0459);
    Console.WriteLine(seededRandom2.Next());
    Console.WriteLine(seededRandom2.Next());
    Console.WriteLine(seededRandom2.Next());
    
    Console.ReadLine();
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

// LOZ copy
// Land, water, pit, cliff
// temp: normal, hot, cold
// 