using System;

namespace Complete;

public static class PartTwoA
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
    // TOC
    // KnowledgeCheckObjects();
    // SimulasTest();
    // SimulasSoups();
    // VinFletchersArrows();
    // VinsTrouble();
    // ThePropertiesOfArrows();
    // ArrowFactories();
    // ThePoint();
    // TheColor();
    // TheCard();
    TheLockedDoor();
    ThePasswordValidator();
    RockPaperScissors();
    FifteenPuzzle();
    Hangman();
    TicTacToe();
  }

  // *************************************************************************************************

  ///<summary>
  ///<br/> LEVEL 15: Object-Oriented Concepts 
  ///<br/> Knowledge Check: Objects 
  ///<br/> </summary>
  public static void KnowledgeCheckObjects()
  {
    WriteTitle("Knowledge Check - Objects");
    // Console.WriteLine("Check your knowledge with the following questions: ");

    // Console.WriteLine("1. What two things does an object bundle together?");
    // string reply1 = Console.ReadLine();

    // Console.WriteLine("2. True/False. C# lets you define new types of objects.");
    // string reply2 = Console.ReadLine();

    // string answer1 = "";
    // string answer2 = "";

    // TODO Test reply vs answer
  }


  // *************************************************************************************************

  enum LockState { Open, Closed, Locked }
  /// <summary>
  ///<br/> LEVEL 16: Enumerations 
  ///<br/> Challenge 1/1: Simula's Test 
  ///<br/> As you move through the village of Enumerant, you notice a short, cloaked figure following you. Not being one to enjoy a mysterious figure tailing you, you seize a moment to confront the figure "Don't be alarmed," she says, "I am Simula. They are saying you're a Programmer. Is this true?" You answer in the affirmative, and Simula's eyes widen. "If you are truly a programmer, you will be able to help me. Follow me." She leads you back to a street and into a dimly lit hovel. She hands you a small locked chest "We haven't seen any programmers in these lands in a long time and especially not ones that can craft types. If you were a true programmer, you will want what is in that chest. And if you are a true programmer, I'll gladly give it to you to aid you in your quest."
  ///<br/> 
  ///<br/> The chest is a small box you can hold in your hand. The lid can be open, closed but unlocked, or locked. Normally you'd be able to go between these states, opening, closing, locking, and unlocking the box, but the box is broken. You need to create a program with an enumeration to recreate this locking mechanism. The image below shows how you can move between three states:
  ///<br/> 
  ///<br/> **Image:**
  ///<br/>   --------------------------------------------------
  ///<br/>   |      | close => |        | lock =>   |         |
  ///<br/>   | OPEN |          | CLOSED |           |  LOCKED |
  ///<br/>   |      | <= open  |        | <= unlock |         |
  ///<br/>   --------------------------------------------------
  ///<br/> 
  ///<br/> If you attempt an impossible action in the current state (like opening a locked box), nothing happens.
  ///<br/> 
  ///<br/> The program below shows what using this might look like:
  ///<br/> 
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   The chest is locked. What do you want to do? unlock 
  ///<br/>   The chest is unlocked. What do you want to do? open
  ///<br/>   The chest is open. What do you want to do? close
  ///<br/>   The chest is unlocked. What do you want to do?
  ///<br/>   
  ///<br/> OBJECTIVES: 
  ///<br/> [x] Define an enumeration for the state of the chest. 
  ///<br/> [x] Make a variable whose type is this new enumeration.
  ///<br/> [x] Write code to allow you to manipulate the chest with the `lock`, `unlock`, `open`, and `close` commands, but ensure that you don't transition between states that don't support it.
  ///<br/> [x] Loop forever, asking for the next command.
  /// </summary>
  public static void SimulasTest()
  {
    WriteTitle("Simula's Test");

    // Note: Enums can't be defined inside a method! Create the enum above the method or at the bottom of the file.
    LockState chestState = LockState.Open;
    string input;
    string chestStateString;

    do
    {
      chestStateString = chestState switch
      {
        LockState.Open => "open",
        LockState.Closed => "unlocked",
        LockState.Locked => "locked",
      };

      Console.Write($"The chest is {chestStateString}. What do you want to do? ");
      input = Console.ReadLine();
      chestState = input switch
      {
        "open" => chestState == LockState.Closed ? LockState.Open : chestState,
        "close" => chestState == LockState.Open ? LockState.Closed : chestState,
        "lock" => chestState == LockState.Closed ? LockState.Locked : chestState,
        "unlock" => chestState == LockState.Locked ? LockState.Closed : chestState,
        _ => chestState
      };
    } while (input != "quit");
  }

  // *************************************************************************************************

  enum FoodType { Unknown, Soup, Stew, Gumbo }
  enum Ingredient { Unknown, Mushrooms, Chicken, Carrots, Potatoes }
  enum Seasoning { Unknown, Spicy, Salty, Sweet }
  ///<summary>
  ///<br/> LEVEL 17: Tuples 
  ///<br/> Challenge 1/1: Simula's Soups 
  ///<br/> Simula is impressed with how you reconstructed the box with an enumeration. When the box opened, you saw that inside was a glowing emerald gem. You don't know what it is, but it seems important. Also in the box with three vials of powder labeled  HOT, SALTY, and  SWEET.
  ///<br/> 
  ///<br/> "Finally! I can make soup again!" Simula says. She casually tosses the small glowing gem to you but is wholly focused on the powders "You stick around and help me make soup, and I'll tell you what that gem of yours does."
  ///<br/> 
  ///<br/> She pulls out three small pots and begins making three different food pots, explaining what she's doing "I can make soup stew and gumbo. I can use mushrooms, chicken, carrots, or potatoes and I can add spicy, salty, or sweet seasoning to each. Why don't you whip up a little program to help us keep track of what we make."
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [x] Define enumerations for the three variations of food type (soup, stew, gumbo) the main ingredient (mushrooms, chicken, carrots, potatoes), and seasoning (spicy, salty, sweet).
  ///<br/> [ ] Make an array of length 3 to store tuples represent the soups, where each tuple is composed of three elements, one of each of the above enumeration types. 
  ///<br/> [ ] Allow the user to enter a type, the main ingredient, and one seasoning from the allowed choices for each of the three pots (repeat it three times, one for each spot in the array).
  ///<br/> [ ] When done, display all three soups in a form such as "Sweet Chicken Gumbo" (if you display in enumeration value, it will display the enumeration member's text representation, so you don't have to convert it to a string yourself).
  ///<br/> </summary>
  public static void SimulasSoups()
  {
    WriteTitle("Simula's Soups");

    (FoodType, Ingredient, Seasoning)[] soups = new (FoodType, Ingredient, Seasoning)[1];

    for (int i = 1; i <= soups.Length; i++)
    {
      FoodType foodType = FoodType.Unknown;
      Ingredient ingredient = Ingredient.Unknown;
      Seasoning seasoning = Seasoning.Unknown;

      Console.WriteLine($"\nFor meal #{Convert.ToString(i)}... ");

      while (foodType == FoodType.Unknown)
      {
        Console.Write("What kind of meal do you want: soup, stew, or gumbo? ");
        foodType = Console.ReadLine() switch
        {
          "soup" => FoodType.Soup,
          "stew" => FoodType.Stew,
          "gumbo" => FoodType.Gumbo,
          _ => FoodType.Unknown
        };
      }

      while (ingredient == Ingredient.Unknown)
      {
        Console.Write("What main ingredient: mushrooms, chicken, carrots, potatoes? ");
        ingredient = Console.ReadLine() switch
        {
          "mushrooms" => Ingredient.Mushrooms,
          "chicken" => Ingredient.Chicken,
          "carrots" => Ingredient.Carrots,
          "potatoes" => Ingredient.Potatoes,
          _ => Ingredient.Unknown
        };
      }

      while (seasoning == Seasoning.Unknown)
      {
        Console.Write("How should we season it: spicy, salty, sweet? ");
        seasoning = Console.ReadLine() switch
        {
          "spicy" => Seasoning.Spicy,
          "salty" => Seasoning.Salty,
          "sweet" => Seasoning.Sweet,
          _ => Seasoning.Unknown
        };
      }

      soups[i - 1] = (foodType, ingredient, seasoning);
    }

    Console.WriteLine("\nEat it while it's hot! ");
    foreach ((FoodType, Ingredient, Seasoning) soup in soups)
    {
      (FoodType foodType, Ingredient ingredient, Seasoning seasoning) = soup;
      Console.WriteLine($"{seasoning} {ingredient} {foodType}");
    }
  }

  // *************************************************************************************************


  public class Arrow
  {
    public enum Arrowhead { Steel, Wood, Obsidian }
    public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

    // static methods
    public static Arrow AskArrow()
    {
      Console.Write("What kind of arrowhead: wood, obsidian, steel? ");
      Arrowhead arrowhead = Console.ReadLine() switch
      {
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian,
        "steel" => Arrowhead.Steel,
      };

      Console.Write("What kind of fletching: goose feathers, turkey feathers, plastic? ");
      Fletching fletching = Console.ReadLine() switch
      {
        "goose" => Fletching.GooseFeathers,
        "turkey" => Fletching.TurkeyFeathers,
        "plastic" => Fletching.Plastic,
      };

      Console.Write("How long should the shaft be (between 60-100 cm)? ");
      int shaftLength = Math.Clamp(Convert.ToInt32(Console.ReadLine()), 60, 100);

      Arrow arrow = new Arrow(arrowhead, fletching, shaftLength);
      return arrow;
    }

    public static float GetCostArrowhead(Arrowhead arrowhead)
    {
      return arrowhead switch
      {
        Arrowhead.Wood => 3,
        Arrowhead.Steel => 10,
        Arrowhead.Obsidian => 5,
      };
    }

    public static float GetCostFletching(Fletching fletching)
    {
      return fletching switch
      {
        Fletching.Plastic => 10,
        Fletching.TurkeyFeathers => 5,
        Fletching.GooseFeathers => 3,
      };
    }

    public static float GetCostShaftLength(int shaftLength) => shaftLength * 0.05f;

    // fields
    public Arrowhead _arrowhead;
    public float _costArrowhead;
    public Fletching _fletching;
    public float _costFletching;
    public int _shaftLength;
    public float _costShaftLength;

    // constructors
    public Arrow(Arrowhead arrowhead, Fletching fletching, int shaftLength)
    {
      _arrowhead = arrowhead;
      _fletching = fletching;
      _shaftLength = shaftLength;
      _costArrowhead = GetCostArrowhead(_arrowhead);
      _costFletching = GetCostFletching(_fletching);
      _costShaftLength = GetCostShaftLength(_shaftLength);
    }

    // methods
    public float GetCost() => _costArrowhead + _costFletching + _costShaftLength;
  }

  ///<summary>
  ///<br/> LEVEL 18: Classes 
  ///<br/> Challenge 1/1: Vin Fletcher's Arrows 
  ///<br/> Vin Fletcher is a skilled arrow maker. He asks for help to build a new class to represent arrows and determine how much he should sell them for. "A tiny fragment of my soul goes into each arrow; I care not for the money; I just need to be able to recoup my costs and get food on the table," he says.
  ///<br/> 
  ///<br/> Each arrow has three parts: the Arrowhead (steel, wood, or obsidian), the shaft (a length between 60 and 100cm long), and the fletching (plastic, turkey feathers, or goose feathers).
  ///<br/> 
  ///<br/> His costs are as follows: for arrowheads, steel costs 10 gold, wood costs three gold, and obsidian costs 5 gold. For fletching, plastic costs 10 gold, turkey feathers cost 5 gold, and goose feathers cost 3 gold. For the shaft, the price depends on the length: 0.05 gold per centimeter.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [x] Define a new `Arrow` class that has instance variables for arrowhead type, fletching type, and length. (Hint: Arrowhead types and fletching types might be good enumerations.)
  ///<br/> [x] Allow a user to pick the arrowhead, fletching type, and length and then create a new `Arrow` instance. 
  ///<br/> [x] Add a `GetCost` method that returns its cost as a `float` based on the numbers above, and use this to display the arrows cost.
  ///<br/> </summary>
  public static void VinFletchersArrows()
  {
    WriteTitle("Vin Fletcher's Arrows");

    Arrow arrow = Arrow.AskArrow();
    float cost = arrow.GetCost();
    Console.WriteLine($"That'll cost {Convert.ToString(cost)} gold to make.");
  }

  // *************************************************************************************************

  public class SecretArrow
  {
    public enum Arrowhead { Steel, Wood, Obsidian }
    public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

    // static methods
    public static SecretArrow AskArrow()
    {
      Console.Write("What kind of arrowhead: wood, obsidian, steel? ");
      Arrowhead arrowhead = Console.ReadLine() switch
      {
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian,
        "steel" => Arrowhead.Steel,
      };

      Console.Write("What kind of fletching: goose feathers, turkey feathers, plastic? ");
      Fletching fletching = Console.ReadLine() switch
      {
        "goose" => Fletching.GooseFeathers,
        "turkey" => Fletching.TurkeyFeathers,
        "plastic" => Fletching.Plastic,
      };

      Console.Write("How long should the shaft be (between 60-100 cm)? ");
      int shaftLength = Math.Clamp(Convert.ToInt32(Console.ReadLine()), 60, 100);

      SecretArrow arrow = new SecretArrow(arrowhead, fletching, shaftLength);
      return arrow;
    }

    public static float FindCostArrowhead(Arrowhead arrowhead)
    {
      return arrowhead switch
      {
        Arrowhead.Wood => 3,
        Arrowhead.Steel => 10,
        Arrowhead.Obsidian => 5,
      };
    }

    public static float FindCostFletching(Fletching fletching)
    {
      return fletching switch
      {
        Fletching.Plastic => 10,
        Fletching.TurkeyFeathers => 5,
        Fletching.GooseFeathers => 3,
      };
    }

    public static float FindCostShaftLength(int shaftLength) => shaftLength * 0.05f;

    // fields
    private Arrowhead _arrowhead;
    private float _costArrowhead;
    private Fletching _fletching;
    private float _costFletching;
    private int _shaftLength;
    private float _costShaftLength;

    // constructors
    public SecretArrow(Arrowhead arrowhead, Fletching fletching, int shaftLength)
    {
      _arrowhead = arrowhead;
      _fletching = fletching;
      _shaftLength = shaftLength;
      _costArrowhead = FindCostArrowhead(_arrowhead);
      _costFletching = FindCostFletching(_fletching);
      _costShaftLength = FindCostShaftLength(_shaftLength);
    }
    public Arrowhead GetArrowhead() => _arrowhead;
    public Fletching GetFletching() => _fletching;
    public int GetShaftLength() => _shaftLength;
    public float GetCostArrowhead => _costArrowhead;
    public float GetCostFletching => _costFletching;
    public float GetCostShaftLength => _costShaftLength;

    // methods
    public float GetCost() => _costArrowhead + _costFletching + _costShaftLength;
  }
  ///<summary> 
  ///<br/> LEVEL 19: Information Hiding 
  ///<br/> Challenge 1/1: Vin's Trouble 
  ///<br/> "Master Programmer!" Vin Fletcher shouts at you as he races to catch up to you. "I have a problem. I created an arrow for a young man who took it and changed its length to be half as long as I had built it to be. It no longer fit in his bow correctly and misfired. It sliced his hand pretty bad. He'll survive, but is there any way we can make sure somebody doesn't change an arrow's length when they walk away from my shop? I don't want to be the cause of such self-inflicted pain." With your knowledge of information hiding, you know you can help.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [x] Modify your `Arrow` class to have `private` instead of `public` instance variables. 
  ///<br/> [x] Add in getter methods for each of the instance variables that you have.
  ///<br/> </summary>
  public static void VinsTrouble()
  {
    WriteTitle("Vin's Trouble");

    SecretArrow myArrow = new SecretArrow(SecretArrow.Arrowhead.Wood, SecretArrow.Fletching.TurkeyFeathers, 100);
    (SecretArrow.Arrowhead, SecretArrow.Fletching, int) myArrowTuple = (myArrow.GetArrowhead(), myArrow.GetFletching(), myArrow.GetShaftLength());

    Console.WriteLine("My secret arrow's secret fields: ");
    Console.WriteLine(myArrowTuple);
  }

  // *************************************************************************************************

  public class BestArrow
  {
    public enum EArrowhead { Steel, Wood, Obsidian }
    public enum EFletching { Plastic, TurkeyFeathers, GooseFeathers }

    // static methods
    public static BestArrow AskArrow()
    {
      Console.Write("What kind of arrowhead: wood, obsidian, steel? ");
      EArrowhead arrowhead = Console.ReadLine() switch
      {
        "wood" => EArrowhead.Wood,
        "obsidian" => EArrowhead.Obsidian,
        "steel" => EArrowhead.Steel,
      };

      Console.Write("What kind of fletching: goose feathers, turkey feathers, plastic? ");
      EFletching fletching = Console.ReadLine() switch
      {
        "goose" => EFletching.GooseFeathers,
        "turkey" => EFletching.TurkeyFeathers,
        "plastic" => EFletching.Plastic,
      };

      Console.Write("How long should the shaft be (between 60-100 cm)? ");
      int shaftLength = Math.Clamp(Convert.ToInt32(Console.ReadLine()), 60, 100);

      BestArrow arrow = new BestArrow(arrowhead, fletching, shaftLength);
      return arrow;
    }

    public static float FindCostArrowhead(EArrowhead arrowhead)
    {
      return arrowhead switch
      {
        EArrowhead.Wood => 3,
        EArrowhead.Steel => 10,
        EArrowhead.Obsidian => 5,
      };
    }

    public static float FindCostShaftLength(int shaftLength) => shaftLength * 0.05f;

    // fields
    private EArrowhead _arrowhead;
    private float _costArrowhead;
    private EFletching _fletching;
    public int ShaftLength { get; set; }

    // constructors
    public BestArrow(EArrowhead arrowhead, EFletching fletching, int shaftLength)
    {
      _arrowhead = arrowhead;
      _costArrowhead = FindCostArrowhead(arrowhead);
      _fletching = fletching;
      ShaftLength = shaftLength;
    }

    public EArrowhead Arrowhead
    {
      get
      {
        return _arrowhead;
      }
      set
      {
        _arrowhead = value;
        _costArrowhead = FindCostArrowhead(value);
      }
    }

    public float CostArrowhead
    {
      get => _costArrowhead;
    }

    public EFletching Fletching
    {
      get => _fletching;
      set => _fletching = value;
    }

    public float CostFletching
    {
      get => _fletching switch
      {
        EFletching.Plastic => 10,
        EFletching.TurkeyFeathers => 5,
        EFletching.GooseFeathers => 3,
      };
    }

    public float CostShaftLength
    {
      get => FindCostShaftLength(ShaftLength);
    }

    // methods
    public float GetCost() => CostArrowhead + CostFletching + CostShaftLength;
  }

  ///<summary>
  ///<br/> LEVEL 20: Properties 
  ///<br/> Challenge 1/1: The Properties of Arrows 
  ///<br/> Vin Fletcher once again has run to catch up to you for help with this arrows. "My apologies, Programmer! This will be the last time I bother you. My cousin, Flynn Vetcher, is the only other arrow maker in the area. He doesn't care for his craft and makes wildly dangerous and overpriced arrows. But people keep buying them because they think my `GetLength()` methods are harder to work with than his public `_length` fields. I don't want to give up the protections we just gave these arrows, but I overheard you say something about properties. Maybe you could use those to make my arrows easier to work with?"
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [ ] Modify your `Arrow` class use properties instead of `GetX` and `SetX` methods. 
  ///<br/> [ ] Ensure the whole program can still run, and then can keep creating arrows with it.
  ///<br/> </summary>
  public static void ThePropertiesOfArrows()
  {
    WriteTitle("The Properties of Arrows");

    BestArrow myArrow = new BestArrow(BestArrow.EArrowhead.Obsidian, BestArrow.EFletching.GooseFeathers, 85);
    var myArrowTuple = (
      Arrowhead: myArrow.Arrowhead,
      ArrowheadCost: myArrow.CostArrowhead,
      Fletching: myArrow.Fletching,
      FletchingCost: myArrow.CostFletching,
      ShaftLength: myArrow.ShaftLength,
      ShaftCost: myArrow.CostShaftLength
    );

    Console.WriteLine("My best arrow's best properties: ");
    Console.WriteLine(myArrowTuple);
  }


  // *************************************************************************************************

  public class FinalArrow
  {
    public enum ArrowheadType { Steel, Wood, Obsidian }
    public enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers }

    // static methods
    public static FinalArrow CreateEliteArrow() => new FinalArrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
    public static FinalArrow CreateBeginnerArrow() => new FinalArrow(ArrowheadType.Wood, FletchingType.GooseFeathers, 75);
    public static FinalArrow CreateMarksmanArrow() => new FinalArrow(ArrowheadType.Steel, FletchingType.GooseFeathers, 65);

    public static FinalArrow AskStandardArrow()
    {
      Console.Write(@"What kind of arrow: 
        1. Elite Arrow
        2. Beginner Arrow
        3. Marksman's Arrow
        4. Custom Arrow
        ");
      string arrowOption = Console.ReadLine();
      return arrowOption switch
      {
        "1" => CreateEliteArrow(),
        "2" => CreateBeginnerArrow(),
        "3" => CreateMarksmanArrow(),
        _ => AskCustomArrow()
      };
    }

    public static FinalArrow AskCustomArrow()
    {
      Console.Write("What kind of arrowhead: wood, obsidian, steel? ");
      ArrowheadType arrowhead = Console.ReadLine() switch
      {
        "wood" => ArrowheadType.Wood,
        "obsidian" => ArrowheadType.Obsidian,
        "steel" => ArrowheadType.Steel,
      };

      Console.Write("What kind of fletching: goose feathers, turkey feathers, plastic? ");
      FletchingType fletching = Console.ReadLine() switch
      {
        "goose" => FletchingType.GooseFeathers,
        "turkey" => FletchingType.TurkeyFeathers,
        "plastic" => FletchingType.Plastic,
      };

      Console.Write("How long should the shaft be (between 60-100 cm)? ");
      int shaftLength = Math.Clamp(Convert.ToInt32(Console.ReadLine()), 60, 100);

      FinalArrow arrow = new FinalArrow(arrowhead, fletching, shaftLength);
      return arrow;
    }

    public static float FindCostArrowhead(ArrowheadType arrowhead)
    {
      return arrowhead switch
      {
        ArrowheadType.Wood => 3,
        ArrowheadType.Steel => 10,
        ArrowheadType.Obsidian => 5,
      };
    }

    public static float FindCostFletching(FletchingType fletching)
    {
      return fletching switch
      {
        FletchingType.Plastic => 10,
        FletchingType.TurkeyFeathers => 5,
        FletchingType.GooseFeathers => 3,
      };
    }

    public static float FindCostShaftLength(int shaftLength) => shaftLength * 0.05f;

    // properties
    public ArrowheadType Arrowhead { get; set; }
    public FletchingType Fletching { get; set; }
    public int ShaftLength { get; set; }

    public float CostArrowhead { get => FindCostArrowhead(Arrowhead); }
    public float CostFletching { get => FindCostFletching(Fletching); }
    public float CostShaftLength { get => FindCostShaftLength(ShaftLength); }

    // constructor
    public FinalArrow(ArrowheadType arrowhead, FletchingType fletching, int shaftLength)
    {
      Arrowhead = arrowhead;
      Fletching = fletching;
      ShaftLength = shaftLength;
    }

    // methods
    public float GetCost() => CostArrowhead + CostFletching + CostShaftLength;
  }

  ///<summary>
  ///<br/> LEVEL 21: Static 
  ///<br/> Challenge 1/1: Arrow Factories 
  ///<br/> Vin Fletcher sometimes makes custom-ordered arrows, but these are rare. Most of the time, he sells one of the following standard arrows: 
  ///<br/> 
  ///<br/> - The Elite Arrow, made from a steel arrowhead, plastic fletching, and a 95 cm shaft.
  ///<br/> - The Beginner Arrow, made from a wood arrowhead, goose feathers, and a 75 cm shaft.
  ///<br/> - The Marksman Arrow, made from a steel arrowhead, goose feathers, and a 65 cm shaft.
  ///<br/> 
  ///<br/> You can make static methods so that making these as specific variations of arrows is easy.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [ ] Modify your `Arrow` class one final time to include static methods of the form `public static Arrow CreateEliteArrow() { ... }` for each of the following three above arrow types.
  ///<br/> [ ] Modify the program to allow a user to choose one of these predefined types for a custom arrow. If they select one of the predefined styles, produce an `Arrow` instance using one of the new static methods. If they choose to make a custom arrow, use the original code to get their custom data about the desired arrow.
  ///<br/> </summary>
  public static void ArrowFactories()
  {
    WriteTitle("Arrow Factories");

    FinalArrow myArrow = FinalArrow.AskStandardArrow();
    var myArrowTuple = (
      Arrowhead: myArrow.Arrowhead,
      ArrowheadCost: myArrow.CostArrowhead,
      Fletching: myArrow.Fletching,
      FletchingCost: myArrow.CostFletching,
      ShaftLength: myArrow.ShaftLength,
      ShaftCost: myArrow.CostShaftLength
    );

    Console.WriteLine("My final arrows' final properties: ");
    Console.WriteLine(myArrowTuple);


  }

  // *************************************************************************************************

  public class Point
  {
    public int X { get; }
    public int Y { get; }

    public Point() { }
    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }
  }
  ///<summary>
  ///<br/> LEVEL 24: The Catacombs of the Class 
  ///<br/> Boss Battle 1/9: The Point 
  ///<br/> The first pedestal asks you to create a `Point` class to store a point into two dimensions. Each point is represented by an x-coordinate (referred to as x), a side-to-side distance from a special central point called the origin, and a y-coordinate (referred to as y), an up-and-down distance away from the origin.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [x] Define a new `Point` class with properties for `X` and `Y`.
  ///<br/> [x] Add a constructor to create a point from a specific x- and y-coordinate.
  ///<br/> [x] Add a parameterless constructor to create a point at the origin (0, 0).
  ///<br/> [x] In your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the console window in the format `(x, y)` to illustrate that the class works.
  ///<br/> [ ] Answer this question: Are your `X` an `Y` properties immutable? Why did you choose what you did?
  ///<br/> </summary>
  public static void ThePoint()
  {
    WriteTitle("The Point");

    Point Origin = new Point();
    Point TwoThree = new Point(2, 3);
    Point FourZero = new Point(-4, 0);

    Point[] points = new[] { Origin, TwoThree, FourZero };

    foreach (Point point in points)
      Console.WriteLine($"({point.X}, {point.Y})");
  }

  // *************************************************************************************************


  public class Color
  {
    public static Color White { get => new Color(255, 255, 255); }
    public static Color Black { get => new Color(0, 0, 0); }
    public static Color Red { get => new Color(255, 0, 0); }
    public static Color Orange { get => new Color(255, 165, 0); }
    public static Color Yellow { get => new Color(255, 255, 0); }
    public static Color Green { get => new Color(0, 128, 0); }
    public static Color Blue { get => new Color(0, 0, 255); }
    public static Color Purple { get => new Color(128, 0, 128); }

    public byte R { get; }
    public byte G { get; }
    public byte B { get; }
    public string RGB { get => $"rgb({Convert.ToString(R)},{Convert.ToString(G)},{Convert.ToString(B)})"; }

    public Color() { }
    public Color(byte redValue, byte greenValue, byte blueValue)
    {
      R = redValue;
      G = greenValue;
      B = blueValue;
    }
  }
  ///<summary>
  ///<br/> LEVEL 24: The Catacombs of the Class 
  ///<br/> Boss Battle 2/9: The Color 
  ///<br/> The second pedestal asks you to create a `Color` class to represent a color. The pedestal includes an etching of this diagram that illustrates its potential usage:
  ///<br/> 
  ///<br/> **Image:**
  ///<br/>   |----|  R - ==========o 255 + 
  ///<br/>   ||||||  G - =======o=== 165 +
  ///<br/>   |----|  B - o==========   0 +
  ///<br/> 
  ///<br/> The color is made up of three parts or channels: red, green, and blue, which indicate how much those channels are lit up. Each channel can be from 0 to 255, with 0 being completely off and 255 completely on. 
  ///<br/> 
  ///<br/> The pedestal also includes some color names, with a set of numbers indicating their specific values for each channel. These are commonly used colors: White (255, 255, 255), Black (0, 0, 0), Red (255, 0, 0), Orange (255, 165, 0), Yellow (255, 255, 0), Green (0, 128 0), Blue (0, 0, 255), Purple (128, 0, 128).
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [x] Define a new `Color` class with properties for its red, green, and blue channels.
  ///<br/> [x] Add appropriate constructors that make sense for creating new `Color` objects.
  ///<br/> [x] Create static properties to define the eight commonly used colors for easy access.
  ///<br/> [x] In your main method, make two `Color`-typed variables. Use a constructor to create a color instance and use a static property for the other. Display each of their red, green, and blue channel values.
  ///<br/> </summary>
  public static void TheColor()
  {
    WriteTitle("The Color");

    Color[] colors = new[] { Color.Red, Color.White, new Color(1, 43, 210) };
    foreach (Color color in colors)
      Console.WriteLine(color.RGB);
  }

  // *************************************************************************************************

  public class Card
  {
    public enum CardColor { Red, Green, Blue, Yellow }
    public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand }

    public static void WriteDeck()
    {
      // TODO Why doesn't CardColor[] or CardRank[] work?
      var colors = Enum.GetValues(typeof(CardColor));
      var ranks = Enum.GetValues(typeof(CardRank));

      foreach (CardColor color in colors)
        foreach (CardRank rank in ranks)
          Console.WriteLine(new Card(color, rank).CardLabel);
    }

    public CardColor Color { get; }
    public CardRank Rank { get; }
    public string CardLabel { get => $"The {Color} {Rank}"; }
    public bool IsRankNumber
    {
      get
      {
        bool isRankNumber;

        switch (Rank)
        {
          case CardRank.Dollar:
          case CardRank.Percent:
          case CardRank.Caret:
          case CardRank.Ampersand:
            isRankNumber = false;
            break;
          default:
            isRankNumber = true;
            break;
        }

        return isRankNumber;
      }
    }

    public Card()
    {
      Color = CardColor.Red;
      Rank = CardRank.One;
    }

    public Card(CardColor color, CardRank rank)
    {
      Color = color;
      Rank = rank;
    }
  }
  ///<summary>
  ///<br/> LEVEL 24: The Catacombs of the Class 
  ///<br/> Boss Battle 3/9: The Card 
  ///<br/> The digital Realms of C# have playing cards like ours but with some differences. Each card has a color (red, green, blue, yellow) and a rank (the numbers 1 through 10, followed by the symbols $, %, ^, and &). The third pedestal requires that you create a class to represent a card of this nature. 
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [x] Define enumerations for card colors and card ranks.
  ///<br/> [x] Define a `Card` class to represent a card with a color and a rank, as described above.
  ///<br/> [x] Add properties or methods that tell you if a card is a number or a symbol card (the equivalent of a face card).
  ///<br/> [x] Create a main method that will create a card instance of every card (every color with every rank) and display it (for example, "The Red Ampersand" and "The Blue Seven", or some other similar scheme).
  ///<br/> [ ] Answer this question: Why do you think we used a color enumeration here, but in the previous challenge, we made a color class?
  ///<br/> </summary>
  public static void TheCard()
  {
    WriteTitle("The Card");
    Card.WriteDeck();
    Card redFive = new Card(Card.CardColor.Red, Card.CardRank.Five);
    Card greenAmpersand = new Card(Card.CardColor.Green, Card.CardRank.Ampersand);
    Console.WriteLine(redFive.IsRankNumber);
    Console.WriteLine(greenAmpersand.IsRankNumber);
  }

  // *************************************************************************************************


  public class Door
  {
    public enum DoorState { Open, Closed, Locked }

    public DoorState State { get; set; } = DoorState.Open;
    public int Passcode { get; private set; }

    public static Door CreateDoor()
    {
      Console.Write("Input a passcode for a new door: ");
      int passcode = Convert.ToInt32(Console.ReadLine());
      return new Door(passcode);
    }

    public void HandleDoor()
    {
      string input;
      do
      {
        Console.Write($"The door is {State}. ");
        input = Console.ReadLine();
        bool isSuccess = input switch
        {
          "open" => OpenDoor(),
          "close" => CloseDoor(),
          "lock" => LockDoor(),
          "unlock" => PromptUnlockDoor(),
          "change passcode" => PromptChangePasscode(),
          _ => false,
        };

      } while (input != "quit");
    }

    public bool CloseDoor()
    {
      if (State == DoorState.Open)
      {
        State = DoorState.Closed;
        return true;
      }
      else return false;
    }

    public bool OpenDoor()
    {
      if (State == DoorState.Closed)
      {
        State = DoorState.Open;
        return true;
      }
      else if (State == DoorState.Locked) return PromptUnlockDoor();
      else return false;
    }
    public bool LockDoor()
    {
      if (State == DoorState.Closed)
      {
        State = DoorState.Locked;
        return true;
      }
      else return false;
    }
    public bool UnlockDoor(int inputPasscode)
    {
      if (inputPasscode == Passcode)
      {
        State = DoorState.Closed;
        return true;
      }
      else return false;
    }
    public bool PromptUnlockDoor()
    {
      if (State == DoorState.Locked)
      {
        Console.Write("What is the passcode? ");
        int inputPasscode = Convert.ToInt32(Console.ReadLine());
        return UnlockDoor(inputPasscode);
      }
      else return false;
    }
    public bool PromptChangePasscode()
    {
      Console.Write("Input the current passcode: ");
      int currentPasscode = Convert.ToInt32(Console.ReadLine());
      Console.Write("Input the new passcode: ");
      int newPasscode = Convert.ToInt32(Console.ReadLine());

      bool isSuccessful = ChangePasscode(currentPasscode, newPasscode);
      if (isSuccessful) Console.WriteLine("Changed passcode successfully. ");
      else Console.WriteLine("Wrong passcode. Passcode was not changed. ");
      return isSuccessful;
    }

    public bool ChangePasscode(int oldPasscode, int newPasscode)
    {
      if (oldPasscode == Passcode)
      {
        Passcode = newPasscode;
        return true;
      }
      else return false;
    }

    public Door(int passcode)
    {
      Passcode = passcode;
    }
  }
  ///<summary>
  ///<br/> LEVEL 24: The Catacombs of the Class 
  ///<br/> Boss Battle 4/9: The Locked Door 
  ///<br/> The fourth pedestal demands constructing a door class with a locking mechanism that requires a unique numeric code to unlock. You have done something similar before (without using a class), but the locking mechanism is new. The door should only unlock if the passcode is the right one. The following statements describe how the door works.
  ///<br/> 
  ///<br/> - An open door can always be closed.
  ///<br/> - A closed (but not locked) door can always be opened.
  ///<br/> - A closed door can always be locked.
  ///<br/> - A locked door can be unlocked, but a numeric passcode is needed, and the door will only unlock if the code supplied matches the door's current passcode.
  ///<br/> - When a door is created, is must be given an initial passcode.
  ///<br/> - Additionally, you should be able to change the passcode by supplying the current code and a new one.The passcode should only change if the correct, current code is given.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [x] Define a `Door` class that can keep track of whether it's locked, open, or closed.
  ///<br/> [ ] Make it so you can perform the four transitions defined above with methods.
  ///<br/> [x] Build a constructor that requires the starting numeric passcode.
  ///<br/> [ ] Build a method that will allow you to change the passcode for an existing door by supplying the current passcode and a new passcode. Only change the passcode if the current passcode is correct.
  ///<br/> [ ] Make your main method ask the user for a starting passcode, then create a new `Door` instance. Allow the user to attempt the four various transitions described above (open, close, lock, unlock) and change the code by typing in text commands.
  ///<br/> </summary>
  public static void TheLockedDoor()
  {
    WriteTitle("The Locked Door");

    Door.CreateDoor().HandleDoor();
  }

  // *************************************************************************************************

  public class PasswordValidator
  {
    private static int _minLength = 6;
    private static int _maxLength = 13;


    private string Password { get; }
    private bool isValid { get; }

    public static void TestValidator()
    {
      string input;
      do
      {
        Console.Write("What password? ");
        input = Console.ReadLine();
        PasswordValidator password = new PasswordValidator(input);
        bool isValid = password.ValidatePassword();
        Console.Write($"Is password valid? ");
        Console.WriteLine(isValid);
      } while (input != "quit");
    }

    private PasswordValidator(string password)
    {
      Password = password;
    }

    private bool ValidatePassword()
    {
      bool hasValidLength = ValidateLength();
      bool hasRequiredChars = ValidateRequiredChars();
      bool lacksForbiddenChars = ValidateForbiddenChars();
      return hasValidLength && hasRequiredChars && lacksForbiddenChars;
    }

    private bool ValidateLength()
    {
      if (Password.Length < _minLength || Password.Length > _maxLength) return false;
      else return true;
    }

    private bool ValidateRequiredChars()
    {
      bool hasUppercase = false;
      bool hasLowercase = false;
      bool hasNumber = false;
      foreach (char character in Password)
      {
        if (char.IsUpper(character)) hasUppercase = true;
        if (char.IsLower(character)) hasLowercase = true;
        if (char.IsNumber(character)) hasNumber = true;
      }
      return hasNumber && hasUppercase && hasLowercase;
    }

    private bool ValidateForbiddenChars()
    {
      bool hasT = false;
      bool hasAmpersand = false;
      foreach (char character in Password)
      {
        if (character == 'T') hasT = true;
        if (character == '&') hasAmpersand = true;
      }
      return !hasT && !hasAmpersand;
    }
  }
  ///<summary>
  ///<br/> LEVEL 24: The Catacombs of the Class 
  ///<br/> Boss Battle 5/9: The Password Validator 
  ///<br/> The fifth and final pedestal describes a class that represents a concept more abstract than the first four: a password validator. You must create a class that will determine if a password is valid (meets the rules defined for a legitimate password). The pedestal initially doesn't describe any rules, but as you brush the dust off the pedestal, it vibrates for a moment, and the following rules appear:
  ///<br/> 
  ///<br/> - Passwords must be at least six letters long and no more than 13 letters long.
  ///<br/> - Passwords must contain at least one uppercase letter, one lowercase letter, and one number.
  ///<br/> - Passwords cannot contain a capital T or an ampersand (&) because Ingelmar in IT has decreed it.
  ///<br/> 
  ///<br/> The last rule seems random, and you wonder if the pedestal is just tormenting you with obscure rules.
  ///<br/> 
  ///<br/> You ponder for a moment about how to decide if a character is uppercase, lowercase, or a number, but while scratching your head, you notice a piece of folded parchment on the ground near your feet. You pick it up, unfold it, and read it:
  ///<br/> 
  ///<br/> **Hints:**
  ///<br/>   foreach with a string lets you get its characters!
  ///<br/>   > foreach (char letter in word) { ... }
  ///<br/>   
  ///<br/>   char has static methods to categorize letters!
  ///<br/>   > char.IsUpper('A'), char.IsLower('a'), char.IsDigit('0')
  ///<br/> 
  ///<br/> This might be useful information! You are grateful to whoever left it behind. It is signed simply "A."
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [ ] Define a new `PasswordValidator` class that can be given a password and determine, based on the rules above, if the password follows the rules and is valid.
  ///<br/> [ ] Make your main method loop forever, asking for a password and reporting whether the password is allowed using an instance of the `PasswordValidator` class.
  ///<br/> </summary>
  public static void ThePasswordValidator()
  {
    WriteTitle("The Password Validator");
    PasswordValidator.TestValidator();

  }

  // *************************************************************************************************

  ///<summary>
  ///<br/> LEVEL 24: The Catacombs of the Class 
  ///<br/> Boss Battle 6/9: Rock-Paper-Scissors 
  ///<br/> The first design pedestal requires you to provide an object-oriented design-- a set of objects, classes, and how they interact--for the game of Rock-Paper-Scissors, described below:
  ///<br/> 
  ///<br/> - Two human players compete against each other.
  ///<br/> - Each player picks Rock, Paper, or Scissors.
  ///<br/> - Depending on the player's choices, a winner is determined: Rock beats Scissors, Scissors beats Paper, Paper beats Rock. If both players pick the same option, it is a draw.
  ///<br/> - The game must display who won the round.
  ///<br/> - The game will keep running rounds until the window is closed but needs to remember the historical record of how many times each player won and how many draws there were.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [ ] Use CRC cards (or a suitable alternative) to outline the objects and classes that may be needed to make the game of Rock-Paper-Scissors. You do not need to create this full game; just come up with a potential design as a starting point.
  ///<br/> </summary>
  public static void RockPaperScissors()
  {
    WriteTitle("Rock-Paper-Scissors");



    // CRC Card example - copy paste to create and fill out more
    // Console.WriteLine(@"
    //   Class: <class name>
    //   Responsibilities:
    //   * <short verb phrase>
    //   * <another verb phrase>

    //   Collaborators:
    //   * <class 1>
    //   * <class 2>
    //   "
    // );

  }

  // *************************************************************************************************

  ///<summary>
  ///<br/> LEVEL 24: The Catacombs of the Class 
  ///<br/> Boss Battle 7/9: 15-Puzzle 
  ///<br/> The second pedestal requires you to provide an object-oriented design for the game of 15-Puzzle.
  ///<br/> 
  ///<br/> **Image:**
  ///<br/>   |-------------------|       |-------------------|
  ///<br/>   | 1  | 3  | 10 | 13 |       | 1  | 2  | 3  | 4  |
  ///<br/>   |----|----|----|----|       |----|----|----|----|
  ///<br/>   | 4  | 2  |    | 6  |       | 5  | 6  | 7  | 8  |
  ///<br/>   |----|----|----|----| ====> |----|----|----|----|
  ///<br/>   | 11 | 8  | 7  | 12 |       | 9  | 10 | 11 | 12 |
  ///<br/>   |----|----|----|----|       |----|----|----|----|
  ///<br/>   | 9  | 14 | 5  | 15 |       | 13 | 14 | 15 |    |
  ///<br/>   |-------------------|       |-------------------|
  ///<br/> 
  ///<br/> The game of 15-Puzzle contains a set of numbered tiles on a board with a single open slot. The goal is to rearrange the tiles to put the numbers in order, with the empty space in the bottom-right corner.
  ///<br/> 
  ///<br/> - The player needs to be abe to manipulate the board to rearrange it.
  ///<br/> - The current state of the game needs to be displayed to the user.
  ///<br/> - The game needs to detect when it has been solved and tell the player they won.
  ///<br/> - The game needs to be able to generate random puzzles to solve.
  ///<br/> - The game needs to track and display how many moves the player has made so far.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [ ] Use CRC cards (or a suitable alternative) to outline the objects and classes that may be needed to make the game of 15-Puzzle. You do not need to create this full game; just come up with a potential design as a starting point.
  ///<br/> [ ] Answer this question: Would your design need to change if we also wanted 3x3 or 5x5 boards?
  ///<br/> </summary>
  public static void FifteenPuzzle()
  {
    WriteTitle("15-Puzzle");


  }

  // *************************************************************************************************

  ///<summary>
  ///<br/> LEVEL 24: The Catacombs of the Class 
  ///<br/> Boss Battle 8/9: Hangman 
  ///<br/> The third pedestal in the room requires you to provide an object-oriented design for the game of Hangman. In Hangman, the computer picks a random word for the player to guess. The player then proceeds to guess the word by selecting letters from the alphabet, which get filled in, progressively revealing the word. The player can only get so many letters wrong (a letter that isn't in the word) before losing the game. An example run of this game could look like this:
  ///<br/> 
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   Word: _ _ _ _ _ _ _ _ _ | Remaining: 5 | Incorrect:  | Guess: e
  ///<br/>   Word: _ _ _ _ _ _ _ _ E | Remaining: 5 | Incorrect:  | Guess: i
  ///<br/>   Word: I _ _ _ _ _ _ _ E | Remaining: 5 | Incorrect:  | Guess: u
  ///<br/>   Word: I _ _ U _ _ _ _ E | Remaining: 5 | Incorrect:  | Guess: o
  ///<br/>   Word: I _ _ U _ _ _ _ E | Remaining: 4 | Incorrect: O | Guess: a
  ///<br/>   Word: I _ _ U _ A _ _ E | Remaining: 4 | Incorrect: O | Guess: t
  ///<br/>   Word: I _ _ U T A _ _ E | Remaining: 4 | Incorrect: O | Guess: s
  ///<br/>   Word: I _ _ U T A _ _ E | Remaining: 3 | Incorrect: OS | Guess: r
  ///<br/>   Word: I _ _ U T A _ _ E | Remaining: 2 | Incorrect: OSR | Guess: m
  ///<br/>   Word: I M M U T A _ _ E | Remaining: 2 | Incorrect: OSR | Guess: l
  ///<br/>   Word: I M M U T A _ L E | Remaining: 2 | Incorrect: OSR | Guess: b
  ///<br/>   Word: I M M U T A B L E
  ///<br/>   You won!
  ///<br/>   
  ///<br/> - The game picks a word at random from a list of words.
  ///<br/> - The game's state is displayed to the player, as shown above.
  ///<br/> - The player can pick a letter. If they pick a letter they already chose, pick again.
  ///<br/> - The game should update its state based on the letter the player picked.
  ///<br/> - The game needs to detect a win for the player (all letters have been guessed).
  ///<br/> - The game needs to detect a loss for the player (out of incorrect guesses).
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [ ] Use CRC cards (or a suitable alternative) to outline the objects and classes that may be needed to make the game of Hangman. You do not need to create this full game; just come up with a potential design as a starting point.
  ///<br/> </summary>
  public static void Hangman()
  {
    WriteTitle("Hangman");


  }

  // *************************************************************************************************

  public enum TicTacToeMarker { Blank, X, O }

  /// <summary>
  /// Game - logic
  /// Board - UI, state
  /// Player - moves, prompts?
  /// </summary>
  public class TicTacToeGame
  {
    private TicTacToeBoard Board { get; } = new TicTacToeBoard();
    private TicTacToeMarker CurrentMarker { get; set; } = TicTacToeMarker.X;

    public void StartGame()
    {
      string input;
      bool isValidMove;

      while (true)
      {
        RefreshBoard();
        input = PromptPlayerMove();
        if (input == "quit") break;
        isValidMove = PlayMove(input);

        if (isValidMove)
        {
          if (HandleCheckWin()) break;
          SwapPlayers();
        }
        else HandleInvalidMove();

        if (HandleCheckTie()) break;
      }

      Console.WriteLine("\nThanks for playing! Goodbye! ");
    }

    private void RefreshBoard()
    {
      Console.Clear();
      Console.WriteLine($"It is {CurrentMarker}'s turn. ");
      Board.DrawBoard();
    }

    private string PromptPlayerMove()
    {
      string input;

      Console.Write("What square do you want to play in (ex. A2)? ");
      return Console.ReadLine();
    }

    private bool PlayMove(string input)
    {
      char column = (char)input[0];
      int row = Convert.ToInt32(Convert.ToString(input[1]));

      bool isValidMove = Board.PlaceMarker(CurrentMarker, row - 1, column);
      return isValidMove;
    }

    private bool HandleCheckTie()
    {
      bool isFull = Board.CheckIsFull();
      if (isFull) Console.WriteLine("It's a tie... Oh well. ");
      return isFull;
    }

    private bool HandleCheckWin()
    {
      bool isWinner = Board.CheckWin(CurrentMarker);
      if (isWinner)
      {
        RefreshBoard();
        Console.WriteLine($"{CurrentMarker} is the winner! ");
      }
      return isWinner;
    }

    private void SwapPlayers() => CurrentMarker = CurrentMarker == TicTacToeMarker.X ? TicTacToeMarker.O : TicTacToeMarker.X;

    private void HandleInvalidMove()
    {
      Console.WriteLine("You can't play there. Try again.");
      Console.ReadKey();
    }
  }

  public class TicTacToeBoard
  {

    public TicTacToeMarker[,] Board { get; private set; } = new TicTacToeMarker[3, 3];
    private char _xMarker = 'X'; // '\u274c';
    private char _oMarker = 'O'; // '\u2b55';

    public void DrawBoard()
    {
      for (int i = 0; i < 3; i++)
      {
        char a = GetMarker(Board[i, 0]);
        char b = GetMarker(Board[i, 1]);
        char c = GetMarker(Board[i, 2]);

        Console.WriteLine($"{i + 1}  {a} | {b} | {c} ");
        if (i != 2) Console.WriteLine("  ---|---|---");
      }
      Console.WriteLine("   A   B   C ");

    }

    private char GetMarker(TicTacToeMarker marker)
    {
      return marker switch
      {
        TicTacToeMarker.X => _xMarker,
        TicTacToeMarker.O => _oMarker,
        _ => ' ',
      };
    }

    private int GetColumn(char rowLetter)
    {
      return rowLetter switch
      {
        'A' => 0,
        'B' => 1,
        'C' => 2,
        _ => -1
      };
    }

    public bool PlaceMarker(TicTacToeMarker marker, int row, char columnLetter)
    {
      int column = GetColumn(columnLetter);
      if (row < 0 || column < 0 || row >= Board.GetLength(0)) return false;

      bool isCellBlank = Board[row, column] == TicTacToeMarker.Blank;
      if (isCellBlank)
      {
        Board[row, column] = marker;
        return true;
      }
      else return false;
    }

    public bool CheckIsFull()
    {
      bool isFull = true;
      // TODO Why doesn't this work?
      // foreach (var row in Board)
      //   foreach (var cell in row)
      //     if (cell == TicTacToeMarker.Blank) isFull = false;
      for (int i = 0; i < Board.GetLength(0); i++)
      {
        for (int i2 = 0; i2 < Board.GetLength(1); i2++)
        {
          if (Board[i, i2] == TicTacToeMarker.Blank) isFull = false;
        }
      }

      return isFull;
    }

    public bool CheckWin(TicTacToeMarker marker)
    {
      // check rows
      for (int ir = 0; ir < Board.GetLength(0); ir++)
      {
        if (Board[ir, 0] == marker && Board[ir, 1] == marker && Board[ir, 2] == marker) return true;
      }

      // check columns
      for (int ic = 0; ic < Board.GetLength(1); ic++)
      {
        if (Board[0, ic] == marker && Board[1, ic] == marker && Board[2, ic] == marker) return true;
      }

      // check diagonals
      if (Board[0, 0] == marker && Board[1, 1] == marker && Board[2, 2] == marker) return true;
      if (Board[0, 2] == marker && Board[1, 1] == marker && Board[2, 0] == marker) return true;

      return false;
    }
  }

  ///<summary>
  ///<br/> LEVEL 24: The Catacombs of the Class 
  ///<br/> Boss Battle 9/9: Tic-Tac-Toe 
  ///<br/> Completing object-oriented designs for the three games in the Chamber of Design causes the pedestals to light up red again, and another door opens, letting you into the final chamber. This chamber has only a single large, broad pedestal. Inscribed on the stone floor in a circle around the pedestal are the engraved words "Only a True Programmer can build object-oriented programs."
  ///<br/> 
  ///<br/> More text engraved on the pedestal describes what you recognize as the game of Tic-Tac-Toe, stating that in ancient times, inhabitants of the land would use this as a Battle of Wits to determine the outcome of political strife. Instead of fighting wars, they would battle it out in a game of Tic-Tac-Toe.
  ///<br/> 
  ///<br/> Your job is to recreate the game of Tic-Tac-Toe, allowing two players to compete against each other. The following features are required:
  ///<br/> 
  ///<br/> - Two human players take turns entering their choice using the same keyboard.
  ///<br/> - The players designate which square they want to player in. Hint: You might consider using the number pad as a guide. For example, if they enter 7, they have chosen the top left corner of the board.
  ///<br/> - The game should prevent players from choosing squares that are already occupied. If such a move is attempted, the player should be told of the problem and given another chance.
  ///<br/> - The game must detect when a player wins or when the board is full with no winner (a draw/"cat").
  ///<br/> - When the game is over, the outcome is displayed to the players.
  ///<br/> - The state of the board must be displayed to the player after each play. Hint: One possible way to show the board could be like this:
  ///<br/> 
  ///<br/> SAMPLE PROGRAM:
  ///<br/>   It is X's turn.
  ///<br/>      | X |   
  ///<br/>   ---|---|---
  ///<br/>      | O | X 
  ///<br/>   ---|---|---
  ///<br/>    O |   |   
  ///<br/>    What square do you want to play in?
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [ ] Build the Tic-Tac-Toe as described in the requirements above. Starting with CRC cards is recommended, but the goal is to make working software, not CRC cards.
  ///<br/> [ ] Answer this question: How might you modify your completed program if running multiple rounds was a requirement (for example, a best-out-of-five series)?
  ///<br/> </summary>
  public static void TicTacToe()
  {
    WriteTitle("Tic-Tac-Toe");

    new TicTacToeGame().StartGame();
  }
}

