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
        - [Snippet:](#snippet-16)
        - [Snippet:](#snippet-17)
        - [Snippet:](#snippet-18)
        - [Snippet:](#snippet-19)
    - [The `public` and `private` Accessibility Modifiers](#the-public-and-private-accessibility-modifiers)
        - [Snippet:](#snippet-20)
        - [Snippet:](#snippet-21)
        - [Snippet:](#snippet-22)
        - [Snippet:](#snippet-23)
        - [Snippet:](#snippet-24)
      - [The Default Accessibility Level is `private`](#the-default-accessibility-level-is-private)
      - [When to Use `private` and `public`](#when-to-use-private-and-public)
      - [Accessibility Levels as Guidelines, Not Laws](#accessibility-levels-as-guidelines-not-laws)
    - [Abstraction](#abstraction)
        - [Snippet:](#snippet-25)
    - [Type Accessibility Levels and the `internal` Modifier](#type-accessibility-levels-and-the-internal-modifier)
      - [Challenge: Vin's Trouble](#challenge-vins-trouble)
  - [Level 20: Properties](#level-20-properties)
    - [The Basics of Properties](#the-basics-of-properties)
        - [Snippet:](#snippet-26)
        - [Snippet:](#snippet-27)
        - [Snippet:](#snippet-28)
        - [Snippet:](#snippet-29)
        - [Snippet:](#snippet-30)
        - [Snippet:](#snippet-31)
        - [Snippet:](#snippet-32)
        - [Snippet:](#snippet-33)
        - [Snippet:](#snippet-34)
    - [Auto-Implemented Properties](#auto-implemented-properties)
        - [Snippet:](#snippet-35)
        - [Snippet:](#snippet-36)
        - [Snippet:](#snippet-37)
        - [Snippet:](#snippet-38)
    - [Immutable Fields and Properties](#immutable-fields-and-properties)
        - [Snippet:](#snippet-39)
        - [Snippet:](#snippet-40)
    - [Object Initializer Syntax and Init Properties](#object-initializer-syntax-and-init-properties)
        - [Snippet:](#snippet-41)
        - [Snippet:](#snippet-42)
        - [Snippet:](#snippet-43)
        - [Snippet:](#snippet-44)
        - [Snippet:](#snippet-45)
        - [Snippet:](#snippet-46)
      - [Challenge: The Properties of Arrows](#challenge-the-properties-of-arrows)
    - [Anonymous Types](#anonymous-types)
        - [Snippet:](#snippet-47)
  - [Level 21: Static](#level-21-static)
    - [Static Members](#static-members)
        - [Snippet:](#snippet-48)
      - [Static Fields](#static-fields)
        - [Snippet:](#snippet-49)
        - [Snippet:](#snippet-50)
      - [Global State](#global-state)
      - [Static Properties](#static-properties)
        - [Snippet:](#snippet-51)
      - [Static Methods](#static-methods)
        - [Snippet:](#snippet-52)
        - [Snippet:](#snippet-53)
      - [Static Constructors](#static-constructors)
        - [Snippet:](#snippet-54)
    - [Static Classes](#static-classes)
        - [Snippet:](#snippet-55)
      - [Challenge: Arrow Factories](#challenge-arrow-factories)
  - [Level 22: Null References](#level-22-null-references)
        - [Snippet:](#snippet-56)
        - [Snippet:](#snippet-57)
        - [Snippet:](#snippet-58)
    - [Checking for Null](#checking-for-null)
        - [Snippet:](#snippet-59)
        - [Snippet:](#snippet-60)
        - [Snippet:](#snippet-61)
        - [Snippet:](#snippet-62)
        - [Snippet:](#snippet-63)
        - [Snippet:](#snippet-64)
    - [Choosing When to Allow Null](#choosing-when-to-allow-null)
        - [Snippet:](#snippet-65)
        - [Snippet:](#snippet-66)
        - [Snippet:](#snippet-67)
  - [Level 23: Object-Oriented Design](#level-23-object-oriented-design)
    - [Requirements](#requirements)
    - [Designing the Software](#designing-the-software)
      - [Noun Extraction](#noun-extraction)
      - [UML](#uml)
      - [CRC Cards](#crc-cards)
      - [Evaluating a Design](#evaluating-a-design)
    - [Creating Code](#creating-code)
        - [Snippet:](#snippet-68)
    - [How to Collaborate](#how-to-collaborate)
      - [Creating New Objects](#creating-new-objects)
      - [Constructor Parameters](#constructor-parameters)
        - [Snippet:](#snippet-69)
      - [Method Parameters](#method-parameters)
        - [Snippet:](#snippet-70)
      - [Asking Another Object](#asking-another-object)
        - [Snippet:](#snippet-71)
      - [Supplying the Reference via Property or Method](#supplying-the-reference-via-property-or-method)
        - [Snippet:](#snippet-72)
      - [Static Members](#static-members-1)
        - [Snippet:](#snippet-73)
        - [Snippet:](#snippet-74)
        - [Snippet:](#snippet-75)
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
        - [Snippet:](#snippet-76)
        - [Snippet:](#snippet-77)
        - [Snippet:](#snippet-78)
        - [Snippet:](#snippet-79)
        - [Snippet:](#snippet-80)
        - [Snippet:](#snippet-81)
        - [Snippet:](#snippet-82)
    - [Choosing Base Classes](#choosing-base-classes)
        - [Snippet:](#snippet-83)
        - [Snippet:](#snippet-84)
        - [Snippet:](#snippet-85)
        - [Snippet:](#snippet-86)
        - [Snippet:](#snippet-87)
        - [Snippet:](#snippet-88)
    - [Constructors](#constructors-1)
        - [Snippet:](#snippet-89)
        - [Snippet:](#snippet-90)
        - [Snippet:](#snippet-91)
        - [Snippet:](#snippet-92)
    - [Casting and Checking for Types](#casting-and-checking-for-types)
        - [Snippet:](#snippet-93)
        - [Snippet:](#snippet-94)
        - [Snippet:](#snippet-95)
        - [Snippet:](#snippet-96)
        - [Snippet:](#snippet-97)
        - [Snippet:](#snippet-98)
        - [Snippet:](#snippet-99)
    - [The `protected` Access Modifier](#the-protected-access-modifier)
        - [Snippet:](#snippet-100)
    - [Sealed Classes](#sealed-classes)
        - [Snippet:](#snippet-101)
      - [Challenge: Packing Inventory](#challenge-packing-inventory)
  - [Level 26: Polymorphism](#level-26-polymorphism)
        - [Snippet:](#snippet-102)
        - [Snippet:](#snippet-103)
        - [Snippet:](#snippet-104)
        - [Snippet:](#snippet-105)
        - [Snippet:](#snippet-106)
    - [Abstract Methods and Classes](#abstract-methods-and-classes)
        - [Snippet:](#snippet-107)
    - [New Methods](#new-methods)
        - [Snippet:](#snippet-108)
        - [Snippet:](#snippet-109)
      - [Challenge: Labeling Inventory](#challenge-labeling-inventory)
      - [Challenge: The Old Robot](#challenge-the-old-robot)
  - [Level 27: Interfaces](#level-27-interfaces)
    - [Defining Interfaces](#defining-interfaces)
        - [Snippet:](#snippet-110)
        - [Snippet:](#snippet-111)
    - [Implementing Interfaces](#implementing-interfaces)
        - [Snippet:](#snippet-112)
        - [Snippet:](#snippet-113)
    - [Interfaces and Base Classes](#interfaces-and-base-classes)
        - [Snippet:](#snippet-114)
        - [Snippet:](#snippet-115)
        - [Snippet:](#snippet-116)
    - [Explicit Interface Implementations](#explicit-interface-implementations)
        - [Snippet:](#snippet-117)
        - [Snippet:](#snippet-118)
    - [Default Interface Methods](#default-interface-methods)
        - [Snippet:](#snippet-119)
        - [Snippet:](#snippet-120)
        - [Snippet:](#snippet-121)
      - [Supporting Default Interface Methods](#supporting-default-interface-methods)
      - [Should I Use Default Interface Methods?](#should-i-use-default-interface-methods)
      - [Challenge: Robotic Interface](#challenge-robotic-interface)
  - [Level 28: Structs](#level-28-structs)
        - [Snippet:](#snippet-122)
        - [Snippet:](#snippet-123)
    - [Classes vs. Structs](#classes-vs-structs)
        - [Snippet:](#snippet-124)
        - [Snippet:](#snippet-125)
        - [Snippet:](#snippet-126)
        - [Snippet:](#snippet-127)
        - [Snippet:](#snippet-128)
      - [Rules to Follow When Making Structs](#rules-to-follow-when-making-structs)
        - [Snippet:](#snippet-129)
        - [Snippet:](#snippet-130)
        - [Snippet:](#snippet-131)
        - [Snippet:](#snippet-132)
    - [Built-In Type Aliases](#built-in-type-aliases)
        - [Snippet:](#snippet-133)
        - [Snippet:](#snippet-134)
    - [Boxing and Unboxing](#boxing-and-unboxing)
        - [Snippet:](#snippet-135)
        - [Snippet:](#snippet-136)
      - [Challenge: Room Coordinates](#challenge-room-coordinates)
  - [Level 29: Records](#level-29-records)
    - [Records](#records)
        - [Snippet:](#snippet-137)
        - [Snippet:](#snippet-138)
        - [Snippet:](#snippet-139)
        - [Snippet:](#snippet-140)
      - [Additional Members](#additional-members)
        - [Snippet:](#snippet-141)
      - [Replacing Synthesized Members](#replacing-synthesized-members)
        - [Snippet:](#snippet-142)
      - [Records are Classes](#records-are-classes)
      - [Inheritance](#inheritance)
        - [Snippet:](#snippet-143)
      - [Non-Positional Records](#non-positional-records)
        - [Snippet:](#snippet-144)
    - [`with` Expressions](#with-expressions)
        - [Snippet:](#snippet-145)
    - [Classes, Records, or Structs?](#classes-records-or-structs)
      - [Challenge: War Preparations](#challenge-war-preparations)
  - [Level 30: Generics](#level-30-generics)
    - [The Motivation for Generics](#the-motivation-for-generics)
        - [Snippet:](#snippet-146)
        - [Snippet:](#snippet-147)
        - [Snippet:](#snippet-148)
        - [Snippet:](#snippet-149)
        - [Snippet:](#snippet-150)
        - [Snippet:](#snippet-151)
        - [Snippet:](#snippet-152)
    - [Defining a Generic Type](#defining-a-generic-type)
        - [Snippet:](#snippet-153)
        - [Snippet:](#snippet-154)
        - [Snippet:](#snippet-155)
        - [Snippet:](#snippet-156)
      - [Multiple Generic Type Parameters](#multiple-generic-type-parameters)
        - [Snippet:](#snippet-157)
        - [Snippet:](#snippet-158)
      - [Inheritance and Generic Types](#inheritance-and-generic-types)
        - [Snippet:](#snippet-159)
        - [Snippet:](#snippet-160)
    - [Generic Methods](#generic-methods)
        - [Snippet:](#snippet-161)
        - [Snippet:](#snippet-162)
        - [Snippet:](#snippet-163)
    - [Generic Type Constraints](#generic-type-constraints)
        - [Snippet:](#snippet-164)
        - [Snippet:](#snippet-165)
        - [Snippet:](#snippet-166)
      - [Multiple Constraints](#multiple-constraints)
        - [Snippet:](#snippet-167)
      - [Constraints on Methods](#constraints-on-methods)
        - [Snippet:](#snippet-168)
    - [The `default` Operator](#the-default-operator)
        - [Snippet:](#snippet-169)
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
        - [Snippet:](#snippet-170)
        - [Snippet:](#snippet-171)
        - [Snippet:](#snippet-172)
        - [Snippet:](#snippet-173)
        - [Snippet:](#snippet-174)
        - [Snippet:](#snippet-175)
        - [Snippet:](#snippet-176)
        - [Snippet:](#snippet-177)
      - [Challenge: The Robot Pilot](#challenge-the-robot-pilot)
    - [The `DateTime` Struct](#the-datetime-struct)
        - [Snippet:](#snippet-178)
        - [Snippet:](#snippet-179)
        - [Snippet:](#snippet-180)
        - [Snippet:](#snippet-181)
    - [The `TimeSpan` Struct](#the-timespan-struct)
        - [Snippet:](#snippet-182)
        - [Snippet:](#snippet-183)
        - [Snippet:](#snippet-184)
        - [Snippet:](#snippet-185)
        - [Snippet:](#snippet-186)
    - [Challenge: Time in the Cavern](#challenge-time-in-the-cavern)
    - [The `Guid` Struct](#the-guid-struct)
        - [Snippet:](#snippet-187)
        - [Snippet:](#snippet-188)
    - [The `List<T>` Class](#the-listt-class)
        - [Snippet:](#snippet-189)
      - [Creating List Instances](#creating-list-instances)
        - [Snippet:](#snippet-190)
        - [Snippet:](#snippet-191)
        - [Snippet:](#snippet-192)
      - [Indexing](#indexing)
        - [Snippet:](#snippet-193)
        - [Snippet:](#snippet-194)
      - [Adding and Removing Items from List](#adding-and-removing-items-from-list)
        - [Snippet:](#snippet-195)
        - [Snippet:](#snippet-196)
        - [Snippet:](#snippet-197)
        - [Snippet:](#snippet-198)
        - [Snippet:](#snippet-199)
        - [Snippet:](#snippet-200)
      - [`foreach` Loops](#foreach-loops)
        - [Snippet:](#snippet-201)
        - [Snippet:](#snippet-202)
        - [Snippet:](#snippet-203)
      - [Other Useful Things](#other-useful-things)
        - [Snippet:](#snippet-204)
        - [Snippet:](#snippet-205)
        - [Snippet:](#snippet-206)
      - [Challenge: List of Commands](#challenge-list-of-commands)
    - [The `IEnumerable<T>` Interface](#the-ienumerablet-interface)
        - [Snippet:](#snippet-207)
        - [Snippet:](#snippet-208)
        - [Snippet:](#snippet-209)
        - [Snippet:](#snippet-210)
    - [The `Dictionary<TKey, TValue>` Class](#the-dictionarytkey-tvalue-class)
        - [Snippet:](#snippet-211)
        - [Snippet:](#snippet-212)
        - [Snippet:](#snippet-213)
        - [Snippet:](#snippet-214)
        - [Snippet:](#snippet-215)
        - [Snippet:](#snippet-216)
        - [Snippet:](#snippet-217)
        - [Snippet:](#snippet-218)
      - [Types Besides `string`](#types-besides-string)
        - [Snippet:](#snippet-219)
        - [Snippet:](#snippet-220)
        - [Snippet:](#snippet-221)
      - [Dictionary Keys Should Not Change](#dictionary-keys-should-not-change)
    - [The `Nullable<T>` Struct](#the-nullablet-struct)
        - [Snippet:](#snippet-222)
        - [Snippet:](#snippet-223)
        - [Snippet:](#snippet-224)
        - [Snippet:](#snippet-225)
    - [`ValueTuple` Structs](#valuetuple-structs)
        - [Snippet:](#snippet-226)
        - [Snippet:](#snippet-227)
    - [The `StringBuilder` Class](#the-stringbuilder-class)
        - [Snippet:](#snippet-228)
        - [Snippet:](#snippet-229)


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

**Object-Oriented Principle #2: Information Hiding--Only the object itself should directly access its data.**

##### Snippet: 
```cs
class Rectangle
{
    public float _width;
    public float _height;
    public float _area;

    public Rectangle(float width, float height, float area)
    {
        _width = width;
        _height = height;
        _area = area;
    }
}
```

##### Snippet: 
```cs
Rectangle rectangle = new Rectangle(2, 3, 200000);
```

##### Snippet: 
```cs
public Rectangle(float width, flota height)
{
    _width = width;
    _height = height;
    _area = width * height;
}
```

##### Snippet: 
```cs
Rectangle rectangle = new Rectangle(2, 3);
rectangle._area = 200000;
Console.WriteLine(rectangle._area);
```

### The `public` and `private` Accessibility Modifiers
> * *accessibility level* or *accessibility modifier* - Types and their members indicate how broadly accessible or visible they are. The compiler will then ensure that other code uses it in a compliant manner. Making something more hidden gives you more flexibility to change it later without significantly affecting the rest of the program. Making something less hidden allows it to be used in more places. The `private` accessibility level means something can only be used within the type it's defined in. The `public` accessibility level means it can be used anywhere and is intended for general use. The `protected` accessibility level indicates that something can only be used in the class it is defined in or derived classes. The `internal` accessibility level indicates that it can be used in the assembly it is defined in, but not another. The `private protected` accessibility level indicates that it can only be used in derived classes in the same assembly. The `protected internal` accessibility level can be used in derived classes or the assembly it is defined in.
> * *getter* - A method--especially the **get** part of a property--that returns a value that represents a part of an object's state.

##### Snippet: 
```cs
class Rectangle
{
    private float _width;
    private float _height;
    private float _area;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
        _area = width * height;
    }
}
```

##### Snippet: 
```cs
Rectangle rectangle = new Rectangle(2, 3);
Console.WriteLine(rectangle._area); // ERROR!
```

##### Snippet: 
```cs
public float GetWidth() => _width;
public float GetHeight() => _height;
public float GetArea() => _area;
```

##### Snippet: 
```cs
public void SetWidth(float value)
{
    _width = value;
    _area = width * _height;
}

public void SetHeight(float value)
{
    _height = value;
    _area = _width * _height;
}
```

##### Snippet: 
```cs
class Rectangle
{
    private float _width;
    private float _height;
    private float _area;
    
    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
        _area = _width * _height
    }

    public void GetWidth() => _width;
    public void GetHeight() => _height;
    public float GetArea() => _area;

    public void SetWidth(float value)
    {
        _width = value;
        _area = width * _height;
    }

    public void SetHeight(float value)
    {
        _height = value;
        _area = _width * _height;
    }
}
```

#### The Default Accessibility Level is `private`


#### When to Use `private` and `public`


#### Accessibility Levels as Guidelines, Not Laws


### Abstraction
> * *abstraction* - The object-oriented concept where if a class keeps its inner workings private, those internal workings won't matter to the outside world. It also allows those inner workings to change without affecting the rest of the program.

**Object-Oriented Principle #3: Abstraction--The outside world does not need to know each object or class's inner workings and deal with it as an abstract concept. Abstraction allows the inner workings to change without affecting the outside world.**

##### Snippet: 
```cs
class Rectangle
{
    private float _width;
    private float _height;
    
    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }

    public void GetWidth() => _width;
    public void GetHeight() => _height;
    public float GetArea() => _width * _height;

    public float SetWidth(float value) => _width = value;
    public float SetHeight(float value) => _height = value;
}
```


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

 > * *property* - 
 > * *backing field* or *backing store* - .
 

### The Basics of Properties
##### Snippet: 
```cs
public class Rectangle
{
    private float _width;
    private float _height;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }

    public float GetWidth() => _width;
    public float GetHeight() => _height;
    public float GetArea() => _width * _height;

    public void SetWidth(float value) => _width = value;
    public void SetHeight(float value) => _height = value;
}
```

##### Snippet: 
```cs
private float _width;

private float GetWidth() => _width;

public void SetWidth(float value) => _width = value;
```

##### Snippet: 
```cs
private float _width;

public float Width
{
    get => _width;
    set => _width = value;
}
```

##### Snippet: 
```cs
public float Width
{
    get
    {
        return _width;
    }
    set
    {
        return _width = value;
    }
}
```

##### Snippet: 
```cs
public float Area
{
    get => _width * _height;
}
```

##### Snippet: 
```cs
public float Area => _width * _height;
```

##### Snippet: 
```cs
public class Rectangle
{
    private float _width;
    private float _height;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }

    public float Width
    {
        get => _width;
        set => _width = value;
    }

    public float Height
    {
        get => _height;
        set => _height = value;
    }

    public float Area => _width * _height;
}
```

##### Snippet: 
```cs
Rectangle r = new Rectangle(2, 3);
r.Width = 5;
Console.WriteLine($"A {r.Width}x{r.Height} rectangle has an area of {r.Area}.");
```

##### Snippet: 
```cs
public float Width
{
    get => _width;
    private set => _width = value;
}
```

### Auto-Implemented Properties
> * *auto-implemented property* or *auto property* - .


##### Snippet: 
```cs
public class Player
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value;
    }
}
```

##### Snippet: 
```cs
public class Player
{
    public string Name { get; set; }
}
```

##### Snippet: 
```cs
public string Name { get; set; } = "Player";
```

##### Snippet: 
```cs
public class Rectangle
{
    public float Width { get; set; }
    public float Height { get; set; }
    public float Area => Width * Height;

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }
}
```

### Immutable Fields and Properties
> * *immutable* - .
> * *read-only property* - .

##### Snippet: 
```cs
public class Player
{
    public string Name { get; } = "Player 1";

    public Player(string name)
    {
        Name = name;
    }
}
```

##### Snippet: 
```cs
public class Player
{
    private readonly string _name;

    public player(string name)
    {
        _name = name;
    }
}
```

### Object Initializer Syntax and Init Properties
> * *object initializer syntax* - .


##### Snippet: 
```cs
public class Circle
{
    public float X { get; set; } = 0; // The x-coordinate of the circle's center.
    public float Y { get; set; } = 0; // The y-coordinate of the circle's center.
    public float Radius { get; set; } = 0;
}
```

##### Snippet: 
```cs
Circle circle = new Circle();
circle.Radius = 3;
circle.X = -4;
```

##### Snippet: 
```cs
Circle circle = new Circle() { Radius = 3, X = -4 };
```

##### Snippet: 
```cs
Circle circle = new Circle { Radius = 3, X = -4 };
```

##### Snippet: 
```cs
public class Circle
{
    public float X { get; init; } = 0;
    public float Y { get; init; } = 0;
    public float Radius { get; init; } = 0;
}
```

##### Snippet: 
```cs
Circle circle = new Circle { X = 1, Y = 4, Radius = 3 };

// This would not compile if it were not a comment:
// Circle.X = 2;
```

#### Challenge: The Properties of Arrows


### Anonymous Types
> * *anonymous type* - .

##### Snippet: 
```cs
var anonymous = new { Name = "Steve", Age = 34 };
Console.WriteLine($"{anonymous.Name} is {anonymous.Age} years old.");
```

---

## Level 21: Static
* Static things are owned by the type itself rather than by a single instance (shared across all instances).
* Fields, methods, and constructors can all be static.
* If a class itself is made static, it can only contain static members (`Console`, `Convert`, `Math`).

### Static Members

##### Snippet: 
```cs
public class SomeClass
{
    private int _number;
    public int Number => _number;
}
```


#### Static Fields
> * *static field* or *statuc variable* - .
> * *instance field* - .

##### Snippet: 
```cs
public class Score
{
    private static readonly int PointThreshold = 1000;
    private static readonly int LevelThreshold = 4;

    // ...
}
```

##### Snippet: 
```cs
public bool IsWorthyOfTheHighScoreTable()
{
    if (Points < PointThreshold) return false;
    if (Level < LevelThreshold) return false;
    return true;
}
```

#### Global State
> * *global state* - .

#### Static Properties
##### Snippet: 
```cs
public class Score
{
    public static int PointThreshold { get; } = 1000;
    public static int LevelThreshold { get; } = 4;
    // ...
}
```

#### Static Methods

##### Snippet: 
```cs
public static int CountForPlayer(string playerName, Score[] scores)
{
    int count = 0;
    foreach (Score score in scores)
        if (score.Name == playerName) count++;
    return count;
}
```

##### Snippet: 
```cs
public static Rectangle CreateSquare(float size) => new Rectangle(size, size);
```

#### Static Constructors

##### Snippet: 
```cs
public class Score
{
    public static readonly int PointThreshold;
    public static readonly int LevelThreshold;
    
    static Score()
    {
        PointThreshold = 1000;
        LevelThreshold = 4;
    }

    // ...
}
```


### Static Classes

##### Snippet: 
```cs
public static class Utilities
{
    public static int Helper1() => 4;
    public static double HelperProperty => 4.0;
    public static int AddNumbers(int a, int b) => a + b;
}
```

#### Challenge: Arrow Factories

---

## Level 22: Null References
* Reference types may contain a reference to nothing: `null`, which represents a lack of an object.
* Carefully consider whether null makes sense as an option for a variable and program accordingly.
* Check for null with `x == null`, the null conditional operators `x?.DoStuff()` and `x?[3]`, and use `??` to allow null values to fall back to some other default: `x ?? "empty"`
* If configured right, the compiler can warn you of null-related issues, and you can dictate whether a variable can be null or not (`string` when it is not allowed, `string?` for when it is allowed).

> * *null reference* - .

##### Snippet: 
```cs
string message = null;
Score currentScore = null;
```

##### Snippet: 
```cs
Score score = null;
score.Name = "R2-D2";
```

##### Snippet: 
```cs
Score currentScore = MaybeCreateAScore();
currentScore.Name = "R2-D2";
```

### Checking for Null
> * *null check* - .
> > * *null-conditional operator* - .


##### Snippet: 
```cs
Score currentScore = MaybeCreateAScore();
if (currentScore != null)
  currentScore.Name = "R2-D2";
```

##### Snippet: 
```cs
private string GetTopPlayerName()
{
    return _scoreManager.GetScores()[0].Name;
}
```

##### Snippet: 
```cs
private string GetTopPlayerName()
{
    if (_scoreManager == null) return null;

    Score[] scores = _scoreManager.GetScores();
    if (scores == null) return null;

    Score topScore = scores[0];
    if (topScore == null) return null;

    return topScore.Name;
}
```

##### Snippet: 
```cs
private string GetTopPlayerName()
{
    return _scoreManager?.GetScores()?[0]?.Name;
}
```

##### Snippet: 
```cs
private string GetTopPlayerName()
{
    return _scoreManager?.GetScores()?[0]?.Name ?? "(not found)";
}
```

##### Snippet: 
```cs
private string GetTopPlayerName()
{
    string name = _scoreManager?.GetScores()?[0]?.GetName();
    name ??= "(not found)";
    return name;
}
```

### Choosing When to Allow Null

##### Snippet: 
```cs
string? mightBeNull = null;
string cannotHaveNull = "Text";
```

##### Snippet: 
```cs
bool choice = Console.ReadLine() == "a";
string? mightBeNull = choice ? "a" : "b";
string cannotHaveNull = mightBeNull;
```

##### Snippet: 
```cs
string cannotHaveNull = mightBeNull!;
```

> See more: https://csharpplayersguide.come/articles/nullable-reference-types

---

## Level 23: Object-Oriented Design
* Object-oriented design is figuring out which objects should exist in your program, which classes they should come from, what responsibilities each should have, and how they should work together.
* The design starts with identifying the requirements of what you are building.
* Noun extraction helps get the design process started by identifying concepts and jobs to do in the requirements.
* CRC cards are a tool to think through a design with physical cards for each object, containing the class they belong to, their responsibilities, and their collaborators.
* Object-oriented design is hard, but you don't have to figure out the entire program all at once, nor do you have to get it right the first time.

> * *object-oriented design* - .
> * *software design* - .

### Requirements
> * *requirements gathering* - .


### Designing the Software


#### Noun Extraction
> * *noun extraction* or *noun and verb extraction* - .

#### UML
> * *Unified Modeling Language* or *UML* - .


#### CRC Cards
> * *Class-Responsibility-Collaborator card* or *CRC card* - .


#### Evaluating a Design
* Rule #1: It has to work.
* Rule #2: Prefer designs that convey meaning and intent.
* Rule #3: Designs should not allow for duplication.
* Rule #4: Designs should not have unused or unnecessary elements. 

### Creating Code

##### Snippet: 
```cs
AsteroidsGame game = new AsteroidsGame();
game.Run();

public class Asteroid
{
    public float PositionX { get; private set; }
    public float PositionY { get; private set; }
    public float VelocityX { get; private set; }
    public float VelocityY { get; private set; }

    public Asteroid(float positionX, float positionY, float velocityX, float velocityY)
    {
        PositionX = positionX;
        PositionY = positionY;
        VelocityX = velocityX;
        VelocityY = velocityY;
    }

    public void Update()
    {
        PositionX += VelocityX;
        PositionY += VelocityX;
    }
}

public class AsteroidsGame
{
    private Asteroid[] _asteroids;

    public AsteroidsGame()
    {
        _asteroids = new Asteroid[5];
        _asteroids[0] = new Asteroid(100, 200, -4, -2);
        _asteroids[1] = new Asteroid(-50, 100, -1, +3);
        _asteroids[2] = new Asteroid(0, 0, 2, 1);
        _asteroids[3] = new Asteroid(400, -100, -3, -1);
        _asteroids[4] = new Asteroid(200, -300, 0, 3);
    }

    public void Run()
    {
        while (true)
        {
            foreach (Asteroid asteroid in _asteroids)
                asteroid.Update();
        }
    }
}
```


### How to Collaborate


#### Creating New Objects


#### Constructor Parameters

##### Snippet: 
```cs
public AsteroidsGame(Asteroid[] startingAsteroids)
{
    _asteroids = startingAsteroids;
}
```


#### Method Parameters

##### Snippet: 
```cs
public class AsteroidDriftingSystem
{
    public void Update(Asteroid[] asteroids)
    {
        foreach (Asteroid asteroid in asteroids)
        {
            asteroid.PositionX += Velocity.X;
            asteroid.PositionY += Velocity.Y;
        }
    }
}
```

#### Asking Another Object

##### Snippet: 
```cs
public void Update(AsteroidsGame game)
{
    foreach (Asteroid asteroid in game.Asteroids)
    {
        asteroid.PositionX += asteroid.VelocityX;
        asteroid.PositionY += asteroid.VelocityY;
    }
}
```

#### Supplying the Reference via Property or Method

##### Snippet: 
```cs
public class AsteroidDriftingSystem
{
    public Asteroid[] Asteroids { get; set; }

    public void Update()
    {
        foreach (Asteroid asteroid in Asteroids)
        {
            asteroid.PositionX += asteroid.VelocityX;
            asteroid.PositionY += asteroid.VelocityY;
        }

    }
}
```

#### Static Members

##### Snippet: 
```cs
public class AsteroidsGame
{
    public static AsteroidsGame Current { get; set; }
    // ...
}
```

##### Snippet: 
```cs
AsteroidsGame.Current = new AsteroidsGame();
// ...
```

##### Snippet: 
```cs
public void Update()
{
    foreach (Asteroid asteroid in AsteroidsGame.Current.Asteroids)
    {
        asteroid.PositionX += asteroid.VelocityX;
        asteroid.PositionY += asteroid.VelocityY;
    }
}
```


#### Choices, Choices


### Baby Steps
> * *refactoring* - .



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

> * *inheritance relationship* - .

**Object-Oriented Principle #4 Inheritance--Basing one class on another, retaining the original class's functionality while extending the new class with additional capabilities.**

### Inheritance and the `object` class
> * *base class*, *parent class*, or *superclass* - .
> * *derived class*, *child class*, or *subclass* - .
> * *derive from* - .
> * *extend* - .

##### Snippet: 
```cs
object thing = new object();
```

##### Snippet: 
```cs
Console.WriteLine(thing.ToString());
```

##### Snippet: 
```cs
object a = new object();
object b = a;
object c = new object();
Console.WriteLine(a.Equals(b)); // true
Console.WriteLine(a.Equals(c)); // false
```

##### Snippet: 
```cs
public class Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x; Y = y;
    }
}
```

##### Snippet: 
```cs
Point p1 = new Point(2, 4);
Point p2 = p1;
Console.WriteLine(p1.ToString());
Console.Write(p1.Equals(p2));
```

##### Snippet: 
```cs
object thing = new Point(2, 4);
```

##### Snippet: 
```cs
Console.WriteLine(thing.ToString()); // Safe
Console.WriteLine(thing.X));         // ERROR!
```

### Choosing Base Classes
> * *inheritance hierarchy* - .


##### Snippet: 
```cs
public class GameObject
{
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public float VelocityX { get; set; }
    public float VelocityY { get; set; }

    public void Update()
    {
        PositionX += Velocity.X;
        PositionY += Velocity.Y;
    }
}
```

##### Snippet: 
```cs
public class Asteroid : GameObject
{
    public float Size { get; }
    public float RotationAngle { get; }
}
```

##### Snippet: 
```cs
GameObject[] gameObjects = new GameObject[]
    {
        new Asteroid(), new Asteroid(), new Asteroid(), new Bullet(), new Ship()
    };
```

##### Snippet: 
```cs
foreach (GameObject item in gameObjects)
    item.Update();
```

##### Snippet: 
```cs
Asteroid asteroid = new GameObject(); // ERROR!
Ship ship = new Asteroid();           // ERROR!
```

##### Snippet: 
```cs
public class Scout : Ship { /* ... */ }
public class Bomber : Ship { /* ... */ }
```

### Constructors
##### Snippet: 
```cs
public class GameObject
{
    public GameObject()
    {
        PositionX = 2; PositionY = 4;
    }

    // Properties and other things here.
}

public class Asteroid : GameObject
{
    public Asteroid()
    {
        Rotation = -1;
    }

    // Properties and other things here.
}
```

##### Snippet: 
```cs
public GameObject(float positionX, float positionY, float velocityX, float velocityY)
{
    PositionX = positionX; PositionY = positionY; VelocityX = velocityX; VelocityY = velocityY;
}
```

##### Snippet: 
```cs
public Asteroid() : base(0, 0, 0, 0)
{
}
```

##### Snippet: 
```cs
public Asteroid(float positionX, float positionY, float velocityX, float velocityY)
        : base(positionX, positionY, velocityX, velocityY)
{
}
```


### Casting and Checking for Types
##### Snippet: 
```cs
GameObject gameObject = new Asteroid();
Asteroid asteroid = gameObject; // ERROR!
```

##### Snippet: 
```cs
GameObject gameObject = new Asteroid();
Asteroid asteroid = (Asteroid)gameObject; // Use with caution.
```

##### Snippet: 
```cs
Asteroid probablyAnAsteroid = (Asteroid)CreateAnyObject();
```

##### Snippet: 
```cs
if (gameObject.GetType() == typeof(Asteroid)) { ... }
```

##### Snippet: 
```cs
GameObject gameObject = GetAGameObject();
Asteroid asteroid = gameObject as Asteroid;
```

##### Snippet: 
```cs
if (gameObject is Asteroid asteroid)
{
    ...
}
```

##### Snippet: 
```cs
if (gameObject is Asteroid) { ... }
```

### The `protected` Access Modifier

##### Snippet: 
```cs
public class GameObject
{
    public float PositionX { get; protected set; }
    public float PositionY { get; protected set; }
    public float VelocityX { get; protected set; }
    public float VelocityY { get; protected set; }

    // More members here.
}
```

### Sealed Classes
##### Snippet: 
```cs
public sealed class Asteroid : GameObject
{
    // ...
}
```


#### Challenge: Packing Inventory



---

## Level 26: Polymorphism
* Polymorphism lets a derived class supply its own definition ("override") for a member declared in its base class.
* Marking a member with `virtual` indicates it can be overriden.
* Derived classes override a member by marking it with `override`.
* Classes can leave members unimplemented with `abstract`, but the class must also be `abstract`.

> * *polymorphism* - .


##### Snippet: 
```cs
public class ChessPiece
{
    public int Row { get; set; }
    public int Column { get; set; }

    public bool IsLegalMove(int row, int column) => 
                        IsOnBoard(Row, column) && !IsCurrentLocation(row, column);
    
    protected bool IsOnBoard(int row, int column) =>
                        row >= 0 && row < 8 && column >= 0 && column < 8;
    
    protected bool IsCurrentLocation(int row, int column) =>
                        row == Row && column == Column;
}
```

##### Snippet: 
```cs
public class King : ChessPiece
{
    public bool IsLegalKingMove(int row, int column)
    {
        if (!IsLegalMove(row, column)) return false;

        // Moving more than one row or column is not a legal king move.
        if (Math.Abs(row - Row) > 1) return false;
        if (Math.Abs(column - Column) > 1) return false;

        return true;
    }
}
```

**Object-Oriented Principle #5 Polymorphism--Derived classes can override methods from the base class. The correct version is determined at runtime, so you will get different behavior depending on the object's class.**

##### Snippet: 
```cs
ChessPiece p1 = new Pawn();
ChessPiece p2 = new King();

Console.WriteLine(p1.IsLegalMove(2, 2));
Console.WriteLine(p2.IsLegalMove(2, 2));
```

##### Snippet: 
```cs
public virtual bool IsLegalMove(int row, int column) =>
                    IsOnBoard(Row, column) && !IsCurrentLocation(row, column);
```

##### Snippet: 
```cs
public override bool IsLegalMove(int row, int column)
{
    if (!base.IsLegalMove(row, column)) return false;

    // Moving more than one row or column is not a legal king move.
    if (Math.Abs(row - Row) > 1) return false;
    if (Math.Abse(column - Column) > 1) return false;

    return true;
}
```


### Abstract Methods and Classes
> * *abstract method* - .

##### Snippet: 
```cs
public abstract class ChessPiece
{
    public abstract bool IsLegalMove(int targetRow, int targetColumn);

    // ...
}
```


### New Methods

##### Snippet: 
```cs
public class Base
{
    public int Method() => 0;
}

public class Derived : Base
{
    public new int Method() => 4;
}
```

##### Snippet: 
```cs
Derived d = new Derived();
Base b = d;

Console.WriteLine(d.Method() + " " + b.Method());
```

#### Challenge: Labeling Inventory


#### Challenge: The Old Robot



---

## Level 27: Interfaces
* An interface is a type that defines a contract or role that objects can fulfill or implement: `public interface ILevelBuilder { Level BuildLevel(int levelNumber); }`
* Classes can implement interfaces: `public class LevelBuilder : ILevelBuilder { public Level BuildLevel(int levelNumber) => new Level(); }`
* A class can have only one base class but can implement many interfaces.

> * *interface* - .


### Defining Interfaces
##### Snippet: 
```cs
public enum TerrainType { Desert, Forests, Mountains, Pastures, Fields, Hills }

public class Level
{
    public int Width { get; }
    public int Height { get; }
    public TerrainType GetTerrainAt(int row, int column) { /* ... */ }
}
```

##### Snippet: 
```cs
public interface ILevelBuilder
{
    Level BuildLevel(int levelNumber);
}
```


### Implementing Interfaces

##### Snippet: 
```cs
public class FixedLevelBuilder : ILevelBuilder
{
    public Level BuildLevel(int levelNumber)
    {
        Level level = new Level(10, 10, TerrainType.Forests);

        level.SetTerrainAt(2, 4, TerrainType.Mountains);
        level.SetTerrainAt(2, 5, TerrainType.Mountains);
        level.SetTerrainAt(6, 1, TerrainType.Desert);

        return level;
    }
}
```

##### Snippet: 
```cs
ILevelBuilder levelBuilder = LocateLevelBuilder();

int currentLevel = 1;

while (true)
{
    Level level = levelBuilder.BuildLevel(currentLevel);
    RunLevel(level);
    currentLevel++;
}
```

### Interfaces and Base Classes

##### Snippet: 
```cs
public class MySqlDatabaseLevelBuilder : BasicDatabaseLevelBuilder, ILevelBuilder { ... }
```

##### Snippet: 
```cs
public class SomeClass : ISomeInterface1, ISomeInterface2 { ... }
```

##### Snippet: 
```cs
public interface IBroaderInterface : INarrowInterface { ... }
```

### Explicit Interface Implementations

> * *explicit interface implementation* - .

##### Snippet: 
```cs
public interface IBomb { void BlowUp(); }
public interface IBallooon { void BlowUp(); }

public class ExplodingBalloon : IBomb, IBalloon
{
    public void BlowUp() { ... }
}
```

##### Snippet: 
```cs
public class ExplodingBalloon : IBomb, IBalloon
{
    void IBomb.BlowUp() { Console.WriteLine("Kaboom!"); }
    void IBalloon.BlowUp() { Console.WriteLine("Whoosh"); }
}
```

### Default Interface Methods

##### Snippet: 
```cs
public interface ILevelBuilder
{
    Level BuildLevel(int levelNumber);
    int Count { get; }
}
```

##### Snippet: 
```cs
public interface ILevelBuilder
{
    Level BuildLevel(int levelNumber);
    int Count { get; }
    Level[] BuildAllLevels();
}
```

##### Snippet: 
```cs
public interface ILevelBuilder
{
    Level BuildLevel(int levelNumber);
    int Count { get; }

    Level[] BuildAllLevels()
    {
        Level[] levels = new Level[Count];

        for (int index = 1; index <= Count; index++)
            levels[index - 1] = BuildLevel(index);

        return levels;
    }
}
```


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

##### Snippet: 
```cs
public struct Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}
```

##### Snippet: 
```cs
Point p1 = new Point(2, 4);
Console.WriteLine($"{p1.X}, {p1.Y}");
```

### Classes vs. Structs

##### Snippet: 
```cs
public struct CircleStruct
{
    public double X { get; }
    public double Y { get; }
    public double Radius { get; }

    public CircleStruct(double x, double y, double radius)
    {
        X = x; Y = y; Radius = radius;
    }
}

public class CircleClass
{
    public double X { get; }
    public double Y { get; }
    public double Radius { get; }

    public CircleClass(double x, double y, double radius)
    {
        X = x; Y = y; Radius = radius;
    }
}
```

##### Snippet: 
```cs
CircleClass[] classes = new CircleClass[10000];
CircleStruct[] structs = new CircleStruct[10000];
```

##### Snippet: 
```cs
for (int index = 0; index < 10000; index++)
{
    classes[index] = new CircleClass(1, -2, 10);
    structs[index] = new CircleStruct(1, -2, 10);
}
```

##### Snippet: 
```cs
public void DisplayCircles()
{
    for (int time = 0; time < 10000; time++)
    {
        CircleClass circleClass = new CircleClass(1, 2, -10);
        DisplayCircle(circleClass);
    }
}

public void DisplayCircle(CircleClass c) =>
                    Console.WriteLine($"[Circle X={c.X} Y={c.Y} R={c.Radius}]");
```

##### Snippet: 
```cs
public void DisplayCircles()
{
    for (int time = 0; time < 10000; time++)
    {
        CircleStruct circleStruct = new CircleStruct(1, 2, -10);
        DisplayCircle(circleStruct);
    }
}

public void DisplayCircle(CircleStruct c) =>
                    Console.WriteLine($"[Circle X={c.X} Y={c.Y} R={c.Radius}]");
```

#### Rules to Follow When Making Structs

##### Snippet: 
```cs
public void ShiftLeft(Point p) => p.X -= 10;
```

##### Snippet: 
```cs
public Point ShiftLeft(Point p) => new Point(p.X - 10, p.Y);
```

##### Snippet: 
```cs
Point somePoint = new Point(5, 5);
somePoint = ShiftLeft(somePoint);
```

##### Snippet: 
```cs
public class LineSegment
{
    private readonly Point _start;
    private readonly Point _end;

    public LineSegment() { }

    // ...
}
```

### Built-In Type Aliases

##### Snippet: 
```cs
Int32 x = new Int32();
Int32 y = 0;            // Or combined.
int z = new Int32();    // Or combined another way. It's all the same thing.
int w = new int();      // Yet another way...
```

##### Snippet: 
```cs
int.Parse("4");
Int32.Parse("4");
```

### Boxing and Unboxing

> * *box* - .
> * *boxing conversion* - .
> * *unboxing conversion* - .

##### Snippet: 
```cs
object thing = 3;
int number = (int)thing;
```

##### Snippet: 
```cs
ISomeInterface thing = new SomeStruct();
SomeStruct s = (SomeStruct)thing;
```

#### Challenge: Room Coordinates



---

## Level 29: Records
* Records are compact notation to represent objects that are data-centric, immutable, and with value semantics: `public record Point(float X, float Y);`
* You can add additional members to a record or replace the synthesized members: `public record Rectangle(float Width, float Height) { public float Area => Width * Height; }`
* A `with` expression lets you create a new record object from an existing one with tweaks: `Point modified = p with { X = -2 };`

### Records

> * *record* - .

##### Snippet: 
```cs
public record Point(float X, float Y); // That's all.
```

##### Snippet: 
```cs
public class Point
{
    public float X { get; init; }
    public float Y { get; init; }

    public Point(float x, float y)
    {
        X = x; Y = y;
    }
}
```

##### Snippet: 
```cs
Point a = new Point(2, -1);
Point b = new Point(2, -1);
Console.WriteLine(a == b);
```

##### Snippet: 
```cs
Point a = new Point(2, -1);
(float u, float v) = a;
```

#### Additional Members

##### Snippet: 
```cs
public record Rectangle(float Width, float Height)
{
    public float Area => Width * Height;
}
```

#### Replacing Synthesized Members

##### Snippet: 
```cs
public record Point(float , float Y)
{
    public float X { get; set; }
    public override string ToString() => $"({X}, {Y})";
}
```


#### Records are Classes


#### Inheritance

##### Snippet: 
```cs
public record Point(float X, float Y);
public record ColoredPoint(Color Color, float X, float Y) : Point(X, Y);
```

#### Non-Positional Records

> * *positional record* - .


##### Snippet: 
```cs
public record Point
{
    public float X { get; init; }
    public float Y { get; init; }
}
```


### `with` Expressions

##### Snippet: 
```cs
Point original = new Point(-1, 2);
Point updated = original with { X = 10 };
```


### Classes, Records, or Structs?


#### Challenge: War Preparations



---

## Level 30: Generics
* Generics solve the problem of needing to make classes or methods that would differ only by the types they use. Generics leave placeholders for types that can be filled in when used.
* Defining a generic class: `public class List<T> { public T GetItemAt(int index) { ... } ... }`
* You can also make generic methods and generic types with multiple type parameters.
* Constraints allow you to limit what can be used for a generic type argument while enabling you to know more about the types being used: `class List<T> where T : ISomeInterface { }`

> * *generics (generic types and generic methods)* - .


### The Motivation for Generics

##### Snippet: 
```cs
int[] numbers = new int[] { 1, 2, 3 };
numbers = AddToArray(numbers, 4);

int[] AddToArray(int[] input, int newNumber)
{
    int[] output = new int[input.Length - 1];

    for (int index = 0; index < input.Length; index++)
        output[index] = input[index];

    output[^1] = newNumber;

    return output;
}
```

##### Snippet: 
```cs
public class ListOfNumbers
{
    private int[] _numbers = new int[0];

    public int GetItemAt(int index) => _numbers[index];
    public void SetItemAt(int index, int value) => _numbers[index] = value;

    public void Add(int newValue)
    {
        int[] updated = new int[_numbers.Length + 1];

        for (int index = 0; index < _numbers.Length; index++)
            updated[index] = _numbers[index];

        updated[^1] = newValue;

        _numbers = updated;
    }
}
```

##### Snippet: 
```cs
ListOfNumbers numbers = new ListOfNumbers();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
Console.WriteLine(numbers.GetItemAt(2));
```

##### Snippet: 
```cs
public class ListOfStrings
{
    private string[] _strings = new string[0];

    public string GetItemAt(int index) => _strings[index];
    public void SetItemAt(int index, string value) => _strings[index] = value;

    public void Add(string newValue) { /* Details skipped */ }
}
```

##### Snippet: 
```cs
public class List
{
    private object[] _items = new object[0];
    public object GetItemAt(int index) => _items[index];
    public void SetItemAt(int index, object value) => _items[index] = value;

    public void Add(object newValue) { /* Details skipped */ }
}

List numbers = new List();
numbers.Add(1);
numbers.Add(2);

List words = new List();
words.Add("Hello");
words.Add("World");
```

##### Snippet: 
```cs
int first = (int)numbers.GetItemAt(0);
```

##### Snippet: 
```cs
List numbers = new List();
numbers.Add(1);
numbers.Add("Hello");
```

### Defining a Generic Type

> * *generic type parameter* - .
> * *generic type argument* - .



##### Snippet: 
```cs
public class List<T>
{
    private T[] _items = new T[0];

    public T GetItemAt(int index) => _items[index];
    public void SetItemAt(int index, T value) => _items[index] = value;

    public void Add(T newValue)
    {
        T[] updated = new T[_items.Length + 1];

        for (int index = 0; index < _items.Length; index++)
            updated[index] = _items[index];

        updated[^1] = newValue;

        _items = updated;
    }
}
```

##### Snippet: 
```cs
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
```

##### Snippet: 
```cs
List<string> words = new List<string>();
words.Add("Hello");
words.Add("World");
```

##### Snippet: 
```cs
words.Add(1); // ERROR!
```

#### Multiple Generic Type Parameters

##### Snippet: 
```cs
public class Pair<TFirst, TSecond>
{
    public TFirst First { get; }
    public TSecond Second { get; }

    public Pair(TFirst first, TSecond second)
    {
        First = first;
        Second = second;
    }
}
```

##### Snippet: 
```cs
Pair<string, double> namedNumber = new Pair<string, double>("pi", 3.1415926535);
Console.WriteLine($"{namedNumber.First} is {namedNumber.Second}");
```


#### Inheritance and Generic Types
> * *open* - .
> * *closed* - .

##### Snippet: 
```cs
public class FancyList<T> : List<T>
{ ... }
```

##### Snippet: 
```cs
public class Polygon : List<Point>
{ ... }
```

### Generic Methods

##### Snippet: 
```cs
public static List<T> Repeat<T>(T value, int times)
{
    List<T> collection = new List<T>();
    
    for (int index = 0; index < times; index++)
        collection.Add(value);

    return collection;
}
```

##### Snippet: 
```cs
List<string> words = Repeat<string>("Alright", 3);
List<int> zeroes = Repeat<int>(0, 100);
```

##### Snippet: 
```cs
List<string> words = Repeat("Alright", 3);
```


### Generic Type Constraints

##### Snippet: 
```cs
public abstract class GameObject
{
    public int ID { get; }
    // ...
}
```

##### Snippet: 
```cs
public class IDList<T> where T : GameObject
{
    private T[] items = new T[0];

    public T GetItemByID(int idToFind)
    {
        foreach (T item in items)
            if (item.ID == idToFind)
                return item;
    
        return null;
    }

    public void Add(T newValue) { /* ... */ }
}
```

##### Snippet: 
```cs
public class GenericType<T, U> where T : GameObject
                               where U : Asteroid
{
    // ...
}
```


#### Multiple Constraints

##### Snippet: 
```cs
public class Factory<T> where T : GameObject, new() { ... }
```

#### Constraints on Methods

##### Snippet: 
```cs
public static List<T> Repeat<T>(T value, int times) where T : class { ... }
```

### The `default` Operator

##### Snippet: 
```cs
public Pair()
{
    First = default; // Or default(TFirst), if the compiler cannot infer it.
    Second = default; // Or default(TSecond), if the compiler cannot infer it.
}
```


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

> * *Base Class Library (BCL)* - .


### The `Random` Class

> * *pseudo-random number generation* - .


##### Snippet: 
```cs
Random random = new Random();     // Assumes you have a `using System;` directive.
Console.WriteLine(random.Next());
```

##### Snippet: 
```cs
Console.WriteLine(random.Next(6));
```

##### Snippet: 
```cs
Console.WriteLine($"Rolling a six-sided die: {random.Next(6) + 1}");
```

##### Snippet: 
```cs
Console.WriteLine(random.Next(18, 22));
```

##### Snippet: 
```cs
Console.WriteLine(random.NextDouble());
```

##### Snippet: 
```cs
Console.WriteLine(random.NextDouble() * 10);
```

##### Snippet: 
```cs
Console.WriteLine(random.NextDouble() * 20 - 10);
```

##### Snippet: 
```cs
Random random = new Random(3445);
Console.WriteLine(random.Next());
```

#### Challenge: The Robot Pilot


### The `DateTime` Struct

##### Snippet: 
```cs
DateTime time1 = new DateTime(2021, 12, 31);
DateTime time2 = new DateTime(2021, 12, 31, 23, 59, 55);
```

##### Snippet: 
```cs
DateTime nowLocal = DateTime.Now;
DateTime nowUtc   = DateTime.UtcNow;
```

##### Snippet: 
```cs
DateTime time = DateTime.Now;
if (time.Month == 10) Console.WriteLine("Happy Halloween");
else if (time.Month == 4 && time.Day == 1) Console.WriteLine("April Fools!");
```

##### Snippet: 
```cs
DateTime tomorrow = DateTime.Now.AddDays(1);
```

### The `TimeSpan` Struct

##### Snippet: 
```cs
TimeSpan timeSpan1 = new TimeSpan(1, 30, 0); // 1 hour, 30 minutes, 0 seconds.
TimeSpan timeSpan2 = new TimeSpan(2, 12, 0, 0); // 2 days, 12 hours.
TimeSpan timeSpan3 = new TimeSpan(0, 0, 0, 0, 500); // 500 milliseconds.
TimeSpan timeSpan4 = new TimeSpan(10); // 10 "ticks" == 1 microsecond
```

##### Snippet: 
```cs
TimeSpan aLittleWhile = TimeSpan.FromSeconds(3.5);
TimeSpan quiteAWhile = TimeSpan.FromHours(1.21);
```

##### Snippet: 
```cs
TimeSpan timeLeft = new TimeSpan(1, 30, 0);
Console.WriteLine($"{timeLeft.Days}d {timeLeft.Hours}h {timeLeft.Minutes}.m");
```

##### Snippet: 
```cs
TimeSpan timeRemaining = new TimeSpan(1, 30, 0);
Console.WriteLine(timeRemaining.TotalHours); // 1.5
Console.WriteLine(timeRemaining.TotalMinutes); // 90
```

##### Snippet: 
```cs
DateTime eventTime = new DateTime(2021, 12, 4, 5, 29, 0) // 4 Dec 2021 at 5:29am
TimeSpan timeLeft = eventTime - DateTime.Now;

// 'TimeSpan.Zero' is no time at all.
if (timeLeft > TimeSpan.Zero)
    Console.WriteLine($"{timeLeft.Days}d {timeLeft.Hours}h {timeLeft.Minutes}m");
else
    Console.WriteLine("This event has passed.");
```

### Challenge: Time in the Cavern


### The `Guid` Struct

##### Snippet: 
```cs
Guid id = Guid.NewGuid();
```

##### Snippet: 
```cs
Guid id = new Guid("10A24EC2-3008-4678-AD86-FCCCDA8CE868");
```

### The `List<T>` Class

##### Snippet: 
```cs
using System.Collections.Generic;
```

#### Creating List Instances

##### Snippet: 
```cs
List<int> numbers = new List<int>();
```

##### Snippet: 
```cs
List<int> numbers = new List<int>() { 1, 2, 3 };
```

##### Snippet: 
```cs
List<int> numbers = new List<int> { 1, 2, 3 };
```

#### Indexing

##### Snippet: 
```cs
List<string> words = new List<string>() { "apple", "banana", "carrot", "durian" };
Console.WriteLine(words[2]);
```

##### Snippet: 
```cs
words[0] = "avocado";
```

#### Adding and Removing Items from List

##### Snippet: 
```cs
List<string> words = new List<string>();
words.Add("apple");
```

##### Snippet: 
```cs
List<string> words = new List<string>() { "apple", "banana", "durian" };
words.Insert(2, "carrot");
```

##### Snippet: 
```cs
List<string> words = new List<string>();
words.AddRange(new string[] { "apple", "durian" });
words.InsertRange(1, new string[] { "banana", "carrot" });
```

##### Snippet: 
```cs
List<string> words = new List<string>() { "apple", "banana", "carrot", "durian" };
words.Remove("banana");
```

##### Snippet: 
```cs
words.RemoveAt(0);
```

##### Snippet: 
```cs
words.Clear();
```

#### `foreach` Loops

##### Snippet: 
```cs
foreach (Ship ship in ships)
    ship.Update();
```

##### Snippet: 
```cs
for (int index = 0; index < ships.Count; index++)
{
    Ship ship = ships[index];
    ship.Update();
}
```

##### Snippet: 
```cs
for (int index = 0; index < ships.Count; index++)
{
    Ship ship = ships[index];
    ship.Update();
    if (ship.IsDead)
    {
        ships.Remove(ship);
        index--;
    }
}
```

#### Other Useful Things

##### Snippet: 
```cs
Console.WriteLine(words.Count);
```

##### Snippet: 
```cs
bool hasApples = words.Contains("apple");
if (hasApples)
    Console.WriteLine("Apples are already on the shopping list!");
```

##### Snippet: 
```cs
int index = words.IndexOf("apple");
```

#### Challenge: List of Commands


### The `IEnumerable<T>` Interface

##### Snippet: 
```cs
public interface IEnumerable<T>
{
    IEnumerator<T> GetEnumerator();
}
```

##### Snippet: 
```cs
public interface IEnumerator<T>
{
    T Current { get; }
    bool MoveNet();
    void Reset();
}
```

##### Snippet: 
```cs
List<string> words = new List<string> { "apple", "banana", "carrot", "durian" };

foreach (string word in words)
    Console.WriteLine(word);
```

##### Snippet: 
```cs
List<string> words = new List<String> { "apple", "banana", "carrot", "durian" };

IEnumerator<string> iterator = words.GetEnumerator();

while (iterator.MoveNext())
{
    string word = iterator.Current;
    Console.WriteLine(word);
}
```

### The `Dictionary<TKey, TValue>` Class

> * *dictionary*, *associative array*, or *map* - .


##### Snippet: 
```cs
Dictionary<string, string> dictionary = new Dictionary<string, string>();
```

##### Snippet: 
```cs
dictionary["battleship"] = "a large warship with big guns";
dictionary["cruiser"] = "a fast but large warship";
dictionary["submarine"] = "a ship capable of moving under the water's surface";
```

##### Snippet: 
```cs
Console.WriteLine(dictionary["battleship"]);
```

##### Snippet: 
```cs
dictionary["carrier"] = "a ship that carries stuff";
dictionary["carrier"] = "a ship that serves as a floating runway for aircraft";
Console.WriteLine(dictionary["carrier"]);
```

##### Snippet: 
```cs
Console.WriteLine(dictonary["gunship"]); // ERROR! KeyNotFoundException
```

##### Snippet: 
```cs
if (dictionary.ContainsKey("gunship"))
    Console.WriteLine(dictionary["gunship"]);
```

##### Snippet: 
```cs
Console.WriteLine(dictionary.GetValueOrDefault("gunship", "unknown"));
```

##### Snippet: 
```cs
dictinary.Remove("battleship");
```

#### Types Besides `string`

##### Snippet: 
```cs
var dictionary = new Dictionary<string, WordDefinition>();
```

##### Snippet: 
```cs
Dictionary<int, GameObject> gameObjects = new Dictionary<int, GameObject>();
```

##### Snippet: 
```cs
gameObjects[ship.ID] = ship;
```



#### Dictionary Keys Should Not Change

> * *hash code* - .

### The `Nullable<T>` Struct

##### Snippet: 
```cs
Nullable<int> maybeNumber = new Nullable<int>(3);
Nullable<int> another = new Nullable<int>();
```

##### Snippet: 
```cs
if (maybeNumber.HasValue)
    Console.WriteLine($"The number is {maybeNumber.Value}.");
else
    Console.WriteLine("The number is missing.");
```

##### Snippet: 
```cs
int? maybeNumber = 3;
int? another = null;
```

##### Snippet: 
```cs
maybeNumber += 2;
```

### `ValueTuple` Structs

##### Snippet: 
```cs
(string, int, int) score = ("R2-D2", 12420, 15);
```

##### Snippet: 
```cs
ValueTuple<string, int, int> score = 
                new ValueTuple<string, int, int>("R2-D2", 12420, 15);
```


### The `StringBuilder` Class

##### Snippet: 
```cs
string text = "";
while (true)
{
    string input = Console.ReadLine();
    if (input == "") break;
    text += input;
    text += " ";
}
Console.WriteLine(text);
```

##### Snippet: 
```cs
StringBuilder text = new StringBuilder();
while (true)
{
    string input = Console.ReadLine();
    if (input == "") break;
    text.Append(input);
    text.Append(" ");
}
Console.WriteLine(text.ToString());
```

