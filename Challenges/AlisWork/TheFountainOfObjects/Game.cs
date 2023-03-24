
// player
// room
// entrance
// fountain
// commands
// 

public class Game
{
    // properties
    public bool IsActive { get; set; } = true;

    // methods
    public void Run()
    {
        Prompt promptForGameSize = new Prompt (
            "Game Size Options"
            "What size game do you want? ",
            "That's not an option. ",
            new PromptOption[]
            {
                new PromptOption("1", "Small (4x4)"),
                new PromptOption("2", "Medium"),
                new PromptOption("3", "Large"),
            };
            );
        
        Prompt promptForCommand = new Prompt(
            "Help",
            "What do you want to do? ",
            "Nope ",
            new PromptOption[];
            {
                new PromptOption("help", "help"),
                new PromptOption("go north", "go north"),
                new PromptOption("go east", "go east"),
                new PromptOption("go south", "go south"),
                new PromptOption("go west", "go west"),
                new PromptOption("enable fountain", "enable fountain"),
            };
            );

        promptForGameSize.PrintOptionsFull();
        string sizeOption = promptForGameSize.PromptPlayer();

        // TODO Use sizeOption to create map of correct size
        // TODO Populate map with entities based on size
        Map map = new Map(new IRoom[4,4], new IMoveableEntity[]);

        while (IsActive)
        {
            string input = promptForCommand.PromptPlayer();

        }
    }


}

public record PromptOption(string Input, string Description);

public class Prompt
{
    // properties
    string Title { get; }
    string DescriptionPrompt { get; }
    string DescriptionInvalidInput { get; }
    PromptOption[] Options { get; }

    // constructor
    void Prompt(string title, string descriptionPrompt, string descriptionInvalidInput, PromptOption[] options)
    {
        Title = title;
        DescriptionPrompt = descriptionPrompt;
        DescriptionInvalidInput = descriptionInvalidInput;
        Options = options;
    }

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

    public string GetValidInput
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

record Map(IRoom [,] Matrix, IMoveableEntity[] MoveableEntities)
{
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
}

interface IRoom 
    {
        //properties
        string Description { get; }
        ConsoleColor Color { get; }
    }

record RoomEntrance() : IRoom
{
    public string Description => "Entrance...";
    public ConsoleColor Color => ConsoleColor.Yellow;
}

record RoomEmpty() : IRoom
{
    public string Description => "Empty...";
    public ConsoleColor Color => ConsoleColor.DarkGray;
}

record RoomPit() : IRoom
{
    public string Description => "Pit...";
    public ConsoleColor Color => ConsoleColor.Red;
}

record RoomFountain(bool IsEnabled=false) : IRoom
{
    public string Description => "Fountain...";
    public ConsoleColor Color => ConsoleColor.Cyan;
    string DescriptionEnabled => "Enabled fountain!~!!!";
}

interface IMonster : IMoveableEntity
    {
    // properties
    string DescriptionNearby { get; }

    // methods
    void CollideWithPlayerEffect();
    }

record MonsterMaelstrom(Vector Location) : IMonster
{
    string DescriptionNearby { get; } = "Maelstrom is near...";

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
    string DescriptionNearby { get; } = "Amarok is near...";

    public void CollideWithPlayerEffect()
    {
        throw new NotImplementedException();
    }

    public IMoveableEntity Move(Vector direction) => this with
    {
        Location = this.Location.Add(direction);
    }
}

record Command();

record GameState();