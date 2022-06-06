# AliMiraKim's Notes: The C# Player's Guide (4th Edition)

SCHEDULE
Sat 4. Level 1-6
Sun 5. Level 7-9
M-F 6-10. Level 10-14
Sat 11. Level 15-17
Sun 12. Level 18-20
M-F 13-17. Level 21-25
Sat 18. Level 26-
Sun 19. 
M-F 20-24. 
Sat 25. 
Sun 26. 

Week 1 (4-5): 1-8, 
Week 2 (6-12): 9-14 Practice project
Week 3 (13-19): 15-32 Practice project
Week 4 (20-26): 33-51 Final project


14
32
51
53

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

### Level 1: The C# Programming Language
#### Speedrun
* C# is a general-purpose programming language. You can make almost anything with it.
* C# runs on .NET, which is many things: a runtime that supports your program, a library of code to build upon, and a set of tools to aid in constructing programs.

Programming languages are the bridge between human language and computer binary instructions. They are precise enough for a computer to run and clear enough for a human to understand.

#### What is C#?
C# is both widely used and very loved. 

C# is a general-purpose programming language. Can be used for games, desktop programs, web and mobile apps, etc. Best when building applications. Not for making a new operating system or device driver.

C# is balanced between power and ease of use. 

C# is a living language that's changed significantly in its 20+ years. It's on version 10 with new major updated every 1-2 years.

C# is in the same is in the same family of languages as C, C++, and Java.

C# is a cross-platform language able to run on every manjor operating system including: Windows, Linux, macOS, iOS, and Android.

C# is also:
* statically typed
* garbage-collected
* object-oriented
* with imperative, functional, and event-driven aspects
* allows for dynamic typing and unmanaged code in small doses

#### What is .NET?
Often called a framework or platform, but is actually the entire ecosystem surrounding the programs and programmers using it. It is shared by multiple programming languages, the most popular including: C#, Visual Basic, F#, and PowerShell. Thus you could write C# code and use it in a Visual Basic program.

.NET includes:
* a *runtime* that is extraordinarily capable.
* the *Base Class Library (BCL)* with practical utilities like for opening files or computing a square root.
* a *Software Development Kit (SDK)* with tools to make programming easier.
* things to help build specific programs like web, mobile, and desktop applications.


> **.NET** - Often called a framework or platform. The ecosystem surrounding C# programs and programmers that use it. 
> **runtime** - The environment your program runs within. Figuratively, it's the air your program breathes and the round it stands on as it runs. All languages have a runtime of some kind. 
> **Base Class Library (BCL)** - A pile of code included in .NET that can be used directly in C# programs. Examples: BCL can be used to open files or compute a square root.
> **Software Development Kit (SDK)** - A broad set of tools included in .NET to make coding easier.


### Level 2: Getting an IDE
#### Speedrun
* Programming is complex; you want an IDE to make programming life easier.
* Visual Studio is the most used IDE for C# programming. Visual Studio Community is free, feature-rich, and recommended for beginners.
* Other C# IDEs exist, including Visual Studio Code and Rider.

> **Integrated Development Environment (IDE)** - An application with tools designed to streamline the programming process. 

#### A Comparison of IDEs

Notable IDE options:
* Visual Studio
* Visual Studio Code - https://csharpplayersguide.com/articles/visual-studio-code
* Visual Studio for Mac
* JetBrains Rider
* Other IDEs
* Online Editors
* No IDE

##### Visual Studio
* First choice recommendation.
* The tried-and-true IDE that most C# devs use. 
* Has existed since before C#. 
* The most feature-rich and capable. 
* Works on Windows but not Mac or Linux.
* Free (unless used by a large company).

Comes in three 'editions': Community, Professional, Enterprise.
* Community - Free, for students, hobbyists, open-source projects, and individuals for commercial use.
* Professional - Same as Community but paid, for large companies (either with more than 250 computers, more than $1 million annually, or more than five Visual Studio users).
* Enterprise - Has expanded features at extra cost.

##### Visual Studio Code
* See more: https://csharpplayersguide.com/articles/visual-studio-code
* Second choice recommendation.
* A lightweight editor.
* Works on Windows, Mac, and Linux.
* Vibrant, growing community.
* Limited features compared to Visual Studio; requires use of CLI.
* Good if on Linux/Max and comfortable with CLI.
* Free.

##### Visual Studio for Mac
* Originally 'Xamarin Studio'.
* Despite the name, is a different product with many differences.
* Only for Mac.
* Has three editions like Visual Studio.

##### JetBrains Rider
* The only non-Microsoft IDE here.
* Rider is newer among C# IDEs, but JetBrains is a veteran for IDEs in general.
* Feature-rich.
* Cross-platform.
* Paid; cheapest option is $140/year.

##### Other IDEs
* Most C# programmers use one of the above.
* Other IDEs are often missing many features, aren't well-supported, and have less online help and docs.

##### Online Editors
* For tinkering with C# without downloading tools.
* Limited features and don't keep up with the latest C# version.
* See more: https://csharpplayersguide.com/articles/online-editors

##### No IDE
* Not recommended for new programmers.
* Possible for veteran programmers skilled with CLI and patching together editors and scripts if desired.
* Requires using `dotnet` CLI tool create, compile, test, and pacakge programs.

#### Installing Visual Studio
1. Download Visual Studio Installer from: https://www.visualstudio.com/downloads
2. Use the installer to install and configure Visual Studio. Choose Community Edition version when installing.
3. The installer will ask which components to include. Installing everything makes Visual Studio a lumbering, all-powerful behemoth, but most of it isn't required here. 
4. The only *required* component for the book is found here: Go to **Workloads** tab. Find the one towards the bottom named **.NET Core cross-platform development**. Click on it to enable.
5. To change the installed components, rerun the Visual Studio Installer.
6. Open Visual Studio and sign in with a Microsoft account. It's required and free. An account enables syncing settings across devices among other things.
7. The first time installing Visual Studio provides a chance to pick development settings like keyboard shortcuts and color theme. 

##### Challenge: Install Visual Studio
* Install Visual Studio Community edition (or any other IDE) and get it ready to start programming.


#### Bonus! Visual Studio Code
* See more: https://csharpplayersguide.com/articles/visual-studio-code

> Run > Add Configuration... > .NET 5+ and .NET Core
`dotnet new console`

`dotnet run`

---

### Level 3: Hello World: Your First Program
#### Speedrun
* New projects usually begin life by being generated from a template.
* A C# program starts running in the program's entry point or main method.
* A full Hello World program looks like this: `System.Console.WriteLine("Hello World!");`
* Statements are single commands for the computer to perform. They run one after the next.
* Expressions allow you to define a value that is computed as the program runs from other elements.
* Variables let you store data for use later.
* `Console.ReadLine()` retrieves a full lne of text that a user types from the console window.

> **source code** - Instructions written in a programming language for the computer to run.
> **configuration** - Instructions given to the computer to help it know how to compile or translate code into binary instructions the computer can run.
> **template** - Standard starting points that help get the configuration right for specific project types and provide starting code.
> **compiling** - The transformation of code into binary instructions the computer can run by a special program called a *compiler*.
> **compiler** - A special program that takes a project's code and configuration and produces binary instructions that the computer can run directly (simplified explanation). Creates a resulting `.exe` or `.dll` file for the computer to run.
> **syntax** - A set of rules that describe how to make a working program in that language.
> **entry point** or **main method** - The starting point where a C# program begins running.
> **identifiers** or (casually) **names** - Used to name new things you create and to refer to previously created things. Ex. `System`, `Console`, `WriteLine`.
> **members** - Things contained in another thing.
> **member access operator** or **dot operator** - A period symbol `.` used to access members of another thing. Ex. `System.Console.WriteLine` accesses the `WriteLine` member of `Console`, which is a member of `System`.
> **namespace** - Something that contains other things under a shared name and is primarily an organizational tool, similar to a directory or folder. Ex. `System`
> **class** - A single entity that focuses on solving one problem well. A class combines 1. the data it needs to track over time and 2. the abilities or services it provides to other parts of the program. Ex. The `Console` class is focused on the console window. It contains data about the console window's current state and a list of abilities or tasks involving interacting with or manipulating the console window.
> **method** - Code that will run when something asks for the task to be performed. Ex. The `WriteLine` method runs when `Console` invokes it.
> **method invocation** or **calling a method** - Telling a method to run its code. Parentheses `( )` are used to call a method. Ex. `Console.WriteLine("Hello World!")`
> **statement** - A single command to perform. Most statements in C# end in a semicolon `;`.
> **fully qualified name** - The unabbreviated name of a class without `using` directives. Ex. `System.Console` vs the *simple name* `Console`.
> **keyword** - A special word that the language and compiler understand the meaning of. C# has over 100 keywords. Ex. `using`
> **expression** - Bits of code that a program must process or *evaluate* to determine the result. Expressions define how to produce a value from smaller elements. Used by the computer to compute the expression's resulting value as it runs. Ex. `"Hi " + "User"`
> **variables** - Containers for data. They're called 'variables' because their contents can change or vary as the program runs.
> **declaring a variable** - Creating a variable by providing a name and its type. Ex. `string name;`
> **assignment** - Placing values in a variable to use later. `name = "User";`
> **return a value** - When a method produces a value.
> **debugging** - Trying to figure out why a program doesn't do what you expected and adjusting it accordingly.

#### Creating a New Project
A C# project is a combination of two things, which live as simple text files:
1. **C# Source Code** (`.cs`)
2. **Configuration** (`.csproj`)

Most C# programs start with a *template*. Templates help get the configuration right for specific project types.

TODO Add more notes here (p16-p18)

#### A Brief Tour of Visual Studio
TODO Add notes (p18)

#### Compiling and Running Your Program
Generating a project from a template produces a complete program. To run a C# program, it must be *compiled* by a *compiler* into an `.exe` or `.dll` file of binary instructions the computer can run. Your IDE should have options to make it easy to compile and run your program.

**For Visual Studio, any of these:**
a. Choose **Debug > Start Debugging** from the main menu.
b. Press **F5**.
c. Push the green start button in the toolbar.

##### Challenge: Hello World!
**Objectives:**
* Create a new Hello World program from the C# **Console Application** template, targeting **.NET 5**.
* Run your program using any of the three methods described above.

#### The Adventure Begins
C# has two ways to define an entry point. The traditional way includes lengthy boilerplate while the new way has been streamlined.

**Snippet: Traditional Entry Point**
```cs
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

**Snippet: New Entry Point**
```cs
System.Console.WriteLine("Hello World!");
```

The above codeline is a single *statement* and ggoes through the following steps:
1. Finds the *namespace* `System`.
2. Finds `System`'s *member* *class* `Console`.
3. Finds `Console`'s member *method* called `WriteLine`.
4. *Invokes* `WriteLine` to run with the text `"Hello World!"`.

C# executes statements top to bottom and left to right, one at a time. 

C# ignores whitespace.

**Snippet: Ignoring Whitespace**
```cs
// This will run, but is difficult to read.
System.
        Console                      .   WriteLine
(                      "Hello World!"                                    )
;
```

##### `using` Directives
Accessing a class normally requires going through its namespace. C# has a special type of statement called a `using` directive that can be put at the top of a file to sidestep this need. Ex. `using System;` The compiler knows to search the namespaces provided in the `using` directives when encountering identifiers like `Console`.


```cs
using System;
Console.WriteLine("Hello World!"); // Doesn't require System.Console.Blah...
```

##### Challenge: What Comes Next
**Objectives:**
* Replace the file's contents with a `using System;` and `Console.WriteLine("Hello World!");`
* Change your program to say something (anything!) besides "Hello World!"

##### Multiple Statements
A C# program runs one statement at a time in the order they appear in the file. 

```cs
using System;

Console.WriteLine("Hello World!");
Console.WriteLine("Annyeong chingoo!");
Console.WriteLine("Sup");
```

##### Challenge: The Makings of a Programmer
**Objectives:**
* Make a program with 5 `Console.WriteLine` statements in it.
* **Answer this question:** How many statements do you think a program can contain?

##### Expressions
*Expressions* are a building block used to define how to produce a value from smaller elements. C# programs use expressions heavily. They can be used anywhere a value is needed.

**Snippet: Using a Value vs Expression**
```cs
// value
Console.WriteLine("Hi User");

// expression
Console.WriteLine("Hi " + "User");
```

##### Variables
*Variables* are another building block used to contain data.

**Snippet: Variable**
```cs
// declaring
string name;

// assigning
name = "User";

// using in an expression
Console.WriteLine("Hi " + name);
```

##### Reading Text from the Console
`Console` has a `ReadLine` method that retrieves text somebody types until they his Enter and *returns* the inputted value.

**Snippet: Console.ReadLine**
```cs
string name;
name = Console.ReadLine();
Console.WriteLine("Hi " + name);
```


##### Challenge: Consolas and Telim
```bash
Bread is ready.
Who is the bread for?
RB
Noted: RB got bread.
```
**Objectives:**
* Make a program that runs as shown above, including taking a name from the user.


#### Compiler Errors, Debuggers, and Configurations

##### Compiler Errors
When the compiler runs into code that it cannot understand, it can't transform the code into something the computer can understand either. When trying to run such a program, it will show the Error List window listing problems the compiler sees. The broken code will be shown underlined with red squigglies.

See Bonus Level B for suggestions on what to do when unable to get your program to compile.

##### Debugging
See Bonus Level C for tools in Visual Studio to help with debugging.

##### Build Configurations
For C#, configuration data is organized into different build configurations with each providing different info to the compiler on how to build things. There are two by default, which is usually all that's needed: 'Debug' and 'Release' configurations. Look for the option to change this in your IDE's toolbar.

* Debug configuration - Has no optimizations to make it easier to debug problems. Run with Debug while building your program.
* Release configuration - Has optimizations turns on, allowing the compiler to make adjustments for faster code without changing functionality. Ex. Stripping out unused variables. Compile with Release when sharing your program.

---
TODO Add notes starting with below

### Level 4: Comments
#### Speedrun
* Comments let you put text in a program that the computer ignores, but that helps programmers understand or remember what the code does.
* Anything after two slashes (`//`) on a line is a comment, as is anything between `/*` and `*/`.

#### How to Make Good Comments

##### Challenge: Thing Namer 3000
```cs
using System;

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
```

**Objectives:**
* Rebuild the program above on your computer.
* Add comments near each of the four variables that describe what they store. You must use at least one of each comment type (`//` and `/* */`).
* Find the bug in the text displayed and fix it.
* **Ansew this question:** Aside from comments, what is one other thing you could do to make this code more understandable.

### Level 5: Variables
#### Speedrun
* A variable is a named location in memory for storing data.
* Variables have a type, a name, and a value (contents).
* Variables are declared (created) like this: `int number;`.
* Assigning values to variables is done with the assignment operator: `number = 3;`
* Using a variable name in an expression will copy the value out of the variable.
* Give your variables good names. You will be glad you did.

#### What is a Variable?

#### Casting and Using Variables in C#


#### Integers


#### Reading from a Variable Does Not Change It


#### Clever Variable Tricks


#### Variable Names


---

### Level 6: The C# Type System
#### Speedrun
* Types of variables and values matter in C#. They are not interchangeable.
* There are eight integer types for storing integers of differing sizes and ranges: `int`, `short`, `long`, `byte`, `sbyte`, `uint`, `ushort`, and `ulong`.
* The `char` type stores single characters.
* The `string` type stores longer text.
* There are three types for storing real numbers: `float`, `double`, and `decimal`.
* The `bool` type stores truth values (true and false) used in logic.
* These types are the building blocks of a much larger type system.
* Using `var` for a variable's type tells the compiler to infer its type from the surrounding code, so you do not have to type it out. (But it still has a specific type.)
* The `System.Convert` class is a useful class to convert from one type to another.

#### Representing Data in Binary


#### Integer Types

##### Declaring and Using Variables with Integer Types


##### The Digit Separator


##### Choosing Between the Integer Types


##### Binary and Hexadecimal Literals


#### Text: Characters and Strings


#### Floating-Point Types


##### Scientific Notion


#### The `bool` Type


##### Challenge: The Variable Shop
**Objectives:**
* Build a program with a variable of all fourteen types described in this level.
* Assign each of them a value using a literal of the correct type.
* Use `Console.WriteLine` to display the contents of each variable.

##### Challenge: The Variable Shop Returns
**Objectives:**
* Modify the *Variable Shop* program to assign a new, different literal value to each of the 14 original variables. Do not declare any additional variables.
* Use `Console.WriteLine` to display the updated contents of each variable.

#### Type Inference


#### The `Convert` Class


---

### Level 7: Math
#### Speedrun
* Addition (`+`), subtraction (`-`), multiplication (`*`), division (`/`), and remainder (`%`) can all be used to do math in expressions: `int a = 3 + 2 / 4 * 6;`
* The `+` and `-` operators can also be used to indicate a sign (or negate a value): `+3`, `-2`, or `-a`.
* The order of operations matches the math world. Multiplication and division happen before addition and subtraction, and things are evaluated left to right.
* Change the order by using parentheses to group things you want to be done first.
* Compound assignment operators (`+=`, `-=`, `*=`, `/=`, `%=`) are shortcuts that adjust a variable with a math operation. `a += 3;` is the same as `a = a + 3;`
* The increment and decrement operators add and subtract one: `a++; b--;`
* Each of the numeric types defines special values for their ranges (`int.MaxValue`, `double.MinValue`, etc.), and the floating-point types also define `PositiveInfinity`, `NegativeInfinity`, and `NaN`.
* Integer division drops remainders while floating-point division does not. Dividing by zero in either system is bad.
* You can convert between types by casting: `int x = (int)3.3;`
* The `Math` and `MathF` classes contain a collection of utility methods for dealing with common math operations such as `Abs` for absolute value, `Pow` and `Sqrt` for powers and square roots, and `Sin`, `Cos`, and `Tan` for the trigonometry functions sine, cosine, and tanget, and a definition of pi(`Math.PI`)

#### Operations and Operators


#### Addition, Subtraction, Multiplication, and Division


#### Compound Expressions and Order of Operations


##### Challenge: The Triangle Farmer
*Area = base x height / 2*
**Objectives:**
* Write a program that lets you input the triangle's base size and height.
* Compute the area of a triangle by turning the above equation into code.
* Write the result of the computation.

#### Special Number Values


#### Integer Division vs Floating-Point Division


#### Division by Zero


#### More Operators


##### Unary `+` and `-` Operators


##### The Remainder Operator


##### Challenge: The Four Sisters and the Duckbear
TODO Add relevant parts of description.
**Objectives:**
* Create a program that lets the user enter the number of chocolate eggs gathered that day.
* Using `/` and `%`, compute how many eggs each sister should get and how many are left over for the duckbear.
* **Answer this question:** What are three total egg counts where the duckbear gets more than each sister does? Use the program you created to help you find the answer.

#### Updating Variables


##### Increment and Decrement Operators


##### Challenge: The Dominion of Kings
**Objectives:**
* Create a program that allows the user to enter how many provinces, duchies, and estates they have.
* Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province.
* Display the point total to the user.

##### Prefix and Postfix Increment and Decrement Operators

#### Working with Different Types and Casting


#### Overflow and Underflow


#### The `Math` and `MathF` Classes


##### Pi and e


##### Powers and Square Roots


##### Absolute Value


##### Trigonometrics Functions


##### `Min`, `Max`, and `Clamp`


##### More


##### The `MathF` Class



### Level 8: Console 2.0
#### Speedrun
* The `Console` class can write a line without wrapping (`Write`), wait for a single keypress (`ReadKey`), change colors (`ForegroundColor`, `BackgroundColor`), clear the entire console window (`Clear`), change the window title (`Title`), and play retro 80's beep sounds (`Beep`).
* Escape sequences start with a `\` and tell the computer to intepret the following letter differently. `\n` is a new line, `\t` is a tab, `\"` is a quote within a string literal.
* An `@` before a string ignores any would-be escape sequences `@"C:\Users\Me\File.txt"`.
* A `$` before a string means curly braces contain code: `$"a:{a} sum:{a+b}"`.

#### The `Console` Class


##### The `Write` Method


##### The `ReadKey` Method


##### Changing Colors


##### The `Clear` Method


##### Changing the Window Title


##### The `Beep` Method


#### Sharpening Your Strong Skills

##### Escape Sequences


##### String Interpolation


##### Alignment


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