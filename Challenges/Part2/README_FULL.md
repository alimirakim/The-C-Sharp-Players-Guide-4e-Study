# Part 2: Object-Oriented Programming
Part 2 looks at the following:
* What object-oriented programming is about.
* The ways C# lets you create custom types: enumerations, tuples, classes, interfaces, structs, records, and generics.
* Key points of OOP: information hiding, properties, static members, null references, inheritance, and polymorphism.
* Practice designing and building object-oriented programs.
* Common types from .NET's Base Class Library (BCL) including: `Random`, `DateTime`, `TimeSpan`, lists, and dictionaries.

- [Part 2: Object-Oriented Programming](#part-2-object-oriented-programming)
  - [Level 15: Object-Oriented Concepts](#level-15-object-oriented-concepts)
      - [Knowledge Check: Objects](#knowledge-check-objects)
  - [Level 16: Enumerations](#level-16-enumerations)
    - [Speedrun](#speedrun)
        - [Snippet: Attempt without Enums - Representing Seasons](#snippet-attempt-without-enums---representing-seasons)
    - [Enumeration Basics](#enumeration-basics)
      - [Defining an Enumeration](#defining-an-enumeration)
        - [Snippet: Where to Define New Types Including Enums](#snippet-where-to-define-new-types-including-enums)
        - [Snippet: Defining an Enum (Compact Style)](#snippet-defining-an-enum-compact-style)
        - [Snippet: Defining an Enum (Expanded Style)](#snippet-defining-an-enum-expanded-style)
      - [Using an Enumeration](#using-an-enumeration)
        - [Snippet: Declaring Variables with Enum Type](#snippet-declaring-variables-with-enum-type)
        - [Snippet: Using Enum Members as Values](#snippet-using-enum-members-as-values)
        - [Snippet: Using Comparison Operators with Enum Variables](#snippet-using-comparison-operators-with-enum-variables)
      - [Revisiting `ConsoleColor`](#revisiting-consolecolor)
        - [Snippet: Example of a Built-In Enumeration, `ConsoleColor`](#snippet-example-of-a-built-in-enumeration-consolecolor)
      - [Challenge: Simula's Test](#challenge-simulas-test)
    - [Underlying Types](#underlying-types)
        - [Snippet: Changing an Enum's Underlying Type](#snippet-changing-an-enums-underlying-type)
        - [Snippet: Override an Enum's Default `int` Values](#snippet-override-an-enums-default-int-values)
        - [Snippet: Casting Between `int`s and Enums](#snippet-casting-between-ints-and-enums)
        - [My Snippet: Enum with a Blank Default Value](#my-snippet-enum-with-a-blank-default-value)
        - [Snippet: Casting an Enum with an Invalid `int`](#snippet-casting-an-enum-with-an-invalid-int)
  - [Level 17: Tuples](#level-17-tuples)
        - [Snippet: Attempt without Tuples - Representing High Scores](#snippet-attempt-without-tuples---representing-high-scores)
    - [The Basics of Tuples](#the-basics-of-tuples)
        - [Snippet: Defining a Tuple Variable](#snippet-defining-a-tuple-variable)
        - [Snippet: Using `var` to Simplify Long Tuple Type Names](#snippet-using-var-to-simplify-long-tuple-type-names)
        - [Snippet: Accessing Tuple Values](#snippet-accessing-tuple-values)
        - [Snippet: Valid vs Invalid Types with a Tuple](#snippet-valid-vs-invalid-types-with-a-tuple)
    - [Tuple Element Names](#tuple-element-names)
        - [Snippet: Assigning Names to Tuple Members (without `var`)](#snippet-assigning-names-to-tuple-members-without-var)
        - [Snippet: Mixing Assigned and Default Tuple Member Names](#snippet-mixing-assigned-and-default-tuple-member-names)
        - [Snippet: Assigning Names to Tuple Members (with `var`)](#snippet-assigning-names-to-tuple-members-with-var)
        - [Snippet: Failed Attempt - Assigning Names to Tuple Members (`var`-style but without `var`)](#snippet-failed-attempt---assigning-names-to-tuple-members-var-style-but-without-var)
    - [Tuples and Methods](#tuples-and-methods)
        - [Snippet: Tuple as a Method Parameter Type](#snippet-tuple-as-a-method-parameter-type)
        - [Snippet: Tuple as a Method Return Type](#snippet-tuple-as-a-method-return-type)
        - [Snippet: Inferring Tuple's Types and Names From Method's Return Type](#snippet-inferring-tuples-types-and-names-from-methods-return-type)
        - [Snippet: Using Different Tuple Member Names for Same Tuple in Various Contexts](#snippet-using-different-tuple-member-names-for-same-tuple-in-various-contexts)
    - [More Tuple Examples](#more-tuple-examples)
        - [Snippet: Tuple Representing a Point in 2D Space](#snippet-tuple-representing-a-point-in-2d-space)
        - [Snippet: Using Enums in Tuples](#snippet-using-enums-in-tuples)
        - [Snippet: A Big Tuple Representing a 4x4 Matrix (often used in games)](#snippet-a-big-tuple-representing-a-4x4-matrix-often-used-in-games)
        - [Snippet: Array of Tuples](#snippet-array-of-tuples)
    - [Deconstructing Tuples](#deconstructing-tuples)
        - [Snippet: Grabbing Data Out of a Tuple - by Name](#snippet-grabbing-data-out-of-a-tuple---by-name)
        - [Snippet: Deconstructing a Tuple](#snippet-deconstructing-a-tuple)
        - [Snippet: Deconstructing a Tuple and Declaring Simultaneously](#snippet-deconstructing-a-tuple-and-declaring-simultaneously)
        - [Snippet: Swapping Contents of Two Variables with Tuple Deconstruction](#snippet-swapping-contents-of-two-variables-with-tuple-deconstruction)
      - [Ignoring Elements with Discards](#ignoring-elements-with-discards)
        - [Snippet: Using a Discard Variable](#snippet-using-a-discard-variable)
    - [Tuples and Equality](#tuples-and-equality)
        - [Snippet: Tuples Demonstrating Value Equality](#snippet-tuples-demonstrating-value-equality)
        - [Snippet: Tuples Ignore Member Names For Equality Checks](#snippet-tuples-ignore-member-names-for-equality-checks)
        - [Snippet: Printing Tuples to the Console](#snippet-printing-tuples-to-the-console)
      - [Challenge: Simula's Soups](#challenge-simulas-soups)
  - [Level 18: Classes](#level-18-classes)
    - [Defining a New Class](#defining-a-new-class)
        - [Snippet: Creating a Score Class](#snippet-creating-a-score-class)
        - [Snippet: Creating a Class with Methods](#snippet-creating-a-class-with-methods)
    - [Instances of Classes](#instances-of-classes)
        - [Snippet:](#snippet)
        - [Snippet:](#snippet-1)
        - [Snippet:](#snippet-2)
    - [Constructors](#constructors)
        - [Snippet:](#snippet-3)
      - [Default Constructors and Default Field Values](#default-constructors-and-default-field-values)
        - [Snippet:](#snippet-4)
      - [Constructors with Parameters](#constructors-with-parameters)
        - [Snippet:](#snippet-5)
        - [Snippet:](#snippet-6)
      - [Multiple Constructors](#multiple-constructors)
        - [Snippet:](#snippet-7)
      - [Initializing Fields Inline](#initializing-fields-inline)
        - [Snippet:](#snippet-8)
        - [Snippet:](#snippet-9)
      - [Name Hiding](#name-hiding)
        - [Snippet:](#snippet-10)
        - [Snippet:](#snippet-11)
        - [Snippet:](#snippet-12)
      - [The `this` Keyword](#the-this-keyword)
        - [Snippet:](#snippet-13)
      - [Calling Other Constructors with `this`](#calling-other-constructors-with-this)
        - [Snippet:](#snippet-14)
      - [Leaving Off the Class Name](#leaving-off-the-class-name)
        - [Snippet:](#snippet-15)
        - [My Snippet:](#my-snippet)
    - [Object-Oriented Design](#object-oriented-design)
      - [Challenge: Vin Fletcher's Arrows](#challenge-vin-fletchers-arrows)
  - [Level 19: Information Hiding](#level-19-information-hiding)
    - [The `public` and `private` Accessibility Modifiers](#the-public-and-private-accessibility-modifiers)
      - [The Default Accessibility Level is `private`](#the-default-accessibility-level-is-private)
      - [When to Use `private` and `public`](#when-to-use-private-and-public)
      - [Accessibility Levels as Guidelines, Not Laws](#accessibility-levels-as-guidelines-not-laws)
    - [Abstractions](#abstractions)
    - [Type Accessibility Levels and the `internal` Modifier](#type-accessibility-levels-and-the-internal-modifier)
      - [Challenge: Vin's Trouble](#challenge-vins-trouble)
  - [Level 20: Properties](#level-20-properties)
    - [The Basics of Properties](#the-basics-of-properties)
    - [Auto-Implemented Properties](#auto-implemented-properties)
    - [Immutable Fields and Properties](#immutable-fields-and-properties)
    - [Object Initializer Syntax and Init Properties](#object-initializer-syntax-and-init-properties)
      - [Challenge: The Properties of Arrows](#challenge-the-properties-of-arrows)
    - [Anonymous Types](#anonymous-types)
  - [Level 21: Static](#level-21-static)
    - [Static Members](#static-members)
      - [Static Fields](#static-fields)
      - [Global State](#global-state)
      - [Static Properties](#static-properties)
      - [Static Methods](#static-methods)
      - [Static Constructors](#static-constructors)
    - [Static Classes](#static-classes)
      - [Challenge: Arrow Factories](#challenge-arrow-factories)
  - [Level 22: Null References](#level-22-null-references)
    - [Checking for Null](#checking-for-null)
    - [Choosing When to Allow Null](#choosing-when-to-allow-null)
  - [Level 23: Object-Oriented Design](#level-23-object-oriented-design)
    - [Requirements](#requirements)
    - [Designing the Software](#designing-the-software)
      - [Noun Extraction](#noun-extraction)
      - [UML](#uml)
      - [CRC Cards](#crc-cards)
      - [Evaluating a Design](#evaluating-a-design)
    - [Creating Code](#creating-code)
    - [How to Collaborate](#how-to-collaborate)
      - [Creating New Objects](#creating-new-objects)
      - [Constructor Parameters](#constructor-parameters)
      - [Method Parameters](#method-parameters)
      - [Asking Another Object](#asking-another-object)
      - [Supplying the Reference via Property or Method](#supplying-the-reference-via-property-or-method)
      - [Static Members](#static-members-1)
      - [Choices, Choices](#choices-choices)
    - [Baby Steps](#baby-steps)
  - [Level 24: The Catacombs of the Class](#level-24-the-catacombs-of-the-class)
    - [The Five Prototypes](#the-five-prototypes)
      - [Boss Battle: The Point](#boss-battle-the-point)
      - [Boss Battle: The Color](#boss-battle-the-color)
      - [Boss Battle: The Card](#boss-battle-the-card)
      - [Boss Battle: The Locked Door](#boss-battle-the-locked-door)
      - [Boss Battle: The Password Validator](#boss-battle-the-password-validator)
    - [Object-Oriented Design](#object-oriented-design-1)
      - [Boss Battle: Rock-Paper-Scissors](#boss-battle-rock-paper-scissors)
      - [Boss Battle: 15-Puzzle](#boss-battle-15-puzzle)
      - [Boss Battle: Hangman](#boss-battle-hangman)
    - [Tic-Tac-Toe](#tic-tac-toe)
      - [Boss Battle: Tic-Tac-Toe](#boss-battle-tic-tac-toe)
  - [Level 25: Inheritance](#level-25-inheritance)
    - [Inheritance and the `object` class](#inheritance-and-the-object-class)
    - [Choosing Base Classes](#choosing-base-classes)
    - [Constructors](#constructors-1)
    - [Casting and Checking for Types](#casting-and-checking-for-types)
    - [The `protected` Access Modifier](#the-protected-access-modifier)
    - [Sealed Classes](#sealed-classes)
      - [Challenge: Packing Inventory](#challenge-packing-inventory)
  - [Level 26: Polymorphism](#level-26-polymorphism)
    - [Abstract Methods and Classes](#abstract-methods-and-classes)
    - [New Methods](#new-methods)
      - [Challenge: Labeling Inventory](#challenge-labeling-inventory)
      - [Challenge: The Old Robot](#challenge-the-old-robot)
  - [Level 27: Interfaces](#level-27-interfaces)
    - [Defining Interfaces](#defining-interfaces)
    - [Implementing Interfaces](#implementing-interfaces)
    - [Interfaces and Base Classes](#interfaces-and-base-classes)
    - [Explicit Interface Implementations](#explicit-interface-implementations)
    - [Default Interface Methods](#default-interface-methods)
      - [Supporting Default Interface Methods](#supporting-default-interface-methods)
      - [Should I Use Default Interface Methods?](#should-i-use-default-interface-methods)
      - [Challenge: Robotic Interface](#challenge-robotic-interface)
  - [Level 28: Structs](#level-28-structs)
    - [Classes vs. Structs](#classes-vs-structs)
      - [Rules to Follow When Making Structs](#rules-to-follow-when-making-structs)
    - [Built-In Type Aliases](#built-in-type-aliases)
    - [Boxing and Unboxing](#boxing-and-unboxing)
      - [Challenge: Room Coordinates](#challenge-room-coordinates)
  - [Level 29: Records](#level-29-records)
    - [Records](#records)
      - [Additional Members](#additional-members)
      - [Replacing Synthesized Members](#replacing-synthesized-members)
      - [Records are Classes](#records-are-classes)
      - [Inheritance](#inheritance)
      - [Non-Positional Records](#non-positional-records)
    - [`with` Expressions](#with-expressions)
    - [Classes, Records, or Structs?](#classes-records-or-structs)
      - [Challenge: War Preparations](#challenge-war-preparations)
  - [Level 30: Generics](#level-30-generics)
    - [The Motivation for Generics](#the-motivation-for-generics)
    - [Defining a Generic Type](#defining-a-generic-type)
      - [Multiple Generic Type Parameters](#multiple-generic-type-parameters)
      - [Inheritance and Generic Types](#inheritance-and-generic-types)
    - [Generic Methods](#generic-methods)
    - [Generic Type Constraints](#generic-type-constraints)
      - [Multiple Constraints](#multiple-constraints)
      - [Constraints on Methods](#constraints-on-methods)
    - [The `default` Operator](#the-default-operator)
      - [Challenge: Colored Items](#challenge-colored-items)
  - [Level 31: The Fountain of Objects](#level-31-the-fountain-of-objects)
    - [The Main Challenge](#the-main-challenge)
      - [Boss Bottle: The Fountain of Objects](#boss-bottle-the-fountain-of-objects)
    - [Expansions](#expansions)
      - [Boss Bottle: Small, Medium, or Large](#boss-bottle-small-medium-or-large)
      - [Boss Bottle: Pits](#boss-bottle-pits)
      - [Boss Bottle: Maelstroms](#boss-bottle-maelstroms)
      - [Boss Bottle: Amaroks](#boss-bottle-amaroks)
      - [Boss Bottle: Getting Armed](#boss-bottle-getting-armed)
      - [Boss Bottle: Getting Help](#boss-bottle-getting-help)
  - [Level 32: Some Useful Types](#level-32-some-useful-types)
    - [The `Random` Class](#the-random-class)
      - [Challenge: The Robot Pilot](#challenge-the-robot-pilot)
    - [The `DateTime` Struct](#the-datetime-struct)
    - [The `TimeSpan` Struct](#the-timespan-struct)
    - [Challenge: Time in the Cavern](#challenge-time-in-the-cavern)
    - [The `Guid` Struct](#the-guid-struct)
    - [The `List<T>` Class](#the-listt-class)
      - [Creating List Indexes](#creating-list-indexes)
      - [Indexing](#indexing)
      - [Adding and Removing Items from List](#adding-and-removing-items-from-list)
      - [`foreach` Loops](#foreach-loops)
      - [Other Useful Things](#other-useful-things)
      - [Challenge: List of Commands](#challenge-list-of-commands)
    - [The `IEnumerable<T>` Interface](#the-ienumerablet-interface)
    - [The `Dictionary<TKey, TValue>` Class](#the-dictionarytkey-tvalue-class)
      - [Types Besides `string`](#types-besides-string)
      - [Dictionary Keys Should Not Change](#dictionary-keys-should-not-change)
    - [The `Nullable<T>` Struct](#the-nullablet-struct)
    - [`ValueTuple` Structs](#valuetuple-structs)
    - [The `StringBuilder` Class](#the-stringbuilder-class)


---

## Level 15: Object-Oriented Concepts
* Object-oriented programming allows you to separate large programs into individual components called objects, each responsible for a small slice of the overall program.
* Objects belong to a class, which defines a category of things with the same structure and capabilities.
* Building custom types is a powerful tool for building large programs.

> *object-oriented programming*
> *class*
> *type*
> *instances*

Essential rule in C# programming: **Use the right type for everything you create. If the right type doesn't exist, create it first.**

#### Knowledge Check: Objects
1. What two things does an object bundle together?
2. True/False. C# lets you define new types of objects.

<!-- 
1. data and operations on that data
2. True
-->

---

## Level 16: Enumerations
### Speedrun
* An enumeration is a custom type that names off the set of allowed values: `enum Season { Winter, Spring, Summer, Fall }`
* Define your enumerations after your main method and other methods or in a separate file.
* After defining an enumeration, you can use it for a variable's type: `Season now = Seasons.Winter;`

##### Snippet: Attempt without Enums - Representing Seasons
```cs
// with ints
int current = 2; // Summer
if (today === 3) Console.WriteLine("Winter is coming.");

// with strings
string current = "Summer";
if (today == "Fall") Console.WriteLine("Winter is coming.");
```

### Enumeration Basics
> * *enumeration* or *enumerated type* or *enum* - A type definition that names off each allowed choice.
> * *enumerate* - To list off things, one by one.

#### Defining an Enumeration
##### Snippet: Where to Define New Types Including Enums
```cs
using System;

Console.WriteLine("Hello World!");

// <-- Add enumerations here.
```

##### Snippet: Defining an Enum (Compact Style)
```cs
enum Season { Winter, Spring, Summer, Fall } // New types MUST go after other code in the main method (or in another file)
```

##### Snippet: Defining an Enum (Expanded Style)
```cs
enum {
  Winter, // default value
  Spring,
  Summer,
  Fall
}
```

#### Using an Enumeration

##### Snippet: Declaring Variables with Enum Type
```cs
Season current;
```

##### Snippet: Using Enum Members as Values
```cs
Season current = Season.Summer;
```

##### Snippet: Using Comparison Operators with Enum Variables
```cs
using System;

Season current = Season.Summer;

if (current == Season.Summer || current == Season.Winter) // Enumerations have much in common with integers.
    Console.WriteLine("Happy solstice!");
else
    Console.WriteLine("Happy equinox!");

enum Season { Winter, Spring, Summer, Fall }
```


#### Revisiting `ConsoleColor`
##### Snippet: Example of a Built-In Enumeration, `ConsoleColor`
```cs
Console.BackgroundColor = ConsoleColor.Yellow;
```

#### Challenge: Simula's Test
Tests these things:
- Define an enumeration.
- Use the enumeration as a type.
- Use the enumeration as a value.

### Underlying Types
> *underlying type* - The type that an enumeration is based on.

##### Snippet: Changing an Enum's Underlying Type
```cs
enum Season : byte { Winter, Summer, Spring, Fall } // Default underlying type is `int`.
```

##### Snippet: Override an Enum's Default `int` Values
```cs
enum Season 
{ 
  Winter = 1, // Auto-assigns to 0 by default
  Summer, // 2 - Auto-assigns to the previous member's value +1.
  Spring, // 3
  Fall // 4
}
```

##### Snippet: Casting Between `int`s and Enums
```cs
int number = (int)Season.Fall;
Season now = (Season)2;
```

##### My Snippet: Enum with a Blank Default Value
```cs
// The default value for an enumeration is whatever is assigned 0.
enum Season {
  Winter = 1,
  Spring,
  Summer,
  Fall
  
  // Without this placeholder member, the enum's default value would not even be a legal choice.
  // Having it provides a way to refer the default value by name, even if it doesn't represent a valid option.
  Unknown = 0, 
}
```

##### Snippet: Casting an Enum with an Invalid `int`
```cs
Season now = (Season)822;
```

---

## Level 17: Tuples
* Tuples combine multiple elements into a single bundle: `(double, double) point = (2, 4);`
* You can give (ephemeral) names to tuple elements, which can be used later: `(double x, double y) point = (2, 4);`
* Tuples can be used like any other variable type, including using them as parameters and return values.
* Deconstruction unpacks tuples into multiple variables: `(double x double y) = MakePoint();`
* Two tuple values are equal if their corresponding items are all equal.

> * *composite type* - A type made by assembling other elements to form a new type. Tuples, classes, and structs are all composite types.

__My Note: Usually people name tuple members with lowerCamelCase similar to methods, not UpperCamelCase like the book shows.The lower casing is because of deconstruction into variables is common.__

##### Snippet: Attempt without Tuples - Representing High Scores
```cs
string[] names = new string[3] { "R2-D2", "C-3PO", "GONK" };
int[] scores   = new int[3]    { 12420,      8543,     -1 };
int[] level    = new int[3]    { 15,            9,      1 };
```

### The Basics of Tuples
> * *tuple* - (pronounced like "TOO-ples" or "TUP-ples") A simple data structure that stores a set of related values of different types as a single unit. The name comes from the math world as a generalization of the naming pattern *double*, *triple*, *quadruple*, *quintuple*, etc. These are also sometimes referred to by the number of items in them: a 2-tuple for one with two things, an 8-tuple for one with eight things, etc.

The simplest tool for creating composite types in C#.

##### Snippet: Defining a Tuple Variable
```cs
(string, int, int) score = ("R2-D2", 12420, 15);
```

##### Snippet: Using `var` to Simplify Long Tuple Type Names
```cs
var score = ("R2-D2", 12420, 15);
```

##### Snippet: Accessing Tuple Values
```cs
Console.WriteLine($"Name:{score.Item1} Level:{score.Item3} Score:{score.Item2}");
```

##### Snippet: Valid vs Invalid Types with a Tuple
```cs
// valid
(string, int, int) score1 = ("R2-D2", 12420, 15);
var score2 = score1;

// invalid
(string, int) partialScore = score1;      // Not the same number of items.
(int, int, string) mixedUpScore = score1; // Items in a different order.
```

### Tuple Element Names

##### Snippet: Assigning Names to Tuple Members (without `var`)
```cs
(string Name, int Points, int Level) score = ("R2-D2", 12420, 15);
Console.WriteLine($"Name:{score.Name} Level:{score.Level} Score:{score.Points}");
```

 ##### Snippet: Mixing Assigned and Default Tuple Member Names
 ```cs
 (string Name, int, int) score = ("R2-D2", 12420, 15);
 Console.WriteLine($"Name:{score.Name} Level:{score.Item3} Score:{score.Item2}");
 ```
 
 ##### Snippet: Assigning Names to Tuple Members (with `var`)
 ```cs
 var score = (Name: "R2-D2", Points: 12420, Level: 15);
 Console.WriteLine($"Name:{score.Name} Level:{score.Level} Score{score.Points}");
 ```

 ##### Snippet: Failed Attempt - Assigning Names to Tuple Members (`var`-style but without `var`)
 ```cs
 (string, int P, int L) score = (Name: "R2-D2", Points: 12420, Level: 15); // Names applied to the tuple's values (Name, Point, Level) are ignored without `var`
 Console.WriteLine($"Name{score.Item1} Level:{score.L} Score:{score.P}"); // Only names applied to the tuple's types will work
 ```

### Tuples and Methods
##### Snippet: Tuple as a Method Parameter Type
```cs
void DisplayScore((string Name, int Points, int Level) score) // Parameters cannot use var!
{
    Console.WriteLine($"Name:{score.Name} Level:{score.Level} Score:{score.Points}");
}
```

##### Snippet: Tuple as a Method Return Type
```cs
(string Name, int Points, int Level) GetScore() => ("R2-D2", 12420, 15);
```

##### Snippet: Inferring Tuple's Types and Names From Method's Return Type
```cs
var score = GetScore();
Console.WriteLine($"Name:{score.Name} Level:{score.Level} Score:{score.Points}");
```

##### Snippet: Using Different Tuple Member Names for Same Tuple in Various Contexts
```cs
(string One, int Two, int Three) score = GetScore();
DisplayScore(score);

(string N, int P, int L) GetScore() => ("R2-D2", 12420, 15);

void DisplayScore((string Name, int Points, int Level) score)
{
    Console.WriteLine($"Name:{score.Name} Level:{score.Level} Score:{score.Points}");
}
```

### More Tuple Examples
##### Snippet: Tuple Representing a Point in 2D Space
```cs
(double X, double Y) point = (2.0, 4.0);
```

##### Snippet: Using Enums in Tuples
```cs
enum TileType { Grass, Water, Rock }
var tile = (Row: 2, Column: 4, Type: TileType.Grass);
```

##### Snippet: A Big Tuple Representing a 4x4 Matrix (often used in games)
```cs
var matrix = (M11: 1, M12: 0, M13: 0, M14: 0,
              M21: 0, M22: 1, M23: 0, M24: 0,
              M31: 0, M32: 0, M33: 1, M34: 0,
              M41: 0, M42: 0, M43: 0, M44: 1);
```

##### Snippet: Array of Tuples
```cs
(string Name, int Points, int Level)[] CreateHighScores()
{
    return new (string, int, int)[3]
    {
        ("R2-D2", 12420, 15),
        ("C-3PO",  8543,  9),
        ("GONK",     -1,  1),
    }
}
```

### Deconstructing Tuples
> * *deconstruction* or *unpacking* - Extracting the elements out of a tuple or other type into separate individual variables.

##### Snippet: Grabbing Data Out of a Tuple - by Name
```cs
var score = (Name: "R2-D2", Points: 12420, Level: 15);

string playerName = score.Name;
```

##### Snippet: Deconstructing a Tuple
```cs
string name;
int points;
int level;
(name, points, level) = score;
Console.WriteLine($"{name} reached level {level} with {points} points.");
```

##### Snippet: Deconstructing a Tuple and Declaring Simultaneously
```cs
(string name, int points, int level) = score;
```

##### Snippet: Swapping Contents of Two Variables with Tuple Deconstruction
```cs
double x = 4;
double y = 2;
(x, y) = (y, x); // x is 4, y is 2
```

#### Ignoring Elements with Discards
> * *discard* - An underscore character (`_`), used in places where a variable is expected, that tells the compiler to generate a throwaway variable in its place. Alternatively, used in pattern matching to indicate that anything is a match.

##### Snippet: Using a Discard Variable
```cs
(string name, int points, _) = score;
```

### Tuples and Equality
##### Snippet: Tuples Demonstrating Value Equality
```cs
(int, int) a = (1, 2);
(int, int) b = (1, 2);

Console.WriteLine(a == b); // True
Console.WriteLine(a != b); // False
```
##### Snippet: Tuples Ignore Member Names For Equality Checks
```cs
var a = (X: 2, Y: 4);
var b = (U: 2, V: 4);
Console.WriteLine(a == b); // True
```
##### Snippet: Printing Tuples to the Console
```cs
(string Crew, string Pirate, int Berries) nami = ("Straw Hat Pirates", "Nami", 300_000_000);
Console.WriteLine(nami) // ("Straw Hat Pirates", "Nami", 300_000_000) ?!?!?!?! TODO TEST THIS OUT
```


#### Challenge: Simula's Soups
* Create an array of tuples where each tuple is composed of enums.
* Print resulting tuples to the console.

---

## Level 18: Classes
* Classes are the most powerful way to define new types.
* A class bundles together data (fields) and operations on that data (methods): `class Score { public int points; public int level; public void Method() { } }`
* Constructors define how new instances are created: `public Score(int p) { points = p; }`
* Classes are reference types.

> * *object-oriented design* - Deciding how to split a large program into multiple objects and how to have them coordinate with each other.
> * *class* - A category of types, formed by combining fields (data) and methods (operations on that data). The most versatile type you can define. Creates a blueprint that instances of the type use. All classes are reference types.
> * *instance* - An object of a specific type. A `string` instance is an object whose type is `string`.


### Defining a New Class
> * *field* or *instance variable* - A variable declared as a member of a class or other type, as opposed to a local variable or parameter. For fields not marked as static, each instance will have its own copy. Making fields `private` facilitates the principle of abstraction.
> * *encapsulation* - Combining fields (data) and methods (operations on the data) into a single cohesive bundle. A fundamental principle of object-oriented programming.


##### Snippet: Creating a Score Class
```cs
using System;

// <-- Your main method goes here.

class Score
{
    public string name;
    public int points;
    public int level;
}

// <-- Other classes and enumerations can go here.
```

##### Snippet: Creating a Class with Methods
```cs
class Score
{
    public string name;
    public int points;
    public int level;

    public bool EarnedStar() => (points / level) > 1000;
}
```

__Object-Oriented Principle #1: Encapsulation--Combining data and operations on that data (methods) into a well-defined unit (like a class).__

### Instances of Classes
##### Snippet: 
```cs
Score best = new Score();

class Score
{
    public string name;
    public int points;
    public int level;

    public bool EarnedStar() => (points / level) > 1000;
}
```

##### Snippet: 
```cs
Score best = newScore();

best.name = "R2-D2";
best.points = 12420;
best.level = 15;

if (best.EarnedStar())
    Console.WriteLine("You earned a star!");
```

##### Snippet: 
```cs
Score a = new Score();
a.name = "R2-D2";
a.points = 12420;
a.level = 15;

Score b = new Score();
b.name = "C-3PO";
b.points = 8543;
b.level = 8;

if (a.EarnedStar())
    Console.WriteLine($"{a.name} earned a star!");
if (b.EarnedStar())
    Console.WriteLine($"{b.name} earned a star!");
```

### Constructors

##### Snippet: 
```cs
class Score
{
    public string name;
    public int points;
    public int level;

    public Score()
    {
        name = "Unknown";
        points = 0;
        level = 1;
    }

    public bool EarnedStar() => (points / level) > 1000;
}
```

#### Default Constructors and Default Field Values

##### Snippet: 
```cs
public Score() { }
```

#### Constructors with Parameters

##### Snippet: 
```cs
class Score
{
    public string name;
    public int points;
    public int level;

    public Score(string n, int p, int l) // That's a lowercase 'L', not a 1.
    {
        name = n;
        points = p;
        level = l;
    }
    
    public bool EarnedStar() => (points / level) > 1000;
}
```

##### Snippet: 
```cs
Score score = new Score("R2-D2", 12420, 15);
```

#### Multiple Constructors
##### Snippet: 
```cs
class Score
{
    public string name;
    public int points;
    public int level;

    public Score()
    {
        name = "Unknown";
        points = 0;
        level = 1;
    }

    public Score(string n, int p, int l) // That's a lowercase 'L', not a 1.
    {
        name = n;
        points = p;
        level = l;
    }
    
    public bool EarnedStar() => (points / level) > 1000;
}
```

#### Initializing Fields Inline
##### Snippet: 
```cs
class Score
{
    public string name = "Unknown";
    public int points = 0;
    public int level = 1;

    public bool EarnedStar() => (points / level) > 1000;
}
```

##### Snippet: 
```cs
class Score
{
    public string name = "Unknown";
    public int points = 0;
    public int level = 1;

    public Score()
    {
        name = "Mystery";
    }

    public bool EarnedStar() => (points / level) > 1000;
}
```



#### Name Hiding
> * *name hiding* - When a local variable or parameter shares the same name as a field, making the field not directly accessible. The field may still be accessed using the `this` keyword.

##### Snippet: 
```cs
public Score(string n, int p, int l)
{
    name = n;
    points = p;
    level = l;
}
```

##### Snippet: 
```cs
public Score(string name, int points, int level)
{
    name = name; // These are not going to do what you want!
    points = points;
    level = level;
}
```

##### Snippet: 
```cs
class Score
{
    public string _name;
    public int _points;
    public int _level;

    public Score(string name, int points, int level)
    {
        _name = name;
        _points = points;
        _level = level;
    }
}
```



#### The `this` Keyword
##### Snippet: 
```cs
class Score
{
    public string name;
    public int points;
    public int level;

    public Score(string name, int points, int level)
    {
        this.name = name;
        this.points = points;
        this.level = level;
    }
}
```



#### Calling Other Constructors with `this`
##### Snippet: 
```cs
class Score
{
    public string _name;
    public int _points;
    public int _level;

    public Score() : this("Unknown", 0, 1)
    {
    }

    public Score(string name, int points, int level)
    {
        _name = name;
        _points = points;
        _level = level;
    }
}
```


#### Leaving Off the Class Name

##### Snippet: 
```cs
Score first = new();
Score second = new("R2-D2", 12420, 15);
```

##### My Snippet: 
```cs
var first = new Score();
var second = new Score("R2-D2", 12420, 15);
```


### Object-Oriented Design


#### Challenge: Vin Fletcher's Arrows
* Define a new class type
* Include instance variables
* Include a constructor that allows setting the instance variables on initialization.
* Add a method that returns a calculation based on the instance variable values.

---

## Level 19: Information Hiding
* Information hiding is where some details are hidden from the outside world while still presenting a public boundary that the outside world can still work with.
* Class members should be marked `public` or `private` to indicate which of the two is intended.
* Data (instance variables) should be `private` in nearly all cases.
* Abstraction: when things are private, they can change without the outside world being affected. The outside world depends on the public parts, while anything private can change without problems.
* A third level is `internal`, which is for things meant to be used only inside the project.
* Classes and other types also have their own accessibility level: `public class X { ... }`

### The `public` and `private` Accessibility Modifiers


#### The Default Accessibility Level is `private`


#### When to Use `private` and `public`


#### Accessibility Levels as Guidelines, Not Laws


### Abstractions


### Type Accessibility Levels and the `internal` Modifier


#### Challenge: Vin's Trouble



---

## Level 20: Properties
* Properties give you field-like access while still protecting data with methods: `public float Width { get => width; set => width = value; }`. To use a property: `rectangle.Width = 3;`
* Auto-properties are for when no extra logic is needed: `public float Width { get; set; }`
* Properties can be read-only, only settable in a constructor: `public float Width { get; }`
* Fields can also be read-only: `private readonly float _width = 3;`
* With properties, objects can be initialized using object initializer syntax: `new Rectangle() { Width = 2, Height = 3 }`
* An `init` accessor is like a setter but only usable in object initializer syntax. `public float Width { get; init; }`

### The Basics of Properties


### Auto-Implemented Properties


### Immutable Fields and Properties


### Object Initializer Syntax and Init Properties


#### Challenge: The Properties of Arrows


### Anonymous Types



---

## Level 21: Static
* Static things are owned by the type itself rather than by a single instance (shared across all instances).
* Fields, methods, and constructors can all be static.
* If a class itself is made static, it can only contain static members (`Console`, `Convert`, `Math`).

### Static Members


#### Static Fields


#### Global State


#### Static Properties


#### Static Methods


#### Static Constructors


### Static Classes


#### Challenge: Arrow Factories

---

## Level 22: Null References
* Reference types may contain a reference to nothing: `null`, which represents a lack of an object.
* Carefully consider whether null makes sense as an option for a variable and program accordingly.
* Check for null with `x == null`, the null conditional operators `x?.DoStuff()` and `x?[3]`, and use `??` to allow null values to fall back to some other default: `x ?? "empty"`
* If configured right, the compiler can warn you of null-related issues, and you can dictate whether a variable can be null or not (`string` when it is not allowed, `string?` for when it is allowed).

### Checking for Null


### Choosing When to Allow Null

---

## Level 23: Object-Oriented Design
* Object-oriented design is figuring out which objects should exist in your program, which classes they should come from, what responsibilities each should have, and how they should work together.
* The design starts with identifying the requirements of what you are building.
* Noun extraction helps get the design process started by identifying concepts and jobs to do in the requirements.
* CRC cards are a tool to think through a design with physical cards for each object, containing the class they belong to, their responsibilities, and their collaborators.
* Object-oriented design is hard, but you don't have to figure out the entire program all at once, nor do you have to get it right the first time.

### Requirements


### Designing the Software


#### Noun Extraction


#### UML


#### CRC Cards


#### Evaluating a Design


### Creating Code


### How to Collaborate


#### Creating New Objects


#### Constructor Parameters


#### Method Parameters


#### Asking Another Object


#### Supplying the Reference via Property or Method


#### Static Members


#### Choices, Choices


### Baby Steps



---

## Level 24: The Catacombs of the Class
* This level is made entirely of problems to work through to gain more practice creating classes and doing object-oriented design, and culminates in building the game of Tic-Tac-Toe from scratch.

### The Five Prototypes


#### Boss Battle: The Point


#### Boss Battle: The Color


#### Boss Battle: The Card


#### Boss Battle: The Locked Door


#### Boss Battle: The Password Validator


### Object-Oriented Design


#### Boss Battle: Rock-Paper-Scissors


#### Boss Battle: 15-Puzzle


#### Boss Battle: Hangman


### Tic-Tac-Toe


#### Boss Battle: Tic-Tac-Toe



---

## Level 25: Inheritance
* Inheritance lets you derive new classes based on existing ones. The new class inherits everything except constructors from the base class. `class Derived : Base { ... }`
* Classes derive from `object` by default, and everything eventually derives from `object` even if another class is explicitly stated.
* Constructors in a derived class must call out the constructor they are using from the base class unless they are using the parameterless constructor (if it exists): `public Derived(int x) : base(x) { ... }`
* Derived class instances can be used where the base class is stated: `Base x = new Derived();`
* The `protected` accessibility modifier makes things accessible in the class and any derived classes.

### Inheritance and the `object` class


### Choosing Base Classes


### Constructors


### Casting and Checking for Types


### The `protected` Access Modifier


### Sealed Classes


#### Challenge: Packing Inventory



---

## Level 26: Polymorphism
* Polymorphism lets a derived class supply its own definition ("override") for a member declared in its base class.
* Marking a member with `virtual` indicates it can be overriden.
* Derived classes override a member by marking it with `override`.
* Classes can leave members unimplemented with `abstract`, but the class must also be `abstract`.

### Abstract Methods and Classes
### New Methods
#### Challenge: Labeling Inventory
#### Challenge: The Old Robot

---

## Level 27: Interfaces
* An interface is a type that defines a contract or role that objects can fulfill or implement: `public interface ILevelBuilder { Level BuildLevel(int levelNumber); }`
* Classes can implement interfaces: `public class LevelBuilder : ILevelBuilder { public Level BuildLevel(int levelNumber) => new Level(); }`
* A class can have only one base class but can implement many interfaces.

### Defining Interfaces


### Implementing Interfaces


### Interfaces and Base Classes


### Explicit Interface Implementations


### Default Interface Methods


#### Supporting Default Interface Methods


#### Should I Use Default Interface Methods?


#### Challenge: Robotic Interface



---

## Level 28: Structs
* A struct is a custom type that defines a simple data structure without complex behavior: `public struct Point { ... }`. Structs are not focused on behavior but can have properties and methods.
* Compared to classes: structs are value types, automatically have value semantics, and cannot be used in inheritance.
* Make structs small, immutable, and ensure the default value is legitimate.
* All the built-in types are aliases for other Structs (and a few classes). For example, `int` is shorthand for `System.Int32`.
* Value types can be stored in reference-typed variables (`object thing = 3;`) but will cause the value to be `"boxed"` and placed on the heap.

### Classes vs. Structs


#### Rules to Follow When Making Structs


### Built-In Type Aliases


### Boxing and Unboxing


#### Challenge: Room Coordinates



---

## Level 29: Records
* Records are compact notation to represent objects that are data-centric, immutable, and with value semantics: `public record Point(float X, float Y);`
* You can add additional members to a record or replace the synthesized members: `public record Rectangle(float Width, float Height) { public float Area => Width * Height; }`
* A `with` expression lets you create a new record object from an existing one with tweaks: `Point modified = p with { X = -2 };`

### Records
#### Additional Members
#### Replacing Synthesized Members
#### Records are Classes
#### Inheritance
#### Non-Positional Records
### `with` Expressions
### Classes, Records, or Structs?
#### Challenge: War Preparations


---

## Level 30: Generics
* Generics solve the problem of needing to make classes or methods that would differ only by the types they use. Generics leave placeholders for types that can be filled in when used.
* Defining a generic class: `public class List<T> { public T GetItemAt(int index) { ... } ... }`
* You can also make generic methods and generic types with multiple type parameters.
* Constraints allow you to limit what can be used for a generic type argument while enabling you to know more about the types being used: `class List<T> where T : ISomeInterface { }`

### The Motivation for Generics


### Defining a Generic Type


#### Multiple Generic Type Parameters


#### Inheritance and Generic Types


### Generic Methods


### Generic Type Constraints


#### Multiple Constraints


#### Constraints on Methods


### The `default` Operator


#### Challenge: Colored Items

---

## Level 31: The Fountain of Objects
* This level contains no new C# information. It is a large multi-part program to complete to hone your programming skills.

### The Main Challenge


#### Boss Bottle: The Fountain of Objects


### Expansions


#### Boss Bottle: Small, Medium, or Large


#### Boss Bottle: Pits


#### Boss Bottle: Maelstroms


#### Boss Bottle: Amaroks


#### Boss Bottle: Getting Armed


#### Boss Bottle: Getting Help



---

## Level 32: Some Useful Types
* `Random` generates pseudo-random numbers.
* `DateTime` gets the current time and stores time and date values.
* `TimeSpan` represents a length of time.
* `Guid` is used to store a globally unique identifier.
* `List<T>` is a popular and versatile generic collection--use it instead of arrays for most things.
* `IEnumerable<T>` is an interface for almost any collection type. The basis of `foreach` loops.
* `Dictionary<TKey, TValue>` can look up one piece of information from another.
* `Nullable<T>` is a struct that can express the concept of a missing value for value types.
* `ValueTuple` is the secret sauce behind tuples in C#.
* `StringBuilder` is a less memory-intensive way to build strings a little at a time.

### The `Random` Class


#### Challenge: The Robot Pilot


### The `DateTime` Struct


### The `TimeSpan` Struct


### Challenge: Time in the Cavern


### The `Guid` Struct


### The `List<T>` Class


#### Creating List Indexes


#### Indexing


#### Adding and Removing Items from List


#### `foreach` Loops


#### Other Useful Things


#### Challenge: List of Commands


### The `IEnumerable<T>` Interface


### The `Dictionary<TKey, TValue>` Class


#### Types Besides `string`


#### Dictionary Keys Should Not Change


### The `Nullable<T>` Struct


### `ValueTuple` Structs


### The `StringBuilder` Class


