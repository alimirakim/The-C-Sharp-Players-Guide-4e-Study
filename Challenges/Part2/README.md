<!-- TODO Add speedrun notes for these chaptgers -->
## Part 2: Object-Oriented Programming

Check [x] each chapter as you go to track progress! :)
15. [ ] Object-Oriented Concepts
16. [ ] Enumerations
17. [ ] Tuples
18. [ ] Classes
19. [ ] Information Hiding
20. [ ] Properties
21. [ ] Static
22. [ ] Null References
23. [ ] Object-Oriented Design
24. [ ] The Catacombs of the Class
25. [ ] Inheritance
26. [ ] Polymorphism
27. [ ] Interfaces
28. [ ] Structs
29. [ ] Records
30. [ ] Generics
31. [ ] The Fountain of Objects
32. [ ] Some Useful Types

## Level 15: Object-Oriented Concepts
* Object-oriented programming allows you to separate large programs into individual components called objects, each responsible for a small slice of the overall program.
* Objects belong to a class, which defines a category of things with the same structure and capabilities.
* Building custom types is a powerful tool for building large programs.

---

## Level 16: Enumerations
* An enumeration is a custom type that names off the set of allowed values: `enum Season { Winter, Spring, Summer, Fall }`
* Define your enumerations after your main method and other methods or in a separate file.
* After defining an enumeration, you can use it for a variable's type: `Season now = Seasons.Winter;`

---

## Level 17: Tuples
* Tuples combine multiple elements into a single bundle: `(double, double) point = (2, 4);`
* You can give (ephemeral) names to tuple elements, which can be used later: `(double x, double y) point = (2, 4);`
* Tuples can be used like any other variable type, including using them as parameters and return values.
* Deconstruction unpacks tuples into multiple variables: `(double x double y) = MakePoint();`
* Two tuple values are equal if their corresponding items are all equal.

---

## Level 18: Classes
* Classes are the most powerful way to define new types.
* A class bundles together data (fields) and operations on that data (methods): `class Score { public int points; public int level; public void Method() { } }`
* Constructors define how new instances are created: `public Score(int p) { points = p; }`
* Classes are reference types.

---

## Level 19: Information Hiding
* Information hiding is where some details are hidden from the outside world while still presenting a public boundary that the outside world can still work with.
* Class members should be marked `public` or `private` to indicate which of the two is intended.
* Data (instance variables) should be `private` in nearly all cases.
* Abstraction: when things are private, they can change without the outside world being affected. The outside world depends on the public parts, while anything private can change without problems.
* A third level is `internal`, which is for things meant to be used only inside the project.
* Classes and other types also have their own accessibility level: `public class X { ... }`

---

## Level 20: Properties
* Properties give you field-like access while still protecting data with methods: `public float Width { get => width; set => width = value; }`. To use a property: `rectangle.Width = 3;`
* Auto-properties are for when no extra logic is needed: `public float Width { get; set; }`
* Properties can be read-only, only settable in a constructor: `public float Width { get; }`
* Fields can also be read-only: `private readonly float _width = 3;`
* With properties, objects can be initialized using object initializer syntax: `new Rectangle() { Width = 2, Height = 3 }`
* An `init` accessor is like a setter but only usable in object initializer syntax. `public float Width { get; init; }`

---

## Level 21: Static
* Static things are owned by the type itself rather than by a single instance (shared across all instances).
* Fields, methods, and constructors can all be static.
* If a class itself is made static, it can only contain static members (`Console`, `Convert`, `Math`).

---

## Level 22: Null References
* Reference types may contain a reference to nothing: `null`, which represents a lack of an object.
* Carefully consider whether null makes sense as an option for a variable and program accordingly.
* Check for null with `x == null`, the null conditional operators `x?.DoStuff()` and `x?[3]`, and use `??` to allow null values to fall back to some other default: `x ?? "empty"`
* If configured right, the compiler can warn you of null-related issues, and you can dictate whether a variable can be null or not (`string` when it is not allowed, `string?` for when it is allowed).

---

## Level 23: Object-Oriented Design
* Object-oriented design is figuring out which objects should exist in your program, which classes they should come from, what responsibilities each should have, and how they should work together.
* The design starts with identifying the requirements of what you are building.
* Noun extraction helps get the design process started by identifying concepts and jobs to do in the requirements.
* CRC cards are a tool to think through a design with physical cards for each object, containing the class they belong to, their responsibilities, and their collaborators.
* Object-oriented design is hard, but you don't have to figure out the entire program all at once, nor do you have to get it right the first time.

---

## Level 24: The Catacombs of the Class
* This level is made entirely of problems to work through to gain more practice creating classes and doing object-oriented design, and culminates in building the game of Tic-Tac-Toe from scratch.

---

## Level 25: Inheritance
* Inheritance lets you derive new classes based on existing ones. The new class inherits everything except constructors from the base class. `class Derived : Base { ... }`
* Classes derive from `object` by default, and everything eventually derives from `object` even if another class is explicitly stated.
* Constructors in a derived class must call out the constructor they are using from the base class unless they are using the parameterless constructor (if it exists): `public Derived(int x) : base(x) { ... }`
* Derives class instances can be used where the base class is stated: `Base x = new Derived();`
* The `protected` accessibility modifier makes things accessible in the class and any derived classes.

---

## Level 26: Polymorphism
* Polymorphism lets a derived class supply its own definition ("override") for a member declared in its base class.
* Marking a member with `virtual` indicates it can be overriden.
* Derived classes override a member by marking it with `override`.
* Classes can leave members unimplemented with `abstract`, but the class must also be `abstract`.

---

## Level 27: Interfaces
* An interface is a type that defines a contract or role that objects can fulfill or implement: `public interface ILevelBuilder { Level BuildLevel(int levelNumber); }`
* Classes can implement interfaces: `public class LevelBuilder : ILevelBuilder { public Level BuildLevel(int levelNumber) => new Level(); }`
* A class can have only one base class but can implement many interfaces.

---

## Level 28: Structs
* A struct is a custom type that defines a simple data structure without complex behavior: `public struct Point { ... }`. Structs are not focused on behavior but can have properties and methods.
* Compared to classes: structs are value types, automatically have value semantics, and cannot be used in inheritance.
* Make structs small, immutable, and ensure the default value is legitimate.
* All the built-in types are aliases for other Structs (and a few classes). For example, `int` is shorthand for `System.Int32`.
* Value types can be stored in reference-typed variables (`object thing = 3;`) but will cause the value to be `"boxed"` and placed on the heap.

---

## Level 29: Records
* Records are compact notation to represent objects that are data-centric, immutable, and with value semantics: `public record Point(float X, float Y);`
* You can add additional members to a record or replace the synthesized members: `public record Rectangle(float Width, float Height) { public float Area => Width * Height; }`
* A `with` expression lets you create a new record object from an existing one with tweaks: `Point modified = p with { X = -2 };`

---

## Level 30: Generics
* Generics solve the problem of needing to make classes or methods that would differ only by the types they use. Generics leave placeholders for types that can be filled in when used.
* Defining a generic class: `public class List<T> { public T GetItemAt(int index) { ... } ... }`
* You can also make generic methods and generic types with multiple type parameters.
* Constraints allow you to limit what can be used for a generic type argument while enabling you to know more about the types being used: `class List<T> where T : ISomeInterface { }`

---

## Level 31: The Fountain of Objects
* This level contains no new C# information. It is a large multi-part program to complete to hone your programming skills.

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