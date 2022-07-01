# Part 1: The Basics
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

## Level 1: The C# Programming Language
### Speedrun
* C# is a general-purpose programming language. You can make almost anything with it.
* C# runs on .NET, which is many things: a runtime that supports your program, a library of code to build upon, and a set of tools to aid in constructing programs.

---

## Level 2: Getting an IDE
### Speedrun
* Programming is complex; you want an IDE to make programming life easier.
* Visual Studio is the most used IDE for C# programming. Visual Studio Community is free, feature-rich, and recommended for beginners.
* Other C# IDEs exist, including Visual Studio Code and Rider.

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

---

## Level 4: Comments
### Speedrun
* Comments let you put text in a program that the computer ignores, but that helps programmers understand or remember what the code does.
* Anything after two slashes (`//`) on a line is a comment, as is anything between `/*` and `*/`.

## Level 5: Variables
### Speedrun
* A variable is a named location in memory for storing data.
* Variables have a type, a name, and a value (contents).
* Variables are declared (created) like this: `int number;`.
* Assigning values to variables is done with the assignment operator: `number = 3;`
* Using a variable name in an expression will copy the value out of the variable.
* Give your variables good names. You will be glad you did.

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

---

### Level 8: Console 2.0
#### Speedrun
* The `Console` class can write a line without wrapping (`Write`), wait for a single keypress (`ReadKey`), change colors (`ForegroundColor`, `BackgroundColor`), clear the entire console window (`Clear`), change the window title (`Title`), and play retro 80's beep sounds (`Beep`).
* Escape sequences start with a `\` and tell the computer to intepret the following letter differently. `\n` is a new line, `\t` is a tab, `\"` is a quote within a string literal.
* An `@` before a string ignores any would-be escape sequences `@"C:\Users\Me\File.txt"`.
* A `$` before a string means curly braces contain code: `$"a:{a} sum:{a+b}"`.

---

### Level 9: Decision Making
#### Speedrun
* An `if` statement lets some code run (or not) based on a condition. `if (condition) DoSomething;`
* An `else` statement identifies code to run otherwise.
* Combine `if` and `else` statements to pick from one of several branches of code.
* A block statement lets you put many statements into a single bundle. An `if` statement can work around a block statement: `if (condition) { DoSomething; DoSomethingElse; }`
* Relational operators let you check the relationship between two elements: `==`, `+=`, `<`, `>`, `<=`, and `>=`.
* The `!` operator inverts ia `bool` expression.
* Combine multiple `bool` expressions with the `&&` ("and") and `||` ("or") operators.

---

### Level 10:  Switches
#### Speedrun
* Switches are an alternative to `if` statements with lots of parts.
* The statement form: `switch (number) { case 0: DoStuff(); break;  case 1: DoStuff(); break; default: DoStuff(); break; }`
* The expression form: `number switch { 0 => "zero", 1 => "one", _ => "other" }`

---

### Level 11:  Looping
#### Speedrun
* Loops repeat code.
* `while` loop: `while (condition) { ... }`
* `do`/`while` loop: `do { ... }  while (condition);`
* `for` loop: `for (initialization, condition, update) { ... }`
* `break` exits the loop. `continue` immediately jumps to the next iteration of the loop.

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

---

### Level 13:  Methods
#### Speedrun
* Methods let you name and reuse a chunk of code: `void CountToTen() { ... }`
* Parameters allow a method to work with different data each time it is called: `void CountTo(int amount) { ... }`
* Methods can produce a result with a return value: `int GetNumber() { return 2; }`
* Two methods can have the same name (an overload) if their parameters are different.
* Some simple methods can be defined with an expression body: `int GetNumber() => 2;`
* Recursion is when a method calls itself.

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
