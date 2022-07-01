# AliMiraKim's Notes: The C# Player's Guide (4th Edition)

## Part 1: The Basics
1. The C# Programming Language
2. Getting an IDE
3. Hello World: Your First Program
4. Comments
5. Variables
6. The C# Type System
7. Math
8. Console 2.0
9. Decision Making
10. Switches
11. Looping
12. Arrays
13. Methods
14. Memory Management

## Part 2: Object-Oriented Programming
15. Object-Oriented Concepts
16. Enumerations
17. Tuples
18. Classes
19. Information Hiding
20. Properties
21. Static
22. Null References
23. Object-Oriented Design
24. The Catacombs of the Class
25. Inheritance
26. Polymorphism
27. Interfaces
28. Structs
29. Records
30. Generics
31. The Fountain of Objects
32. Some Useful Types

## Part 3: Advanced Features
33. Managing Larger Programs
34. Methods Revisited
35. Error Handling and Exceptions
36. Delegates
37. Events
38. Lambda Expressions
39. Files
40. Pattern Matching
41. Operator Overloading
42. Query Expressions
43. Threads
44. Asynchronous Programming
45. Dynamic Objects
46. Unsafe Code
47. Other Language Features
48. Beyond a Single Project
49. Compiling in Depth
50. .NET
51. Publishing


## Part 4: The Endgame
52. The Final Battle
53. Into Lands Uncharted

## Part 5: Bonus Levels
A. Visual Studio
B. Compiler Errors
C. Debugging Your Code

---

### Level 8: Console 2.0
#### Speedrun
* The `Console` class can write a line without wrapping (`Write`), wait for a single keypress (`ReadKey`), change colors (`ForegroundColor`, `BackgroundColor`), clear the entire console window (`Clear`), change the window title (`Title`), and play retro 80's beep sounds (`Beep`).
* Escape sequences start with a `\` and tell the computer to intepret the following letter differently. `\n` is a new line, `\t` is a tab, `\"` is a quote within a string literal.
* An `@` before a string ignores any would-be escape sequences `@"C:\Users\Me\File.txt"`.
* A `$` before a string means curly braces contain code: `$"a:{a} sum:{a+b}"`.

#### The `Console` Class


##### The `Write` Method
**Sample: `Console.Write`**
```cs
Console.Write("What is your name, human? "); // Notice the space at the end.
string userName = Console.ReadLine(); 

// Console:
// What is your name, human? AMK
```

##### The `ReadKey` Method
**Sample: `Console.ReadKey`**
```cs
Console.WriteLine("Press any key when you're ready to begin.");
// Problem: Typed key shows on screen.
Console.ReadKey();
// Console:
// Press any key when you're ready to begin.
// j

Console.WriteLine("Press any key when you're ready to begin.");
// Solution: bool-type param controls if typed key should be 'intercepted' to not be visible
Console.ReadKey(true);
```


##### Changing Colors
**Sample: Changing Console Colors**
```cs
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
```


##### The `Clear` Method
**Sample: `Console.Clear`**
```cs
Console.Clear(); // Wipes all text on console screen and will update background to newly-set color.
```

##### Changing the Window Title
**Sample: `Console.Title`**
```cs
Console.Title = "Hello World!"; // Defaults to filename, ex: C:\Users\AMK\Source\Repos\HelloWorld\HelloWorld\bin\Debug\net5.0\HelloWorld.exe
```

##### The `Beep` Method
**Sample: Console.Beep**
```cs
Console.Beep();

Console.Beep(440, 1000); // (frequency, duration)
// Higher frequency means higher pitch. 440 is a nice middle pitch
// Duration is in milliseconds. 1000ms is 1 second.
```

#### Sharpening Your String Skills

##### Escape Sequences
**Sample: Escape with backslash**
```cs
// Problem
// Console.WriteLine("""); // ERROR: Bad quotation marks!

// Solution
Console.WriteLine("\"");

Console.WriteLine("Hello!\n\tThis is on a new line and tabbed! \rThis is a carriage return and goes back to the start of the line!");

Console.WriteLine("C:\\Users\\AMK\\Desktop\\MyFile.txt"); // C:\Users\AMK\Desktop\MyFile.txt
```

**Sample: Vebatim string literal**
```cs
Console.WriteLine(@"C:\Users\AMK\Desktop\MyFile.txt"); // C:\Users\AMK\Desktop\MyFile.txt
```


##### String Interpolation
**Sample: String concatenation vs interpolation`**
```cs
// string concatenation
Console.Write("My favorite number is " + myFavoriteNumber + ".");

// string interpolation
Console.Write($"My favorite number is {myFavoriteNumber}.");
```


##### Alignment
**Sample: Alignment syntax**
```cs
string name1 = Console.ReadLine();
string name2 = Console.ReadLine();

```


##### Formatting


##### Challenge: The Defense of Consolas
```bash
Target Row? 6
Target Column? 5
Deploy to:
(6, 4)
(5, 5)
(6, 6)
(7, 5)
```
**Objectives:**
* Ask the user for the target row and columns.
* Compute the neighboring rows and columns of where to deploy the squad.
* Display the deployment instructions in a different color of your choosing.
* Change the window title to be "Defense of Consolas".
* Play a sound with `Console.Beep` when the results have been computed and displayed.

### Level 9: Decision Making
#### Speedrun
* An `if` statement lets some code run (or not) based on a condition. `if (condition) DoSomething;`
* An `else` statement identifies code to run otherwise.
* Combine `if` and `else` statements to pick from one of several branches of code.
* A block statement lets you put many statements into a single bundle. An `if` statement can work around a block statement: `if (condition) { DoSomething; DoSomethingElse; }`
* Relational operators let you check the relationship between two elements: `==`, `+=`, `<`, `>`, `<=`, and `>=`.
* The `!` operator inverts ia `bool` expression.
* Combine multiple `bool` expressions with the `&&` ("and") and `||` ("or") operators.

#### The `if` Statement


##### Block Statements


##### Block Statements Get Their Own Variables


#### The `else` Statement


#### `else if` Statements


#### Relational Operators: `==`, `!=`, `<`, `>`. `<=`, `>=`


#### Using `bool` in Decision Making


##### Challenge: Repairing the Clocktower
**Objectives:**
* Take a number as input from the console.
* Display the word "Tick" if the number is even. Display the word "Tock" if the number is odd.
* **Hint:** Remember that you can use the remainder operator to determine if a number is even or odd.

#### Logical Operators


#### Nesting `if` Statements


#### The Conditional Operator


##### Challenge: Watchtower
**Objectives:**
* Ask the user for an `x` value and a `y` value. These are coordinates of the enemy relative to the watchtower's location.
* Using the image on the right, if statements, and relational operators, display a message about what direction the enemy is coming from. For example, "The enemy is to the northwest!" or "The enemy is here!"

### Level 10:  Switches
#### Speedrun
* Switches are an alternative to `if` statements with lots of parts.
* The statement form: `switch (number) { case 0: DoStuff(); break;  case 1: DoStuff(); break; default: DoStuff(); break; }`
* The expression form: `number switch { 0 => "zero", 1 => "one", _ => "other" }`

#### Switch Statements


##### Multiple Cases for the Same Arm


#### Switch Expressions


#### Switches as a Basis for Pattern Matching


##### Challenge: Buying Inventory
```bash
The following items are available:
1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies
What number do you want to see the price of? 2
Torches cost 15 gold.
```
**Objectives:**
* Build a program that will show the menu illustrated above.
* Ask the user to enter a number from the menu.
* Using the information above, use a switch (either type) to show the item's cost.

##### Challenge: Discounted Inventory
**Objectives:**
* Modify your program from before to also ask the user for their name.
* If their name equals your name, divide the cost in half.

### Level 11:  Looping
#### Speedrun
* Loops repeat code.
* `while` loop: `while (condition) { ... }`
* `do`/`while` loop: `do { ... }  while (condition);`
* `for` loop: `for (initialization, condition, update) { ... }`
* `break` exits the loop. `continue` immediately jumps to the next iteration of the loop.

#### The `while` Loop

#### The `do`/`while` Loop


##### Variables Declared in Block Statements and Loops


#### The `for` Loop


####  `break` Out of Loops and `continue` to the Next Pass


#### Nesting Loops


##### Challenge: The Prototype
**Sample Program:**
```bash
User 1, enter a number between 0 and 100: 27

User 2, guess the number.
What is your next guess? 50
50 is too high.
What is your next guess? 25
25 is too low.
What is your next guess? 27
You guessed the number!
```
**Objectives:**
* Build a program that will allow a user, the pilot, to enter a number.
* If the number is above 100 or less than 0, keep asking.
* Clear the screen once the program has collected a good number.
* Ask a second user, the hunter, to guess numbers.
* Indicate whether the user guessed too high, too low, or guessed right.
* Loop until they get it right, then end the program.

##### Challenge: The Magic Cannon
**Sample Output:**
```bash
1: Normal
2: Normal
3: Fire
4: Normal
5: Elective
6: Fire
7: Normal
```
**Objectives:**
* Write a program that will loop through the values between 1 and 100 and display what kind of blast the crew should expect. (The % operator may be of use.)
* Change the color of the output based on the the type of blast. (For example, red for Fire, yellow for Electric, and blue for Electric and Fire).


---

### Level 12:  Arrays
#### Speedrun
* Arrays contain multiple values of the same type. `int[] scores = new int[3];`
* Square brackets access elements in an array, starting with 0: `scores[2] = scores[0] + scores[1];`
* Indexing from end: `int last = scores[^1];`
* Getting a range: `int[] someScores = scores[1..3];`
* `Length` tells you how many elements an array can hold: `scores.Length`
* Lots of ways to create arrays: `new int[3], new int[] { 1, 2, 3 }, new [] { 1, 2, 3 }`
* Arrays can be of any type, including arrays of arrays (`string[]`,`bool[][]`,`int[][][]`).
* The `foreach` loop: `foreach (int score in scores) { ... }`
* Multi-dimensional arrays: `int [,] grid = new int[3, 3];`

#### Creating Arrays


#### Getting and Setting Values in Arrays


##### Default Values


##### Crossing Array Bounds


##### Indexing from the End


##### Ranges


#### Other Ways to Create Arrays


#### Some Examples with Arrays


##### Challenge: The Replicator of D'To
**Objectives:**
* Make a program that creates an array of length 5.
* Ask the user for five numbers and put them in the array.
* Make a second array of length 5.
* Use a loop to copy the values out of the original array and into the new one.
* Display the contents of both arrays one at a time to illustrate that the Replicator of D'To works again.

#### The `foreach` Loop


#### Challenge: The Laws of Freach
**Objectives:**
* Start with the code for computing an array's minimum and average values in the section *Some Examples with Arrays*, starting on page 90.
* Modify the code to use `foreach` loops instead of `for` loops.

#### Multi-Dimensional Arrays


---

### Level 13:  Methods
#### Speedrun
* Methods let you name and reuse a chunk of code: `void CountToTen() { ... }`
* Parameters allow a method to work with different data each time it is called: `void CountTo(int amount) { ... }`
* Methods can produce a result with a return value: `int GetNumber() { return 2; }`
* Two methods can have the same name (an overload) if their parameters are different.
* Some simple methods can be defined with an expression body: `int GetNumber() => 2;`
* Recursion is when a method calls itself.

#### Defining a Method


#### Calling a Method


##### Methods Get Their Own Variables


#### Passing Data to a Method


##### Multiple Parameters


##### Copied Values in Method Calls


#### Returning a Value from a Method


##### Returning Early


#### Method Overloading


#### Simple Methods with Expressions


#### XML Documentation Comments


##### Challenge: Taking a Number
**Objectives:**
* Make a method with the signature `int AskForNumber(string text)`. Display the `text` parameter on the command line. Retrieve a response from the user, convert it to an `int`, and return it. Sample usage: `int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");`
* Make a method with the signature `int AskForNumberInRange(string text, int min, int max)`. Only return if the entered number is between `min` and `max` values. Otherwise, ask again.
* Place this method in at least one of your previous programs to improve it.

#### The Basics of Recursion


##### Challenge: Countdown
```csharp
for (int x = 10; x > 0; x--)
    Console.WriteLine(x);
```
**Objective:**
* Write code that counts down from 10 to 1 using a recursive method.
* **Hint:** Remember that you must have a base case that ends the recursion and that every time you call the method recursively, you must be getting closer and closer to that base case.

---

### Level 14:  Memory Management
#### Speedrun
* When you get done using memory, it needs to be cleaned up.
* The stack: When a method is called, enough space is reserved for its local variables and parameters (its stack frame). When you return from a method, space is reclaimed and reused. The stack's memory management strategy is most straightforward when data is always a known size.
* The heap: When data is needed, a free spot in memory is found. A reference is used to keep track of objects placed on the heap.
* The garbage collector has the task of inspecting things on the heap to see if they are still in use. If not, it lets the heap memory be reused.
* Some types are value types: they store their data in the variable's location in memory. All the numeric types (`int`, `double`, `long`, etc.), `bool`, and `char` are value types.
* Some types are reference types: `string` and arrays.
* You have value semantics when two things are considered equal if they contain references to the same heap object.

#### Memory and Memory Management


#### The Stack


##### Parameters


##### Return Values


#### Fixed-Size Stack Frames


#### The Heap


##### The Heap as a Graph of Objects


##### Value Types and Reference Types


##### Value Semantics and Reference Semantics


#### Cleaning Up Heap Memory


##### Automatic Memory Management


#### Boss Bottle: Hunting the Manticore
**Sample Program:**
```bash
Player 1, how far away from the city do you want to station the Manticore? 32

Player 2, it is your turn.
--------------------------------------------------------------------
STATUS: Round: 1  City: 15/15  Manticore: 10/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 50
That round OVERSHOT the target.
--------------------------------------------------------------------
STATUS: Round: 2  City: 14/15  Manticore: 10/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 25
That round FELL SHORT of the target.
--------------------------------------------------------------------
STATUS: Round: 3  City: 13/15  Manticore: 10/10
The cannon is expected to deal 3 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
--------------------------------------------------------------------
STATUS: Round: 4  City: 12/15  Manticore: 7/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
--------------------------------------------------------------------
STATUS: Round: 5  City: 11/15  Manticore: 6/10
The cannon is expected to deal 3 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
--------------------------------------------------------------------
STATUS: Round: 6  City: 10/15  Manticore: 3/10
The cannon is expected to deal 3 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
The Manticore has been destroyed! The city of Consolas has been saved!
```
**Objectives:**
* Establish the game's starting state: the *Manticore* begins with 10 health points and the city with 15. The game starts at round 1.
* Ask the first player to choose the *Manticore's* distance from the city (0 to 100). Clear the screen afterward.
* Run the game in a loop until either the *Manticore's* or city's health reaches 0.
* Before the second player's turn, display the round number, the city's health, and the *Manticore's* health.
* Compute how much damage the cannon will deal this round: 10 points if the round number is a multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to the player.
* Get a target range from the second player, and resolve its effect. Tell the user if they overshot (too far), fell short, or hit the *Manticore*. If it was a hit, reduce the *Manticore's* health by the expected amount.
* If the *Manticore* is still alive, reduce the city's health by 1.
* Advance to the next round.
* When the *Manticore* of the city's health reaches 0, end the game and display the outcome.
* Use different colors for different types of messages.
* **Note:** This is the largest program you have made so far. Expect it to take some time!
* **Note:** Use methods to focus on solving one problem at a time.
* **Note:** This version requires too players, but in the future, we will modify it to allow the computer to randomly place the *Manticore* so that it can be a single-player game.