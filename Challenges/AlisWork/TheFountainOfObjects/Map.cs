
public class GameMap
    {
        // properties
        public MapItem[,] Map { get; init; }
        public GameMapSize Size { get; init; } = GameMapSize.Small;
        public bool IsFountainEnabled { get; set; } = false;

        // constructor
        public GameMap(GameMapSize size)
        {
            Size = size;
            Map = GetPopulatedMap();
        }

        // methods
        public MapItem[,] GetPopulatedMap()
        {
            MapItem _ = GetRoomOfType(RoomType.Empty);
            MapItem E = GetRoomOfType(RoomType.Entrance);
            MapItem F = GetRoomOfType(RoomType.Fountain);
            MapItem P = GetRoomOfType(RoomType.Pit);
            MapItem M = GetRoomOfType(RoomType.Maelstrom);

            switch (Size)
            {
                case GameMapSize.Large:
                    return new MapItem[8,8] {
                        { M, _, _, _, _, _, _, _ },
                        { _, _, _, _, _, _, _, _ },
                        { _, _, _, M, _, M, _, _ },
                        { _, _, _, _, F, _, _, _ },
                        { _, _, _, _, _, _, _, _ },
                        { _, _, P, _, _, _, P, _ },
                        { _, _, _, _, _, _, _, _ },
                        { _, _, _, _, E, _, _, P },
                    };
                case GameMapSize.Medium:
                    return new MapItem[6,6] {
                        { _, _, _, _, _, _ },
                        { _, M, _, _, _, _ },
                        { _, _, _, F, _, _ },
                        { _, _, _, _, P, _ },
                        { _, _, P, _, _, _ },
                        { _, E, _, _, M, _ },
                    };
                default:
                    return new MapItem[4,4] {
                        { _, _, _, _ },
                        { M, _, _, _ },
                        { _, F, _, _ },
                        { E, P, _, _ },
                    };
            }
        }


        public void EnableFountain()
        {
            for (int row = 0; row < Map.GetLength(0); row++)
            {
                for (int col = 0; col < Map.GetLength(1); col++)
                {
                    if (Map[row,col].Type == RoomType.Fountain)
                    {
                        IsFountainEnabled = true;
                        Map[row,col] = GetRoomOfType(RoomType.Fountain) 
                            with { Description = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!"};
                    }
                }
            }
        }

        public MapItem GetRoomOfType(RoomType type)
        {
            switch (type)
            {
                case RoomType.Entrance:
                    return new MapItem(
                        RoomType.Entrance,
                        "You see light coming from the cavern entrance.",
                        ConsoleColor.Yellow
                        );
                case RoomType.Fountain:
                    return new MapItem(
                        RoomType.Fountain,
                        "You hear water dripping in this room. The Fountain of Objects is here!", 
                        ConsoleColor.Cyan
                        );
                case RoomType.Pit:
                    return new MapItem(
                        RoomType.Pit,
                        "It was a trap! You fell into a pit and died.",
                        ConsoleColor.Red
                        );
                case RoomType.Maelstrom:
                    return new MapItem(
                        RoomType.Maelstrom,
                        "You encounter a maelstrom in the room! It blows you away!",
                        ConsoleColor.Cyan
                        );
                default:
                    return new MapItem();
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

        public RoomType[] GetAdjacentRoomTypes(Vector coordinate)
        {
            RoomType northRoom = GetAdjacentRoomType(coordinate, Direction.North);
            RoomType eastRoom = GetAdjacentRoomType(coordinate, Direction.East);
            RoomType southRoom = GetAdjacentRoomType(coordinate, Direction.South);
            RoomType westRoom = GetAdjacentRoomType(coordinate, Direction.West);
            return new RoomType[] { northRoom, eastRoom, southRoom, westRoom };
        }

        public bool CheckAdjacentRoomsForType(Vector coordinate, RoomType type)
        {
            RoomType[] adjacentRoomTypes = GetAdjacentRoomTypes(coordinate);
            bool isNearRoomType = Array.Exists(adjacentRoomTypes, roomType => roomType == type);

            return isNearRoomType;
        }

        public void PrintMap()
        {
            Console.WriteLine("{ MAP }");
            for (int row = 0; row < Map.GetLength(0); row++)
            {
                for (int col = 0; col < Map.GetLength(1); col++)
                {
                    Console.Write(" ");
                    Console.Write(Map[row,col].Type);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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
