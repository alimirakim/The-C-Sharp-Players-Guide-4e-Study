using System;
namespace Template;

/// <summary>
/// LEVEL 24: The Catacombs of the Class 
/// </summary>
public static class Level24
{
  public static void CallAll()
  {
    ThePoint();
    TheColor();
    TheCard();
    TheLockedDoor();
    ThePasswordValidator();
    RockPaperScissors();
    FifteenPuzzle();
    Hangman();
    TicTacToe();
  }

  /// <summary>
  /// Boss Battle 1/9: The Point 
  ///<br/> The first pedestal asks you to create a `Point` class to store a point into two dimensions. Each point is represented by an x-coordinate (referred to as x), a side-to-side distance from a special central point called the origin, and a y-coordinate (referred to as y), an up-and-down distance away from the origin.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Define a new `Point` class with properties for `X` and `Y`.
  ///<br/> [] Add a constructor to create a point from a specific x- and y-coordinate.
  ///<br/> [] Add a parameterless constructor to create a point at the origin (0, 0).
  ///<br/> [] In your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the console window in the format `(x, y)` to illustrate that the class works.
  ///<br/> [] Answer this question: Are your `X` an `Y` properties immutable? Why did you choose what you did?
  /// </summary>
  public static void ThePoint()
  {
    Utils.WriteTitle("The Point");


  }

  /// <summary>
  /// Boss Battle 2/9: The Color 
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
  ///<br/> [] Define a new `Color` class with properties for its red, green, and blue channels.
  ///<br/> [] Add appropriate constructors that make sense for creating new `Color` objects.
  ///<br/> [] Create static properties to define the eight commonly used colors for easy access.
  ///<br/> [] In your main method, make two `Color`-typed variables. Use a constructor to create a color instance and use a static property for the other. Display each of their red, green, and blue channel values.
  /// </summary>
  public static void TheColor()
  {
    Utils.WriteTitle("The Color");


  }

  /// <summary>
  /// Boss Battle 3/9: The Card 
  ///<br/> The digital Realms of C# have playing cards like ours but with some differences. Each card has a color (red, green, blue, yellow) and a rank (the numbers 1 through 10, followed by the symbols $, %, ^, and &). The third pedestal requires that you create a class to represent a card of this nature. 
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Define enumerations for card colors and card ranks.
  ///<br/> [] Define a `Card` class to represent a card with a color and a rank, as described above.
  ///<br/> [] Add properties or methods that tell you if a card is a number or a symbol card (the equivalent of a face card).
  ///<br/> [] Create a main method that will create a card instance of every card (every color with every rank) and display it (for example, "The Red Ampersand" and "The Blue Seven", or some other similar scheme).
  ///<br/> [] Answer this question: Why do you think we used a color enumeration here, but in the previous challenge, we made a color class?
  /// </summary>
  public static void TheCard()
  {
    Utils.WriteTitle("The Card");


  }

  /// <summary>
  /// Boss Battle 4/9: The Locked Door 
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
  ///<br/> [] Define a `Door` class that can keep track of whether is locked, open, or closed.
  ///<br/> [] Make it so you can perform the four transitions defined above with methods.
  ///<br/> [] Build a constructor that requires the starting numeric passcode.
  ///<br/> [] Build a method that will allow you to change the passcode for an existing door by supplying the current passcode and a new passcode. Only change the passcode if the current passcode is correct.
  ///<br/> [] Make your main method ask the user for a starting passcode, then create a new `Door` instance. Allow the user to attempt the four various transitions described above (open, close, lock, unlock) and change the code by typing in text commands.
  /// </summary>
  public static void TheLockedDoor()
  {
    Utils.WriteTitle("The Locked Door");


  }

  /// <summary>
  /// Boss Battle 5/9: The Password Validator 
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
  ///<br/> [] Define a new `PasswordValidator` class that can be given a password and determine, based on the rules above, if the password follows the rules and is valid.
  ///<br/> [] Make your main method loop forever, asking for a password and reporting whether the password is allowed using an instance of the `PasswordValidator` class.
  /// </summary>
  public static void ThePasswordValidator()
  {
    Utils.WriteTitle("The Password Validator");


  }

  /// <summary>
  /// Boss Battle 6/9: Rock-Paper-Scissors 
  ///<br/> The first design pedestal requires you to provide an object-oriented design-- a set of objects, classes, and how they interact--for the game of Rock-Paper-Scissors, described below:
  ///<br/> 
  ///<br/> - Two human players compete against each other.
  ///<br/> - Each player picks Rock, Paper, or Scissors.
  ///<br/> - Depending on the player's choices, a winner is determined: Rock beats Scissors, Scissors beats Paper, Paper beats Rock. If both players pick the same option, it is a draw.
  ///<br/> - The game must display who won the round.
  ///<br/> - The game will keep running rounds until the window is closed but needs to remember the historical record of how many times each player won and how many draws there were.
  ///<br/> 
  ///<br/> OBJECTIVES: 
  ///<br/> [] Use CRC cards (or a suitable alternative) to outline the objects and classes that may be needed to make the game of Rock-Paper-Scissors. You do not need to create this full game; just come up with a potential design as a starting point.
  /// </summary>
  public static void RockPaperScissors()
  {
    Utils.WriteTitle("Rock-Paper-Scissors");


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

  /// <summary>
  /// Boss Battle 7/9: 15-Puzzle 
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
  ///<br/> [] Use CRC cards (or a suitable alternative) to outline the objects and classes that may be needed to make the game of 15-Puzzle. You do not need to create this full game; just come up with a potential design as a starting point.
  ///<br/> [] Answer this question: Would your design need to change if we also wanted 3x3 or 5x5 boards?
  /// </summary>
  public static void FifteenPuzzle()
  {
    Utils.WriteTitle("15-Puzzle");


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

  /// <summary>
  /// Boss Battle 8/9: Hangman 
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
  ///<br/> [] Use CRC cards (or a suitable alternative) to outline the objects and classes that may be needed to make the game of Hangman. You do not need to create this full game; just come up with a potential design as a starting point.
  /// </summary>
  public static void Hangman()
  {
    Utils.WriteTitle("Hangman");


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

  /// <summary>
  /// Boss Battle 9/9: Tic-Tac-Toe 
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
  ///<br/> [] Build the Tic-Tac-Toe as described in the requirements above. Starting with CRC cards is recommended, but the goal is to make working software, not CRC cards.
  ///<br/> [] Answer this question: How might you modify your completed program if running multiple rounds was a requirement (for example, a best-out-of-five series)?
  /// </summary>
  public static void TicTacToe()
  {
    Utils.WriteTitle("Tic-Tac-Toe");


  }
}