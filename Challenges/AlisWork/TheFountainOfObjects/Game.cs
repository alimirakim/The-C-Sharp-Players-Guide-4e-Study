
// player
// room
// entrance
// fountain
// commands
// 

public enum GameMapSize { Small, Medium, Large }

public enum Command { Quit, Help, GoNorth, GoEast, GoSouth, GoWest, EnableFountain }


public class Game
{
    // properties
    public bool IsActive { get; set; } = true;

    // methods
    public void Run()
    {
        Prompt promptForGameSize = new Prompt("gameSize");
        Prompt promptForCommand = new Prompt();

        promptForGameSize.PrintOptionsFull();
        GameMapSize mapSize = promptForGameSize.PromptPlayer();

        Map map = new Map(mapSize);

        while (IsActive)
        {
            string input = promptForCommand.PromptPlayer();
            
            switch (input)
            {
                case "quit":
                    IsActive = false;
                    break;
                case "help":
                    promptForCommand.PrintOptionsRibbon();
                    break;
                case "go north":
                    map.MoveItem(Vector.North);
                    break;
                case "go east":
                    map.MoveItem(Vector.East);
                    break;
                case "go south":
                    map.MoveItem(Vector.South);
                    break;
                case "go west":
                    map.MoveItem(Vector.West);
                    break;
            }

        }
    }
}

record Command(string Input, bool IsGameActive, Map GameMap)
{
    public static readonly string Quit = "quit";
    public static readonly string Help = "help";
    public static readonly string GoNorth = "go north";

    public void Run()
    {

    }

}

interface ICommand
{
    public string Input { get; }

    public void Run()
}

record CommandQuit(bool IsGameActive)
{
    public string Input { get; } = "quit";

    public void Run() => IsGameActive = false;
}

record CommandHelp(Prompt GamePrompt)
{
    public string Input { get; } = "help";

    public void Run() => GamePrompt.PrintOptionsRibbon;
}

record CommandGo(string Input, Map GameMap, Vector Direction)
{
    public void Run() => Map.MoveItem(Direction);
}

record CommandEnableFountain(RoomFountain Fountain, Map GameMap)
{
    public string Input = "enable fountain";

    public void Run()
    {
        if (GameMap.GamePlayer)
        Fountain.IsEnabled = true;

    }

    public record PromptOption(string Input, string Description);

public class Prompt
{
    // properties
    string Title { get; init; }
    string DescriptionPrompt { get; init; }
    string DescriptionInvalidInput { get; init; } = "That's not an option.";
    PromptOption[] Options { get; init; }

    // constructorS
    void Prompt()
    {
        Title = "Help";
        DescriptionPrompt = "What do you want to do?";
        Options = new PromptOption[]
        {
            new PromptOption("help", "See all command options"),
            new PromptOption("go north", "Go up one room"),
            new PromptOption("go east", "Go right one room"),
            new PromptOption("go south", "Go down one room"),
            new PromptOption("go west", "Go left one room"),
            new PromptOption("enable fountain", "Turn on the fountain (only works if it's in the room)"),
        };
    }

    void Prompt("gameSize")
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

    void Prompt(string title, string descriptionPrompt, PromptOption[] options, string descriptionInvalidInput="That's not an option.")
    {
        Title = title;
        DescriptionPrompt = descriptionPrompt;
        DescriptionInvalidInput = descriptionInvalidInput;
        Options = options;
    }

    // methods
    public string PromptPlayer()
    {
        string input;
        bool isInputValid = Array.Exists(Options, option => option.Input == input);

        while (!isInputValid)
        {
            Console.WriteLine(DescriptionPrompt);
            option = Console.ReadLine();
        }

        return input;
    }

    public void PrintOptionsFull()
    {
        Console.WriteLine(Title);

        foreach (PromptOption option in Options)
            Console.WriteLine("    " + option.Input + " - " + option.Description);
        Console.WriteLine();
    }

    public void PrintOptionsRibbon()
    {
        Console.WriteLine(Title);

        for (int i = 0; i < Options.Length; i++)
        {
            Console.Write(Options[i].Input)
            if (i != Options.Length - 1) Console.Write(" | ");
        }
    }
}

record Vector(int X=0, int Y=0)
{
    public static readonly Vector Origin = new Vector(0, 0);
    public static readonly Vector North = new Vector(1, 0);
    public static readonly Vector East = new Vector(0, 1);
    public static readonly Vector South = new Vector(-1, 0);
    public static readonly Vector West = new Vector(0, -1);

    public Vector Add(Vector vector) => this with { X=this.X + vector.X, Y=this.Y + vector.Y };

    public bool CheckIsValid(int mapSize) => !(X < 0 || Y < 0 || X >= mapSize || Y >= mapSize);
}

interface IMoveableEntity 
{
    // properties
    Vector Location { get; }

    // methods
    IMoveableEntity Move(Vector direction);
}

record Player(Vector Location, bool IsAlive=true) : IMoveableEntity
{
    public IMoveableEntity Move(Vector direction) => this with
    {
        Location = this.Location.Add(direction);
    }
}

record Map()
{
    // properties
    IRoom[,] Matrix { get; }
    IMoveableEntity PlayerEntity { get; } = new Player(new Vector());
    IMoveableEntity[] MoveableEntities { get; }

    // constructor
    void Map(GameMapSize size)
    {
        IRoom _ = new RoomEmpty();
        IRoom E = new RoomEntrance();
        IRoom F = new RoomFountain();
        IRoom P = new RoomPit();

        switch (size)
        {
            case GameMapSize.Large:
                Matrix = new IRoom[,]
                {
                    { _, _, _, _, _, _, _, _ },
                    { F, _, _, _, _, _, _, _ },
                    { _, _, _, _, _, _, _, _ },
                    { P, _, _, _, _, _, _, _ },
                    { _, _, _, _, _, _, _, _ },
                    { _, _, _, _, _, _, _, _ },
                    { _, P, _, _, _, _, _, _ },
                    { E, _, _, _, _, _, _, _ },
                };

                MoveableEntities = new IMoveableEntity[]
                {
                    new MonsterMaelstrom(new Vector(2,0)),
                    new MonsterAmarok(new Vector(0,2)),
                };
                break;
            
            case GameMapSize.Medium:
                Matrix = new IRoom[,]
            {
                { _, _, _, _, _, _ },
                { _, _, _, _, _, _ },
                { _, _, _, _, _, _ },
                { _, _, F, _, _, _ },
                { _, P, _, _, _, _ },
                { E, _, _, _, _, _ },
            };

                MoveableEntities = new IMoveableEntity[]
                {
                    new MonsterMaelstrom(new Vector(2,0)),
                    new MonsterAmarok(new Vector(0,2)),
                };
                break;

            case GameMapSize.Small:
                Matrix = new IRoom[,]
            {
                { _, _, _, _ },
                { _, _, _, _ },
                { _, F, _, _ },
                { E, P, _, _ },
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
    public bool MoveItem(IMoveableEntity item, Vector direction)
    {
        for (int i = 0; i < MoveableEntities.Length; i++)
        {
            if (item != MoveableEntities[i])
                continue;

            IMoveableEntity updatedItem = item.Move(direction);
            bool isMoveValid = updatedItem.Location.CheckIsValid(Matrix.GetLength(0))
            
            if (isMoveValid)
                MoveableEntities[i] = updatedItem;
            
            return isMoveValid;
        }
        return false;
    }

    public bool MoveItem(Vector direction)
    {
        return MoveItem(PlayerEntity, direction);
    }
}

interface IRoom 
{
    //properties
    string Description { get; }
    ConsoleColor Color { get; }
}

record RoomEntrance() : IRoom
{
    public string Description => "You see light coming from the cavern entrance.";
    public ConsoleColor Color => ConsoleColor.Yellow;
}

record RoomEmpty() : IRoom
{
    public string Description => "The room is empty. ";
    public ConsoleColor Color => ConsoleColor.DarkGray;
}

record RoomPit() : IRoom
{
    public string Description => "It was a trap! You fell into a pit and died.";
    public ConsoleColor Color => ConsoleColor.Red;
}

record RoomFountain(bool IsEnabled=false) : IRoom
{
    public string Description => "You hear water dripping in this room. The Fountain of Objects is here!";
    public ConsoleColor Color => ConsoleColor.Cyan;
    string DescriptionEnabled => "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
}

interface IMonster : IMoveableEntity
{
    // properties
    string DescriptionNearby { get; }
    string DescriptionEncounter { get; }

    // methods
    void CollideWithPlayerEffect();
}

record MonsterMaelstrom(Vector Location) : IMonster
{
    string DescriptionNearby { get; } = "You hear the growling and groaning of a maelstrom nearby.";
    string DescriptionEncounter { get; } = "You encounter a maelstrom in the room! It blows you away!";

    public void CollideWithPlayerEffect()
    {
        throw new NotImplementedException();
    }

    public IMoveableEntity Move(Vector direction) => this with
    {
        Location = this.Location.Add(direction);
    }
}

record MonsterAmarok(Vector Location) : IMonster
{
    string DescriptionNearby { get; } = "You can smell the rotten stench of an amarok in a nearby room.";
    string DescriptionEncounter { get; } = "You encounter an amarok! It chases you down and kills you."

    public void CollideWithPlayerEffect()
    {
        throw new NotImplementedException();
    }

    public IMoveableEntity Move(Vector direction) => this with
    {
        Location = this.Location.Add(direction);
    }
}


