

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
            if (nearbyRoomType == RoomType.Maelstrom)
            {
                Console.WriteLine();
                SetGameColor(GameColorStatus.Warning);
                Console.WriteLine("You hear the growling and groaning of a maelstrom nearby.");
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
