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


### Level 2: Getting an IDE
Comparing IDE options:
* Visual Studio
* Visual Studio Code - https://csharpplayersguide.com/articles/visual-studio-code
* Visual Studio for Mac
* JetBrains Rider
* Other IDEs
* Online Editors
* No IDE

#### Installing Visual Studio
TODO Add instructions here.

#### Bonus! Visual Studio Code
> Run > Add Configuration... > .NET 5+ and .NET Core
`dotnet new console`

`dotnet run`

---

### Level 3: Hello World: Your First Program
#### Speedrun
TBA

#### Creating a New Project
A C# project is a combination of:
1. C# Source Code (`.cs`) - Instructions we write in C# for the computer to run.
2. Configuration (`.csproj`) - Instructions we give to the computer to help it know how to compile or translate C# code into binary instructions the computer can run.

Most C# programs start with a *template*. Templates help get the configuration right for specific project types.

TODO Add more notes here.

#### A Brief Tour of Visual Studio


#### Compiling and Running Your Program

##### Challenge: Hello World!
**Objectives:**
* a
* b

#### The Adventure Begins


###### Traditional *entry point* aka *main method*
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

###### New *entry point* aka *main method*
```cs
System.Console.WriteLine("Hello World!");
```

##### `using` Directives


```cs
using System;
Console.WriteLine("Hello World!"); // Doesn't require System.Console.Blah...
```

##### Challenge: What Comes Next
**Objectives:**
* a
* b

##### Multiple Statements

```cs
using System;

Console.WriteLine("Hello World!");
Console.WriteLine("Annyeong chingoo!");
Console.WriteLine("Fuck refactors");
```

##### Challenge: The Makings of a Programmer
**Objectives:**
* a
* b

##### Expressions


##### Variables


##### Reading Text from the Console

##### Challenge: Consolas and Telim
**Objectives:**
* a


#### Compiler Errors, Debuggers, and Configurations

##### Compiler Errors


##### Debuggings


##### Build Configurations



---

### Level 4: Comments

### Level 5: Variables

### Level 6: The C# Type System

### Level 7: Math

### Level 8: Console 2.0

### Level 9: Decision Making

### Level 10:  Switches

### Level 11:  Looping

### Level 12:  Arrays

### Level 13:  Methods

### Level 14:  Memory Management