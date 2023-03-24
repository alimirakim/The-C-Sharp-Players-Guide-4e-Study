
public enum Direction { North, East, South, West }

public enum GameMapSize { None, Small, Medium, Large }

public enum GameColorStatus { Default, Warning, Death, Prompt, PlayerInput, Water, Light, Descriptive }

public enum RoomType { Empty, Entrance, Fountain, Pit, Maelstrom }

public record Vector(int X, int Y);

public record GamePlayer(Vector Coordinate, bool IsAlive);

public record MapItem(
    RoomType Type=RoomType.Empty,
    string Description="The room is empty.", 
    ConsoleColor Color=ConsoleColor.Gray
    );