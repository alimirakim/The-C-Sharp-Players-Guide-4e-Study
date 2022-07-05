# Part 1: The Basics

## Level 1: The C# Programming Language
### Speedrun
* C# is a general-purpose programming language. You can make almost anything with it.
* C# runs on .NET, which is many things: a runtime that supports your program, a library of code to build upon, and a set of tools to aid in constructing programs.

### What is C#?


### What is .NET?
> **.NET** - Often called a framework or platform. The ecosystem surrounding C# programs and programmers that use it. 
> **runtime** - The environment your program runs within. Figuratively, it's the air your program breathes and the round it stands on as it runs. All languages have a runtime of some kind. 
> **Base Class Library (BCL)** - A pile of code included in .NET that can be used directly in C# programs. Examples: BCL can be used to open files or compute a square root.
> **Software Development Kit (SDK)** - A broad set of tools included in .NET to make coding easier.


## Level 2: Getting an IDE
### Speedrun
* Programming is complex; you want an IDE to make programming life easier.
* Visual Studio is the most used IDE for C# programming. Visual Studio Community is free, feature-rich, and recommended for beginners.
* Other C# IDEs exist, including Visual Studio Code and Rider.

> **Integrated Development Environment (IDE)** - An application with tools designed to streamline the programming process. 

### A Comparison of IDEs


#### Visual Studio


#### Visual Studio Code


#### Visual Studio for Mac


#### JetBrains Rider


#### Other IDEs

#### Online Editors

#### No IDE

### Installing Visual Studio


#### Challenge: Install Visual Studio
* Install Visual Studio Community edition (or any other IDE) and get it ready to start programming.

---

## Level 3: Hello World: Your First Program
### Speedrun
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

### Creating a New Project


### A Brief Tour of Visual Studio


### Compiling and Running Your Program


#### Challenge: Hello World!
**Objectives:**
* Create a new Hello World program from the C# **Console Application** template, targeting **.NET 5**.
* Run your program using any of the three methods described above.

### The Adventure Begins

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

#### `using` Directives

```cs
using System;
Console.WriteLine("Hello World!"); // Doesn't require System.Console.Blah...
```

#### Challenge: What Comes Next
**Objectives:**
* Replace the file's contents with a `using System;` and `Console.WriteLine("Hello World!");`
* Change your program to say something (anything!) besides "Hello World!"

#### Multiple Statements

```cs
using System;

Console.WriteLine("Hello World!");
Console.WriteLine("Annyeong chingoo!");
Console.WriteLine("Sup");
```

#### Challenge: The Makings of a Programmer
**Objectives:**
* Make a program with 5 `Console.WriteLine` statements in it.
* **Answer this question:** How many statements do you think a program can contain?

#### Expressions

**Snippet: Using a Value vs Expression**
```cs
// value
Console.WriteLine("Hi User");

// expression
Console.WriteLine("Hi " + "User");
```

#### Variables

**Snippet: Variable**
```cs
// declaring
string name;

// assigning
name = "User";

// using in an expression
Console.WriteLine("Hi " + name);
```

#### Reading Text from the Console

**Snippet: Console.ReadLine**
```cs
string name;
name = Console.ReadLine();
Console.WriteLine("Hi " + name);
```


#### Challenge: Consolas and Telim
**Objectives:**
* Make a program that runs as shown above, including taking a name from the user.


### Compiler Errors, Debuggers, and Configurations

#### Compiler Errors


#### Debugging

#### Build Configurations

---
TODO Add notes starting with below

## Level 4: Comments
### Speedrun
* Comments let you put text in a program that the computer ignores, but that helps programmers understand or remember what the code does.
* Anything after two slashes (`//`) on a line is a comment, as is anything between `/*` and `*/`.

**Snippet: Comments**
```cs
// This is a comment where I can describe what happens next.
Console.WriteLine("Hello World!");

Console.WriteLine("Hello again!"); // This is also a comment.

Console.WriteLine("H!"); /* This is a comment that ends here... */

/* This is a multiline comment.
   It spans multiple lines.
   Isn't it neat? */

Console.WriteLine("H! " /* Here comes the good part! */ + username); 
```

### How to Make Good Comments

**Snippet: Useless vs Useful Comments**
```cs
// Useless:
// Uses Console.WriteLine to print "Hello World!"
Console.WriteLine("Hello World!");

// Useful:
// Printing "Hello World!" is a common first program to make.
Console.WriteLine("Hello World!");
```

#### Challenge: Thing Namer 3000
**Objectives:**
* Rebuild the program above on your computer.
* Add comments near each of the four variables that describe what they store. You must use at least one of each comment type (`//` and `/* */`).
* Find the bug in the text displayed and fix it.
* **Answer this question:** Aside from comments, what is one other thing you could do to make this code more understandable.

## Level 5: Variables
### Speedrun
* A variable is a named location in memory for storing data.
* Variables have a type, a name, and a value (contents).
* Variables are declared (created) like this: `int number;`.
* Assigning values to variables is done with the assignment operator: `number = 3;`
* Using a variable name in an expression will copy the value out of the variable.
* Give your variables good names. You will be glad you did.

### What is a Variable?
> **volatile memory (RAM)** - Memory that sticks around while a program runs but is wiped out when the program closes or the computer is rebooted.
> **persistent storage** - Data that survives longer than the program, like in a file or database.
> **memory address** - A numeric memory location which can be used to view that specific location's contents.
> **variable** - Named location where data is stored in memory. Has three parts: name, type, and contents/data.
> **declaration** - Allows the computer to reserve a spot in memory of the appropriate size for it. A variable can only be declared once.
> **assignment** - Stores values or contents in a variable. A variable can be reassigned multiple times.
> **initializing** - The first time a value is a assigned to a variable.
> **integer** - A whole number (not a fraction or decimal) that can be positive, negative, or zero.
> **literal value** or **literal** - A fixed, known value that is outright stated in the code. ex. string literal = `"0"`, int literal = `0`

### Creating and Using Variables in C#
**Snippet: Creating a variable**
```cs
string username;                        // Declaring a variable
username = Console.ReadLine();          // Assigning a value to a variable
Console.WriteLine("Hi " + username);    // Retrieving its current value

username = Console.Readline();          // Reassign same variable with new value
Console.WriteLine("Hi " + username);    // Retrieving its new value

string favoriteColor;
favoriteColor = Console.ReadLine();
Console.WriteLine(favoriteColor + " is a pretty color, " + username + "!");

```

### Integers
**Snippet: Integer variable**
```cs
int score;

score = "Generic User"; // DOESN'T COMPILE!!
score = "0"; // ODESN'T COMPILE!!

score = 0; // Works!
score = 4;
score = 11;
score = -1564;
```

### Reading from a Variable Does Not Change It

```cs
int a; // Declared
int b; // Declared

a = 5; // Initialized
b = 2; // Initialized

b = a; // Content of a is copied into b
a = -3; // a is updated to -3 while b retains its 5

Console.WriteLine(a) // -3
Console.WriteLine(b) // 5
```

### Clever Variable Tricks

```cs
int x = 0; // Declare and initialize a variable on the same line.

int a, b, c; // Declare multiple variables of the same type on the same line.

// Variable assignments are expression that evaluate to whatever the assigned value was.
a = b = c = 10; // Assign the same value to many variables at once. Uncommon.

// ...is equivalent to:
c = 10; // 1. 10 is assigned to c
b = c; // 2. c = 10 is an expression that evalutes to 10, which is assigned to b
a = b; // 3. a is assigned the evaluation of b = 10
```

### Variable Names

```cs
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


```cs
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

## Level 6: The C# Type System
### Speedrun
* Types of variables and values matter in C#. They are not interchangeable.
* There are eight integer types for storing integers of differing sizes and ranges: `int`, `short`, `long`, `byte`, `sbyte`, `uint`, `ushort`, and `ulong`.
* The `char` type stores single characters.
* The `string` type stores longer text.
* There are three types for storing real numbers: `float`, `double`, and `decimal`.
* The `bool` type stores truth values (true and false) used in logic.
* These types are the building blocks of a much larger type system.
* Using `var` for a variable's type tells the compiler to infer its type from the surrounding code, so you do not have to type it out. (But it still has a specific type.)
* The `System.Convert` class is a useful class to convert from one type to another.

### Representing Data in Binary
> **built-in type** or **primitive type** - Building blocks for more complex types.
> **bit** - A single 1 or 0.
> **byte** - A group of 8 bits. The standard grouping size of bits.

### Integer Types
> **integer types** or **integral type** - The eight types that represent integers: `byte`, `short`, `int`, `long`, `sbyte`, `ushort`, `uint`, `ulong`.
> **signed type** - Integer types that can store positive or negative values. Includes: `short`, `int`, `long`.
> **unsigned type** - Integer types that can only store positive values. Includes: `ushort`, `uint`, `ulong`.

#### Declaring and Using Variables with Integer Types

```cs
byte aSingleByte = 34;
aSingleByte = 17;

short aNumber = 5039;
aNumber = -4354;

long aVeryBigNumber =395904282569;
aVeryBigNumber = 13;
```

```cs
byte aNumber = 32;

long aVeryBigNumber = 10000000000 // 10 billion would be a `long` literal.

ulong aVeryBigNumber = 10000000000U;
aVeryBigNumber = 10000000000L;
aVeryBigNumber = 10000000000UL;

aVeryBigNumber = 10000000000lu;
```

#### The Digit Separator

```cs
int aBigNumber = 1_000_000_000;

int a = 123_456_789;
int b = 12_34_56_78_9;
int c = 1_2__3___4____5;
```

#### Choosing Between the Integer Types


#### Binary and Hexadecimal Literals

```cs
// binary literal
int thirteen = 0b00001101;

// hexadecimal literal
int theColorMagenta = 0xFF00FF;
```


### Text: Characters and Strings

```cs
char aLetter = 'a';
char baseball = '⚾';

char aLetter = '\u0061'; // An 'a'

string message = "Hello World!";
```


### Floating-Point Types

```cs
double number1 = 3.5623;
float number2 = 3.5623f; // or F
decimal number3 = 3.5623m; // or M. Stands for "monetary" or "money"
```


#### Scientific Notion
```cs
double avogadrosNumber = 6.022e23; // stands for 6.022x10(23) or 602,200,000,000,000,000,000,000
```

### The `bool` Type

```cs
bool itWorked = true;
itWorked = false;
```

#### Challenge: The Variable Shop
**Objectives:**
* Build a program with a variable of all fourteen types described in this level.
* Assign each of them a value using a literal of the correct type.
* Use `Console.WriteLine` to display the contents of each variable.

#### Challenge: The Variable Shop Returns
**Objectives:**
* Modify the *Variable Shop* program to assign a new, different literal value to each of the 14 original variables. Do not declare any additional variables.
* Use `Console.WriteLine` to display the updated contents of each variable.

### Type Inference

```cs
var message = "Hello World!";

var x; // DOES NOT COMPILE!
```

```cs
var input = Console.ReadLine();
```

```cs
var something = "Hello";
something = 3; // Error! Cannot store an int in a string-typed variable.
```

### The `Convert` Class

```cs
Console.Write("What is your favorite number?");
string favoriteNumberText = Console.ReadLine();
int favoriteNumber = Convert.ToInt32(favoriteNumberText);
Console.Write(favoriteNumber + " is a great number!");

Convert.ToByte(); // byte
Convert.ToInt16(); // short
Convert.ToInt32(); // int
Convert.ToInt64(); // long
Convert.ToSByte(); // sbyte
Convert.ToUInt16(); // ushort
Convert.ToUInt32(); // uint
Convert.ToUInt64(); // ulong
Convert.ToSingle(); // float
Convert.ToDouble(); // double
Convert.ToDecimal(); // decimal
Convert.ToChar(); // char
Convert.ToString(); // string
Convert.ToBoolean(); // bool
```

### C# Types Cheatsheet



---

## Level 7: Math
### Speedrun
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

### Operations and Operators
> **operation** - A calculation that takes (usually) two numbers and produces a single result by combining them somehow. ex. `2 + 3`
> **operator** - A symbole that indicates how numbers in an operation are combined. ex. `+`
> **operand** - The values used in an operation. ex. `2` and `3` in operation `2 + 3`
> **binary operator** - Operators that need two operands. 'Binary' means 'composed of two things'. C# has many.
> **unary operator** - Operators that need one operand. C# has a few.
> **ternary operator** - Operators that need three operands. C# has one.

### Addition, Subtraction, Multiplication, and Division
> **algorithm** - A process to compute some meaningful result through a series of steps.
> **addition operator `+`** Binary math operator; ex. `a + 2`
> **subtraction operator `-`** Binary math operator; ex. `a - 2`
> **multiplication operator `*`** Binary math operator; ex. `a * 2`
> **division operator `/`** Binary math operator; ex. `a / 2`

**Sample: Operations for initialization**
```cs
int a = 2 + 3;
int b = 5 - 2;
```

**Sample: Operations for assignment and reassignment**
```cs
int a;          // Declaring the variable a.
a = 9 - 2;      // Assigning a value to a, using some math.
a = 3 + 3;      // Another assignment.

int b = 3 + 1;  // Declaring b and assigning a value to b all at once.
b = 1 + 2;      // Assigning a second value to b.
```

**Sample: Operations with variables**
```cs
int a = 1;
int b = a + 4;
int c = a - b;
```

**Sample: Multiplication operator**
```cs
float totalPies = 4;
float slicesPerPie = 8;
float totalSlices = totalPies * slicesPerPie;
```

**Sample: Division operator**
```cs
double moneyMadeFromGame = 100000;
double totalProgrammers = 4;
double moneyPerPerson = moneyMadeFromGame / totalProgrammers; // We're rich!
```

### Compound Expressions and Order of Operations
> **order of operations** - A set of rules that governs what operators are evaluated first. C# uses the mathematical order of operations (PEMDAS).
> **operator precedence** - Determines which operation types come before others. ex. Multiplication before addition.
> **operator associativity** - Determines whether two operators of the same precedence should be evaluated from left to right or right to left.

See more: https://csharpplayersguide.com/articles/operators-table

**Sample: Two operations in one expression**
```cs
int result = 2 + 5 * 2;
```

**Sample: Overriding order of operations with separate statements**
```cs
int partialResult = 2 + 5;
int result = partialResult * 2;
```

**Sample: Overriding order of operations with parenthesese**
```cs
int result = (2 + 5) * 2;
```

**Sample: Grouping with nested parenthesese**
```cs
int result = ((2 + 1) * 8 - (3 - 2) * 2) / 4;
```

**Sample: Computing area of a trapezoid**
```cs
// Some simple code for the area of a trapezoid

double side1 = 4.5;
double side2 = 3.5;
double height = 1.5;

double areaOfTrapezoid = (side1 + side2) / 2.0 * height;
```

#### Challenge: The Triangle Farmer
*Area = base x height / 2*
**Objectives:**
* Write a program that lets you input the triangle's base size and height.
* Compute the area of a triangle by turning the above equation into code.
* Write the result of the computation.

### Special Number Values

**Sample: Properties of numeric types**
```cs
// All 11 numeric types have MaxValue and MinValue properties
int aBigNumber = int.MaxValue;
short aBigNegativeNumber = short.MinValue;
```

**Sample: PositiveInfinity and NegativeInfinity**
```cs
// double and float types only
double infinity = double.PositiveInfinity;
float negativeInfinity = float.NegativeInfinity;
```

**Sample: NaN**
```cs
// double and float types only
double notAnyRealNumber = double.NaN;
float notARealNumber = float.NaN;
```

### Integer Division vs Floating-Point Division
> **integer division** - When dividing integer type numbers, fractional bits of the result are dropped. ex. 5 / 2 = 2.
> **floating-point division** - When dividing with floating-point type numbers, fractional bits of the result are retained. ex. 5 / 2 = 2.5.

**Sample: Integer division**
```cs
int a = 5;
int b = 2;
int result = a / b;
Console.WriteLine(result); // 2
```

### Division by Zero


### More Operators

#### Unary `+` and `-` Operators
> **Positive operator `+<operand>`** - Unary operator; has no functional effect. Can add visual clarity when used in contrast with negative operator. ex. `+(a + 2)` vs `-(a + 2)`
> **Negative operator `-<operand>`** - Unary operator; reverses the operand value's sign. Equivalent of multiplying operand by `-1`. ex. If `int a = -3; int b = -a;`, `b` is `3`.

**Sample: Unary + and - Operators**
```cs
int a = 3;
int b = -a; // -3
int c = +a; // 3

int d = -5;
int e = -d; // 5
int f = +d; // -5
```

**Sample: Using unary + for clarity vs unary -**
```cs
int a = 3;
int b = -(a + 2) / 4;
int c = +(a + 2) / 4;
```

#### The Remainder Operator
> **remainder** - The leftover amount when dividing a number against another. ex. Remainder of `23 / 3` is `2`.
> **remainder operator `%`** - Binary operator; computes remainder of divided result. Sometimes called the *modulus operator* or *mod operator*, but these terms mean slightly different things for negative numbers. ex. `int leftOverApples = 23 % 3;` results in `2`.

**Sample: Remainder Operator**
```cs
int leftOverApples = 23 % 3; // 2
```

**Sample: Using remainder operator to check if a number is a multiple of another**
```cs
int remainder = n % 2; // If this is 0, then 'n' is an even number.
```

#### Challenge: The Four Sisters and the Duckbear
**Objectives:**
* Create a program that lets the user enter the number of chocolate eggs gathered that day.
* Using `/` and `%`, compute how many eggs each sister should get and how many are left over for the duckbear.
* **Answer this question:** What are three total egg counts where the duckbear gets more than each sister does? Use the program you created to help you find the answer.

### Updating Variables
> **assignment operator `=`** Binary operator; indicates that some expression on its right side should be evaluated and stored in the variable on the left. ex. `string name = 'Luna';`
> **compound assignment operator** Binary operator; Category of operators that do some operation and a variable assignment simultaneously. ex. `+=`, `-=`, `*=`, `/=`, `%=`, `&=`, `|=`, `^=`, `>>=`, `<<=`, `=>`

**Sample: Using a variable's current value in an expression to determine its new value**
```cs
int a = 5;
a = a + 1; // the variable a will have a value of 6 after running this line.

a += 1; // equivalent to previous operation by using compound assignment operator +=
```

**Sample: Compound assignment operators**
```cs
int a = 0;
a += 5; // The equivalent of a = a + 5; (a is 5 after this line runs.)
a -= 2; // The equivalent of a = a - 2; (a is 3 after this line runs.)
a *= 4; // The equivalent of a = a * 4; (a is 12 after this line runs.)
a /= 2; // The equivalent of a = a / 2; (a is 6 after this line runs.)
a %= 2; // The equivalent of a = a % 2; (a is 0 after this line runs.)
```


#### Increment and Decrement Operators
> **increment** Adding one to a value. Derived from the word 'increase'.
> **decrement** Subtracting one from a value. Derived from the word 'decrease'.
> **increment operator `++`** Unary operator; increments operand's value. Requires a variable operand. ex. `a++;`
> **decrement operator `--`** Unary operator; decrements operand's value. Requires a variable operand. ex. `a--;`

**Sample: Increment and decrement operators**
```cs
int a = 0;
a++; // The equivalent of a += 1; or a = a + 1;
a--; // The equivalent of a -= 1; or a = a - 1;
```

#### Challenge: The Dominion of Kings
**Objectives:**
* Create a program that allows the user to enter how many provinces, duchies, and estates they have.
* Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province.
* Display the point total to the user.

#### Prefix and Postfix Increment and Decrement Operators
> **postfix notation** When an operator is written after the variable it modifies and evaluates to the variable's *original* value. ex. If `int x = 5;` and `int z = x++;`, z is 5.
> **prefix notation** When an operator is written before the variable it modifies and evaluates to the variable's *updated* value. ex. If `int x = 5;` and `int z = ++x;`, z is 6.

**Sample: Postfix vs prefix notation**
```cs
int x;

x = 5;
int y = ++x; // y = 6 and x = 6

x = 5;
int z = x++; // z = 5 and x = 6
```

### Working with Different Types and Casting
> **narrowing conversion** A category of onversion that risks losing data in the conversion process. ex. Converting `long` to `byte` can lose data if the number is larger than what `byte` can accurately represent.
> **widening conversion** A category of conversion that doesn't risk losing data from the conversion. ex. Converting `byte` to `long` risks no loss since a `long` can represent everything a `byte` can.
> **explicit conversion** A conversion that the programmer must specifically ask to happen. Narrowing conversions are always explicit. ex. floating-point types to integer integer types.
> **implicit conversion** A conversion that occurs automatically without the programmer stating it. Widening conversions are always implicit. ex. `sbyte` to `short`, `short` to `int`, `int` to `long`, etc.
> **casting operator `(<type>)`** A type of operator used to explicitly ask for a conversion. Does not exist for all type conversions. Has higher precedence than operators reviewed before this like math operators. ex. `byte aByte = byte(anInt)` works but `int number = (int)aStringZero;` doesn't.

**Sample: An implicit widening conversion**
```cs
byt aByte = 3;
int anInt = aByte;
```

**Sample: An explicit narrowing conversion with a casting operator**
```cs
int anInt = 3;
byte aByte = (byte)anInt;
```
**Sample: Invalid casting conversion**
```cs
string text = "0";
// int number = (int)text; // DOES NOT WORK! 

int number = Convert.ToInt(text); // string-to-int requires Convert class
```

**Sample: Implicit conversions to solve issues with 1. intermixing types and 2. math operations for 'small' types**
```cs
short a = 2;
short b = 3;
int total = a + b; // a and b are converted to ints automatically since addition isn't defined for short.
```

**Sample: Casting implicitly-converted result back to original values' type**
```cs
short a = 2;
short b = 3;
short total = (short)(a + b);
```

**Sample: Casting to solve for integer divisions not being able to handle fractional results**
```cs
int amountDone = 20;
int amountToDo = 100;
// Problem: Divided ints ignore fractional values, rounding 0.2 to 0. 
// The variable's double type then converts 0 to 0.0.
double fractionDoneBad = amountDone / amountToDo; // 0.0

// Solution: Casting operator has highest precedence and converts amountDone to 20.0. 
// Division between int and double is not defined, so amountToDo is implicitly converted to double for the floating-point division 20.0 / 100.0 resulting in 0.2.
double fractionDone = (double)amountDone / amountToDo; // 0.2
```

### Overflow and Underflow
> **overflow** When an operation causes a value to go beyond what its type can represent. ex. `byte a = 255; byte b = (byte)(a + 100);` results in `99`
> **underflow**

**Sample: Overflow with integer types**
```cs
short a = 3000;
short b = 3000;
// Too big to fit into short. What happens? For integer types, wraps around back to the start of the range.
short sum = (short)(a + b); // -5536 
```

**Sample: Overflow with floating-point types**
```cs
float a = 100_000_000;
float b = 100_000_000;

// Too big to fit into float. What happens? For floating-point types, switches to the type's positive or negative infinity representation.
float product = a * b; // PositiveInfinity
float productNegative = -(a * b); // NegativeInfinity
```

**Sample: Underflow**
```cs
float a = 10_000;
float b = 0.00001f;

// floats have 6-7 digits of precision, so it cannot distinguish 10000 from 10000.00001
float sum = a + b; // 10000
```

### The `Math` and `MathF` Classes
> **`Math` and `MathF` classes** Part of .NET's C# Base Class Library (BCL). `System` members. Static classes that helps do common math operations. `Math` uses `double` whilt `MathF` uses `float`.

#### Pi and e

**Sample: Math.E and Math.PI**
```cs
double areaCircle = Math.PI * radius * radius; // ?? TODO

float eulersNumber = MathF.E; // ?? TODO
```

#### Powers and Square Roots
**Sample: Math.Pow and Math.Sqrt**
```cs
double x = 3.0;
double xSquared = Math.Pow(x, 2); // 6.0

double y = Math.Sqrt(xSquared); // 3.0
```

#### Absolute Value
**Sample: Math.Abs**
```cs
int x = Math.abs(-2); // 2
```

#### Trigonometrics Functions
**Sample: Sin, Cos, Tan**
```cs
// Expects angles in radians, not degrees
double y1 = Math.Sin(0); // ?? TODO
double y2 = Math.Cos(0); // ?? TODO
double y3 = Math.Tan(0); // ?? TODO
```

#### `Min`, `Max`, and `Clamp`
**Sample: Math.Min and Math.Max**
```cs
int smaller = Math.Min(2, 10); // 2
int larger = Math.Max(2, 10); // 10
```

**Sample: Math.Clamp**
```cs
double health = 100;
health += 10;
health = Math.Clamp(health, 0, 100); // Keep it in the interval 0 to 100.
```

#### More


#### The `MathF` Class

**Sample: MathF**
```cs
float x = 3;
float xSquared = MathF.Pow(x, 2);
```


