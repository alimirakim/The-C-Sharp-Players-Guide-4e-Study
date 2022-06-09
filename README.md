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
01. [x] The C# Programming Language
02. [x] Getting an IDE
03. [x] Hello World: Your First Program
04. [x] Comments
05. [] Variables
06. [] The C# Type System
07. []  Math
08. [] Console 2.0
09. [] Decision Making
10. [] Switches
11. [] Looping
12. [] Arrays
13. [] Methods
14. []Memory Management


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

> * **source code** - Instructions written in a programming language for the computer to run.
> * **configuration** - Instructions given to the computer to help it know how to compile or translate code into binary instructions the computer can run.
> * **template** - Standard starting points that help get the configuration right for specific project types and provide starting code.
> * **compiling** - The transformation of code into binary instructions the computer can run by a special program called a *compiler*.
> * **compiler** - A special program that takes a project's code and configuration and produces binary instructions that the computer can run directly (simplified explanation). Creates a resulting `.exe` or `.dll` file for the computer to run.
> * **syntax** - A set of rules that describe how to make a working program in that language.
> * **entry point** or **main method** - The starting point where a C# program begins running.
> * **identifiers** or (casually) **names** - Used to name new things you create and to refer to previously created things. Ex. `System`, `Console`, `WriteLine`.
> * **members** - Things contained in another thing.
> * **member access operator** or **dot operator** - A period symbol `.` used to access members of another thing. Ex. `System.Console.WriteLine` accesses the `WriteLine` member of `Console`, which is a member of `System`.
> * **namespace** - Something that contains other things under a shared name and is primarily an organizational tool, similar to a directory or folder. Ex. `System`
> * **class** - A single entity that focuses on solving one problem well. A class combines 1. the data it needs to track over time and 2. the abilities or services it provides to other parts of the program. Ex. The `Console` class is focused on the console window. It contains data about the console window's current state and a list of abilities or tasks involving interacting with or manipulating the console window.
> * **method** - Code that will run when something asks for the task to be performed. Ex. The `WriteLine` method runs when `Console` invokes it.
> * **method invocation** or **calling a method** - Telling a method to run its code. Parentheses `( )` are used to call a method. Ex. `Console.WriteLine("Hello World!")`
> * **statement** - A single command to perform. Most statements in C# end in a semicolon `;`.
> * **fully qualified name** - The unabbreviated name of a class without `using` directives. Ex. `System.Console` vs the *simple name* `Console`.
> * **keyword** - A special word that the language and compiler understand the meaning of. C# has over 100 keywords. Ex. `using`
> * **expression** - Bits of code that a program must process or *evaluate* to determine the result. Expressions define how to produce a value from smaller elements. Used by the computer to compute the expression's resulting value as it runs. Ex. `"Hi " + "User"`
> * **variables** - Containers for data. They're called 'variables' because their contents can change or vary as the program runs.
> * **declaring a variable** - Creating a variable by providing a name and its type. Ex. `string name;`
> * **assignment** - Placing values in a variable to use later. `name = "User";`
> * **return a value** - When a method produces a value.
> * **debugging** - Trying to figure out why a program doesn't do what you expected and adjusting it accordingly.

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

Uses:
* Describe how a tricky piece of code works.
* Leave TODO reminders of things that still need to be done.
* Document how a specific thing works or should be used.
* Temporarily remove code from compiler's view.

**Snippet: Comments**
```csharp
// This is a comment where I can describe what happens next.
Console.WriteLine("Hello World!");

Console.WriteLine("Hello again!"); // This is also a comment.

Console.WriteLine("H!"); /* This is a comment that ends here... */

/* This is a multiline comment.
   It spans multiple lines.
   Isn't it neat? */

Console.WriteLine("H! " /* Here comes the good part! */ + username); 
```

#### How to Make Good Comments
Tips for making meaningful comments:
* Don't let TODO and reminder comments last long, or they only clutter the code.
* Don't say things that can be quickly gleaned from the code itself.
* Useful comments may explain *way* something was done which isn't apparent from just looking at the code.
* Write comments roughly at the same time you write the code. 
* Find the balance in how much you comment, not too few or too many. If you can't make sense of your code after a couple weeks away, you should comment more. If you keep finding comments getting out of date, you may be commenting too much or not putting the right information in comments.

Don't use comments to excuse hard-to-read code. Make the code as easy to understand as possible, and then add just enough comments to fill in the missing details.

**Snippet: Useless vs Useful Comments**
```csharp
// Useless:
// Uses Console.WriteLine to print "Hello World!"
Console.WriteLine("Hello World!");

// Useful:
// Printing "Hello World!" is a common first program to make.
Console.WriteLine("Hello World!");
```

##### Challenge: Thing Namer 3000
**Sample Program:**
```csharp
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
* **Answer this question:** Aside from comments, what is one other thing you could do to make this code more understandable.

### Level 5: Variables
#### Speedrun
* A variable is a named location in memory for storing data.
* Variables have a type, a name, and a value (contents).
* Variables are declared (created) like this: `int number;`.
* Assigning values to variables is done with the assignment operator: `number = 3;`
* Using a variable name in an expression will copy the value out of the variable.
* Give your variables good names. You will be glad you did.

#### What is a Variable?
Variables are stored in "volatile" memory (or RAM), only lasting while the program runs. For data that must survive longer than the program, it must be stored in *persistent storage in a file*. A variable has three parts: name, type, contents/data.

A variable's type is important to:
* know how many bytes to reserve for it in memory.
* enable the compiler to check we're using its contents correctly.

How to use a variable:
1. Declare it with a name and type. ex. `var string greeting;`
2. Initialize it with a value. ex. `greeting = "Hello World!";`
3. Assign different values to the same variable as needed. ex. `greeting = "Annyeong!";`
4. Retrieves its value through its name. ex. `Console.WriteLine(greeting);`

> **volatile memory (RAM)** - Memory that sticks around while a program runs but is wiped out when the program closes or the computer is rebooted.
> **persistent storage** - Data that survives longer than the program, like in a file or database.
> **memory address** - A numeric memory location which can be used to view that specific location's contents.
> **variable** - Named location where data is stored in memory. Has three parts: name, type, and contents/data.
> **declaration** - Allows the computer to reserve a spot in memory of the appropriate size for it. A variable can only be declared once.
> **assignment** - Stores values or contents in a variable. A variable can be reassigned multiple times.
> **initializing** - The first time a value is a assigned to a variable.
> **integer** - A whole number (not a fraction or decimal) that can be positive, negative, or zero.
> **literal value** or **literal** - A fixed, known value that is outright stated in the code. ex. string literal = `"0"`, int literal = `0`
> **

| Code | Category | Description | Examples |
|---|---|---|
| `string` | type | text | `string greeting = "Hello";` |
| `int` | type | integer | `int score = 0;` |



#### Creating and Using Variables in C#
Though variables can be declared anywhere in the code, since variables must be declared before being used, it's common for programmers to put most/all variable declarations at the top of their code.

**Snippet: Creating a variable**
```csharp
string username;                        // Declaring a variable
username = Console.ReadLine();          // Assigning a value to a variable
Console.WriteLine("Hi " + username);    // Retrieving its current value

username = Console.Readline();          // Reassign same variable with new value
Console.WriteLine("Hi " + username);    // Retrieving its new value

string favoriteColor;
favoriteColor = Console.ReadLine();
Console.WriteLine(favoriteColor + " is a pretty color, " + username + "!");

```

#### Integers
The `int` type represents an *integer*.

**Snippet: Integer variable**
```csharp
int score;

score = "Generic User"; // DOESN'T COMPILE!!
score = "0"; // ODESN'T COMPILE!!

score = 0; // Works!
score = 4;
score = 11;
score = -1564;
```

#### Reading from a Variable Does Not Change It

```csharp
int a; // Declared
int b; // Declared

a = 5; // Initialized
b = 2; // Initialized

b = a; // Content of a is copied into b
a = -3; // a is updated to -3 while b retains its 5

Console.WriteLine(a) // -3
Console.WriteLine(b) // 5
```

#### Clever Variable Tricks

```csharp
int x = 0; // Declare and initialize a variable on the same line.

int a, b, c; // Declare multiple variables of the same type on the same line.

// Variable assignments are expression that evaluate to whatever the assigned value was.
a = b = c = 10; // Assign the same value to many variables at once. Uncommon.

// ...is equivalent to:
c = 10; // 1. 10 is assigned to c
b = c; // 2. c = 10 is an expression that evalutes to 10, which is assigned to b
a = b; // 3. a is assigned the evaluation of b = 10
```

#### Variable Names
C# name rules:
1. Must start with a letter (almost any linguistic alphabet) or `_` underscore. ex. `taco`, `_taco`
2. Numeric digits (`0` through `9`) are allowed after the start.
3. Most symbols and whitespace are banned. The compiler reserves these to understand when variables start and end.
5. Cannot be a keyword.

```csharp
// good
string taco;
string _taco;
string taco1;

// bad
string 1taco; // cannot start with numbers
string taco-poptart; // cannot use symbols
string taco poptart; // cannot use whitespace
string string; // cannot use keyword
```

Recommended guidelines:
1. Accurately describe what the variable holds.
2. Don't abbreviate or remove letters, except for common acronyms like 'dvd'.
3. Don't fret over long names.
4. Names ending in numbers are a sign of poor names. They aren't unique enough, and sets that go together should be packaged that way.
5. Avoid generic catch-all names.
6. Make the boundaries between multi-word names clear. Most C# programmers use `lowerCamelCase` for variables and `UpperCamelCase` for other things.


```csharp
// good
int score;
int playerScore;

// bad
// not descriptive enough
int number; 
int x;

// unhelpful abbreviation
int plrscr;
int ps;

// numbers don't distinguish each other meaningfully
int score1;
int score2;
int score3;

// too generic
string item;
int data;
string text;
```

---