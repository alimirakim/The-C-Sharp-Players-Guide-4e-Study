

//    // ENUMS
//    public enum Direction { North, East, South, West }
//    
//    public enum GameMapSize { None, Small, Medium, Large }
//    
//    public enum GameColorStatus { Default, Warning, Death, Prompt, PlayerInput, Water, Light, Descriptive }
//    
//    public enum RoomType { Empty, Entrance, Fountain, Pit, Maelstrom }
//    
//    // INTERFACES
//    public interface IEntity { }
//
//    public record Entity();
//
//    public interface IDescribable : IEntity
//    {
//        // properties
//        RoomType Type { get; init; }
//        string Description { get; init; }
//        ConsoleColor Color { get; init; }
//    }
//
//    // RECORDS
//    public record Vector(int X, int Y);
//    
//    public record GamePlayer(Vector Coordinate, bool IsAlive) : IEntity;
//    
//    public record Describable(
//        RoomType Type=RoomType.Empty,
//        string Description="The room is empty.", 
//        ConsoleColor Color=ConsoleColor.Gray
//        ) : IDescribable;
//    
//    public record HazardEntity(string WarningDescription) : IDescribable;
//
//    public record FountainEntity(
//        bool IsEnabled=false, 
//        string EnabledDescription="You hear the rushing waters from the Fountain of Objects. It has been reactivated!"
//        ) : IDescribable;
//    
//    public class GameMap
//    {
//        // properties
//        public IEntity[][,] Map { get; init; }
//        public GameMapSize Size { get; init; } = GameMapSize.Small;
//
//        // constructor
//        public GameMap(GameMapSize size)
//        {
//            Size = size;
//            Map = GetPopulatedMap();
//        }
//
//        // methods
//        public IEntity[][,] GetPopulatedMap()
//        {
//            IEntity U = GamePlayer();
//            IEntity E = GetRoomOfType(RoomType.Entrance);
//            IEntity F = GetRoomOfType(RoomType.Fountain);
//            IEntity P = GetRoomOfType(RoomType.Pit);
//            IEntity M = GetRoomOfType(RoomType.Maelstrom);
//
//            switch (Size)
//            {
//                case GameMapSize.Large:
//                    return new IEntity[][8,8] {
//                        { { }, { }, { }, { }, { }, { }, { }, { } },
//                        { { }, { }, { }, { }, { }, { }, { }, { } },
//                        { { }, { }, { }, { }, { }, { }, { }, { } },
//                        { { }, { }, { }, { }, { }, { }, { }, { } },
//                        { { }, { }, { }, { }, { }, { }, { }, { } },
//                        { {M}, { }, { }, { }, { }, { }, { }, { } },
//                        { { }, {F}, { }, { }, { }, { }, { }, { } },
//                        { {U,E}, {P}, { }, { }, { }, { }, { }, { } },
//                    };
//                case GameMapSize.Medium:
//                    return new IEntity[][6,6] {
//                        { { }, { }, { }, { }, { }, { } },
//                        { { }, { }, { }, { }, { }, { } },
//                        { { }, { }, { }, { }, { }, { } },
//                        { {M}, { }, { }, { }, { }, { } },
//                        { { }, {F}, { }, { }, { }, { } },
//                        { {U,E}, {P}, { }, { }, { }, { } },
//                    };
//                default:
//                    return new IEntity[][4,4] {
//                        { { }, { }, { }, { } },
//                        { {M}, { }, { }, { } },
//                        { { }, {F}, { }, { } },
//                        { {U,E}, {P}, { }, { } },
//                    };
//            }
//        }
//
//        // TODO GET RID OF THIS
//        public void EnableFountain()
//        {
//            for (int row = 0; row < Map.GetLength(0); row++)
//            {
//                for (int col = 0; col < Map.GetLength(1); col++)
//                {
//                    if (Map[row,col].Type == RoomType.Fountain)
//                    {
//                        IsFountainEnabled = true;
//                        Map[row,col] = GetRoomOfType(RoomType.Fountain) 
//                            with { Description = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!"};
//                    }
//                }
//            }
//        }
//
//        public IDescribable GetRoomOfType(RoomType type)
//        {
//            switch (type)
//            {
//                case RoomType.Entrance:
//                    return new Describable(
//                        RoomType.Entrance,
//                        "You see light coming from the cavern entrance.",
//                        ConsoleColor.Yellow
//                        );
//                case RoomType.Fountain:
//                    return new Describable(
//                        RoomType.Fountain,
//                        "You hear water dripping in this room. The Fountain of Objects is here!", 
//                        ConsoleColor.Cyan
//                        );
//                case RoomType.Pit:
//                    return new HazardEntity(
//                        RoomType.Pit,
//                        "It was a trap! You fell into a pit and died.",
//                        ConsoleColor.Red,
//                        HazardDescription="yada yada"
//                        );
//                case RoomType.Maelstrom:
//                    return new HazardEntity(
//                        RoomType.Maelstrom,
//                        "You encounter a maelstrom in the room! It blows you away!",
//                        ConsoleColor.Cyan,
//                        HazardDescription="blah blah"
//                        );
//                default:
//                    return new Describable();
//            }
//        }
//
//        public RoomType GetAdjacentRoomType(Vector coordinate, Direction direction)
//        {
//            Vector adjacentCoordinate = AttemptMove(coordinate, direction);
//
//            // prevent logic bug that treats current room as an adjacent room
//            if (coordinate == adjacentCoordinate) 
//                return RoomType.Empty;
//
//            return Map[adjacentCoordinate.X, adjacentCoordinate.Y]?.Type ?? RoomType.Empty;
//        }
//
//        public RoomType[] GetAdjacentRoomTypes(Vector coordinate)
//        {
//            RoomType northRoom = GetAdjacentRoomType(coordinate, Direction.North);
//            RoomType eastRoom = GetAdjacentRoomType(coordinate, Direction.East);
//            RoomType southRoom = GetAdjacentRoomType(coordinate, Direction.South);
//            RoomType westRoom = GetAdjacentRoomType(coordinate, Direction.West);
//            return new RoomType[] { northRoom, eastRoom, southRoom, westRoom };
//        }
//
//        public bool CheckAdjacentRoomsForType(Vector coordinate, RoomType type)
//        {
//            RoomType[] adjacentRoomTypes = GetAdjacentRoomTypes(coordinate);
//            bool isNearRoomType = Array.Exists(adjacentRoomTypes, roomType => roomType == type);
//
//            return isNearRoomType;
//        }
//
//        public void PrintMap()
//        {
//            Console.WriteLine("{ MAP }");
//            for (int row = 0; row < Map.GetLength(0); row++)
//            {
//                for (int col = 0; col < Map.GetLength(1); col++)
//                {
//                    Console.Write(" ");
//                    Console.Write(Map[row,col].Type);
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//
//        // Return new coordinate if move in direction is valid on map.
//        // Else return original coordinate.
//        public Vector AttemptMove(Vector coordinate, Direction direction)
//        {
//            Vector newCoordinate = direction switch
//            {
//                Direction.North => coordinate with { X = coordinate.X + 1 },
//                Direction.East => coordinate with { Y = coordinate.Y + 1 },
//                Direction.South => coordinate with { X = coordinate.X - 1 },
//                Direction.West => coordinate with { Y = coordinate.Y - 1 },
//            };
//
//            if (newCoordinate.X < 0 || newCoordinate.X > Map.GetLength(0) || newCoordinate.Y < 0 || newCoordinate.Y > Map.GetLength(1)) 
//                return coordinate;
//            else 
//                return newCoordinate;
//        }
//
//        public bool CheckIsMovingOutside(Vector coordinate, Direction direction)
//        {
//            if (coordinate.X == 0 && coordinate.Y == 0 && direction == Direction.South) 
//                return true;
//            else
//                return false;
//        }
//    }
//
//public static class GameUI
//    {
//        // methods
//        public static void IntroduceGame()
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("");
//            Console.WriteLine("THE FOUNTAIN OF OBJECTS GAME");
//            DrawBorder();
//            Console.WriteLine(@"
//Welcome, hero. You have entered a cavern filled with maze-like rooms.
//You must find the fountain of objects, activate, and return to the entrance safely to win.
//Good luck...
//");
//            SetGameColor();
//
//            Console.WriteLine("menu:");
//            DescribeMenu();
//        }
//
//        public static GameMapSize PromptPlayerChooseGameSize()
//        {
//            Console.WriteLine(@"1 - Small (4x4)
//2 - Medium (6x6)
//3 - Large (8x8)
//");
//
//            GameMapSize selectedMapSize = default(GameMapSize);
//
//            while (selectedMapSize == GameMapSize.None)
//            {
//                SetGameColor(GameColorStatus.Prompt);
//                Console.Write("What size map do you want to play in? ");
//                SetGameColor(GameColorStatus.PlayerInput);
//                string option = Console.ReadLine();
//                SetGameColor();
//
//                switch (option)
//                {
//                    case "1":
//                        selectedMapSize = GameMapSize.Small;
//                        break;
//                    case "2":
//                        selectedMapSize = GameMapSize.Medium;
//                        break;
//                    case "3":
//                        selectedMapSize = GameMapSize.Large;
//                        break;
//                    default:
//                        Console.WriteLine("That's not an option.");
//                        break;
//                }
//
//                DrawBorder();
//                Console.WriteLine();
//            }
//            return selectedMapSize;
//        }
//
//        public static void DescribePlayerCoordinate(Vector coordinate)
//        {
//            Console.WriteLine($"You are in the room at (Row={coordinate.X} Column={coordinate.Y}).");
//        }
//
//        public static void SetGameColor(GameColorStatus status=GameColorStatus.Default)
//        {
//            Console.ForegroundColor = status switch
//            {
//                GameColorStatus.Warning => ConsoleColor.DarkRed,
//                GameColorStatus.Death => ConsoleColor.Red,
//                GameColorStatus.Prompt => ConsoleColor.DarkMagenta,
//                GameColorStatus.PlayerInput => ConsoleColor.Magenta,
//                GameColorStatus.Water => ConsoleColor.Cyan,
//                GameColorStatus.Light => ConsoleColor.Yellow,
//                GameColorStatus.Descriptive => ConsoleColor.DarkGray,
//                _ => ConsoleColor.White,
//            };
//        }
//
//        public static void DescribeRoom(Describable roomContent)
//        {   
//            if (roomContent == null)
//            {
//                SetGameColor(GameColorStatus.Descriptive);
//                Console.WriteLine("The room is empty.");
//            } else
//            {
//                Console.ForegroundColor = roomContent.Color;
//                Console.WriteLine(roomContent.Description);
//            }
//
//            SetGameColor();
//        }
//
//        public static void DescribeNearbyHazard(RoomType nearbyRoomType)
//        {
//            if (nearbyRoomType == RoomType.Pit)
//            {
//                Console.WriteLine();
//                SetGameColor(GameColorStatus.Warning);
//                Console.WriteLine("You feel a draft. There is a pit in a nearby  room....");
//                SetGameColor();
//                Console.WriteLine();
//            }
//            if (nearbyRoomType == RoomType.Maelstrom)
//            {
//                Console.WriteLine();
//                SetGameColor(GameColorStatus.Warning);
//                Console.WriteLine("You hear the growling and groaning of a maelstrom nearby.");
//                SetGameColor();
//                Console.WriteLine();
//            }
//        }
//
//        public static void DescribeWin()
//        {
//            SetGameColor(GameColorStatus.Light);
//            Console.WriteLine(@"
//You activated the Fountain of Objects and escaped with your life!
//You win!");
//        }
//
//        public static void DescribeLoss()
//        {
//            SetGameColor(GameColorStatus.Death);
//            Console.WriteLine("You lose.");
//
//        }
//
//        public static void DescribeEnableFountain(bool isAbsent, bool isDisabled)
//        {
//            SetGameColor(GameColorStatus.Descriptive);
//            if (isAbsent && isDisabled)
//                Console.WriteLine("The Fountain of Objects isn't here. Keep searching!");
//            else if (isDisabled)
//                Console.WriteLine("You activated the Fountain of Objects! Good job!");
//            else 
//                Console.WriteLine("You already activated the Fountain of Objects. Now find your way out!");
//            SetGameColor();
//            Console.WriteLine();
//        }
//
//        public static void DescribeAttemptMove(bool isAttemptingExit, bool isAttemptingOutOfBounds, Direction direction)
//        {
//            SetGameColor(GameColorStatus.Descriptive);
//
//            if (isAttemptingExit) 
//                Console.WriteLine("You can't leave! You haven't activated the Fountain of Objects yet!");
//            else if (isAttemptingOutOfBounds) 
//                Console.WriteLine("You feel a wall in the way. You can't go in that direction.");
//            else
//                Console.WriteLine("You walk into the " + direction + " room.");
//
//            Console.WriteLine();
//            SetGameColor();
//        }
//
//        public static void DescribeDenyAction()
//        {
//            SetGameColor(GameColorStatus.Descriptive);
//            Console.WriteLine("You can't do that.");
//            Console.WriteLine();
//            SetGameColor();
//        }
//
//        public static void DescribeMenu()
//        {
//            SetGameColor(GameColorStatus.Descriptive);
//            Console.WriteLine("quit | menu | go north | go east | go south | go west | enable fountain");
//            Console.WriteLine();
//            SetGameColor();
//        }
//
//        public static string PromptPlayerAction()
//        {
//            SetGameColor(GameColorStatus.Prompt);
//            Console.Write("What do you want to do? ");
//            
//            SetGameColor(GameColorStatus.PlayerInput);
//            string action = Console.ReadLine().ToLowerInvariant();
//
//            SetGameColor();
//            DrawBorder();
//
//            return action;
//        }
//
//        public static void DrawBorder()
//        {
//            Console.WriteLine("=================================");
//
//        }
//    }
//
//    public class GameFountainOfObjects
//    {
//        // properties
//        public bool IsGameActive { get; set; } = true;
//        public bool IsFountainActive { get; set; } = false;
//        public GamePlayer Player { get; set; } = new GamePlayer(new Vector(0,0), true); 
//        public GameMap Map { get; set; }
//
//        // methods
//        public void RunGame()
//        {
//            GameUI.IntroduceGame();
//            Map = new GameMap(GameUI.PromptPlayerChooseGameSize());
//            Map.PrintMap();
//            
//             while (IsGameActive)
//            {
//                GameUI.DescribePlayerCoordinate(Player.Coordinate);
//                GameUI.DescribeRoom(Map.Map[Player.Coordinate.X, Player.Coordinate.Y]);
//
//                bool isNearbyPit = Map.CheckAdjacentRoomsForType(Player.Coordinate, RoomType.Pit);
//                GameUI.DescribeNearbyHazard(isNearbyPit ? RoomType.Pit : RoomType.Empty);
//                
//                bool isNearbyMaelstrom = Map.CheckAdjacentRoomsForType(Player.Coordinate, RoomType.Maelstrom);
//                GameUI.DescribeNearbyHazard(isNearbyMaelstrom ? RoomType.Maelstrom : RoomType.Empty);
//
//                if (CheckWin()) 
//                {
//                    GameUI.DescribeWin();
//                    IsGameActive = false;
//                    break;
//                }
//                if (CheckLoss())
//                {
//                    GameUI.DescribeLoss();
//                    IsGameActive = false;
//                    break;
//                }
//
//                string action = GameUI.PromptPlayerAction();
//                switch (action)
//                {
//                    case "quit":
//                        IsGameActive = false;
//                        break;
//
//                    case "menu":
//                        GameUI.DescribeMenu();
//                        break;
//
//                    case "enable fountain":
//                        AttemptEnableFountain();
//                        break;
//
//                    case "go north":
//                        AttemptMove(Direction.North);
//                        break;
//                    case "go east":
//                        AttemptMove(Direction.East);
//                        break;
//                    case "go south":
//                        AttemptMove(Direction.South);
//                        break;
//                    case "go west":
//                        AttemptMove(Direction.West);
//                        break;
//
//                    default:
//                        GameUI.DescribeDenyAction();
//                        break;
//                }
//            }
//             Console.ReadLine();
//        }
//
//        public void AttemptEnableFountain()
//        {
//            bool isFountainHere = CheckLocation() == RoomType.Fountain;
//
//            // Must do this before changing IsFountainActive status.
//            GameUI.DescribeEnableFountain(!isFountainHere, !IsFountainActive);
//
//            if (isFountainHere && !IsFountainActive) 
//            {
//                IsFountainActive = true;
//                Map.EnableFountain();
//            }
//            
//        }
//            
//        public void AttemptMove(Direction direction)
//        {
//            Vector originalCoordinate = Player.Coordinate;
//            Player = Player with { Coordinate = Map.AttemptMove(Player.Coordinate, direction) };
//
//            bool isTargetOutside = Map.CheckIsMovingOutside(originalCoordinate, direction);
//            bool isTargetOutOfBounds = originalCoordinate == Player.Coordinate;
//
//            GameUI.DescribeAttemptMove(isTargetOutside, isTargetOutOfBounds, direction);
//        }
//
//        public void BlowMaelstrom()
//        {
//            // Move player one north, two east
//            // Ensure pieces stay within the map
//            Player = Player with { Coordinate = Map.AttemptMove(Player.Coordinate, Direction.North) };
//            Player = Player with { Coordinate = Map.AttemptMove(Player.Coordinate, Direction.East) };
//            Player = Player with { Coordinate = Map.AttemptMove(Player.Coordinate, Direction.East) };
//
//            // Move maelstrom one south, two west
//
//        }
//
//        public RoomType? CheckLocation()
//        {
//            return Map.Map[Player.Coordinate.X, Player.Coordinate.Y]?.Type;
//        }
//
//        public bool CheckLoss()
//        {
//            if (CheckLocation() == RoomType.Pit) return true;
//            else return false;
//        }
//
//        public bool CheckWin()
//        {
//            return IsFountainActive && CheckLocation() == RoomType.Entrance;
//        }
//    }
