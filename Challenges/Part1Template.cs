
// PART 1: BASICS

// TOC - Comment these out as needed as you finish each challenge.
KnowledgeCheckCSharp();
HelloWorld();
WhatComesNext();
MakingsOfAProgrammer();
ConsolasAndTelim();
TheThingNamer3000();
KnowledgeCheckVariables();
TheVariableShop();
TheVariableShopReturns();
KnowledgeCheckTypeSystem();
TheTriangleFarmer();
TheFourSistersAndTheDuckbear();
TheDominionOfKings();
TheDefenseOfConsolas();
RepairingTheClockTower();
Watchtower();
BuyingInventory();
DiscountingInventory();
ThePrototype();
TheMagicCannon();
TheReplicatorOfDTo();
TheLawsOfFreach();
TakingANumber();
Countdown();
KnowledgeCheckMemory();
HuntingTheManticore();

// UTILITIES
void WriteTitle(string title)
{
  string divider = "";
  for (int i = 0; i < title.Length; i++)
    divider += "-";

  Console.WriteLine("");
  Console.WriteLine(title);
  Console.WriteLine(divider);
}

// *************************************************************************************************

///<summary>
/// LEVEL 1: The C# Programming Language 
/// Knowledge Check: C# 
/// </summary>
void KnowledgeCheckCSharp()
{
  WriteTitle("Knowledge Check - C#");
  
  
}

// *************************************************************************************************

/// LEVEL 2: Getting an IDE
/// Challenge 1/1: Install Visual Studio
/// Install Visual Studio Community edition (or any other IDE) and get it ready to start programming.

/// <summary>
/// LEVEL 3: Hello World! Your First Program
/// Challenge 1/4: Hello World!
/// TODO
///
/// **Objectives:**
/// [] Create a new Hello World program from the C# Console Application template, targeting .NET 5.
/// [] Run your program using any of the three methods described above.
/// </summary>
void HelloWorld()
{
  WriteTitle(nameof(HelloWorld));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 3: Hello World! Your First Program
/// Challenge 2/4: What Comes Next
/// TODO
/// 
/// **Objectives:**
/// [] Replace the file's contents with a `using System;` and `Console.WriteLine("Hello World!");`
/// [] Change your program to say something (anything!) besides "Hello World!".
/// </summary>
void WhatComesNext()
{
  WriteTitle(nameof(WhatComesNext));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 3: Hello World! Your First Program
/// Challenge 3/4: Makings of a Programmer
/// 
/// **Objectives:**
/// [] Make a program with 5 `Console.WriteLine` statements in it.
/// [] **Answer this question:** How many statements do you think a program can contain?
/// 
/// </summary>
void MakingsOfAProgrammer()
{
  WriteTitle(nameof(MakingsOfAProgrammer));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 3: Hello World! Your First Program
/// Challenge 4/4: Consolas and Telim
/// TODO
/// 
/// **Sample Program:**
///   Bread is ready.
///   Who is the bread for?
///   RB
///   Noted: RB got bread.
/// 
/// **Objectives:**
/// [] Make a program that runs as shown above, including taking a name from the user.
/// </summary>
void FonsolasAndTelim()
{
  WriteTitle(nameof(FonsolasAndTelim));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 4: Comments
/// Challenge 1/1: The Thing Namer 3000
/// TODO 
/// 
/// **Sample Code:**
///   using System;
///   
///   Console.WriteLine("What kind of thing are we talking about?");
///   string a = Console.ReadLine();
///   Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
///   string b = Console.ReadLine();
///   string c = "of Doom";
///   string d = "3000";
///   Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
/// 
/// **Objectives:** 
/// [] Rebuild the program above on your computer.
/// [] Add comments near each of the four variables that describe what they store. You must use at least one of each comment type (`//` and `/* */`).
/// [] Find the bug in the text displayed and fix it.
/// [] **Answer this question:** Aside from comments, what is one other thing you could do to make this code more understandable.
/// </summary>
void TheThingNamer3000()
{
  WriteTitle(nameof(TheThingNamer3000));


}

// *************************************************************************************************

///<summary>
/// LEVEL 5: Variables 
/// Knowledge Check: Variables 
/// </summary>
void KnowledgeCheckVariables()
{
  WriteTitle("Knowledge Check - Variables");
  
  
}

// *************************************************************************************************

/// <summary>
/// LEVEL 6: The C# Type System
/// Challenge 1/2: The Variable Shop
/// TODO
/// 
/// **Objectives:**
/// [] Build a program with a variable of all fourteen types described in this level.
/// [] Assign each of them a value using a literal of the correct type.
/// [] Use `Console.WriteLine` to display the contents of each variable.
/// </summary>
void TheVariableShop()
{
  WriteTitle(nameof(TheVariableShop));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 6: The C# Type System
/// Challenge 2/2: The Variable Shop Returns
/// TODO
/// 
/// **Objectives:**
/// [] Modify the *Variable Shop* program to assign a new, different literal value to each of the 14 original variables. Do not declare any additional variables.
/// [] Use `Console.WriteLine` to display the updated contents of each variable.
/// 
/// </summary>
void TheVariableShopReturns()
{
  WriteTitle(nameof(TheVariableShopReturns));


}

// *************************************************************************************************

///<summary>
/// LEVEL 6: The C# Type System 
/// Knowledge Check: Type System 
/// </summary>
void KnowledgeCheckTypeSystem()
{
  WriteTitle("Knowledge Check - Type System");
  
  
}

// *************************************************************************************************

/// <summary>
/// LEVEL 7: Math
/// Challenge 1/3: The Triangle Farmer
/// TODO 
/// 
/// *Area = base x height / 2*
/// 
/// **Objectives:**
/// [] Write a program that lets you input the triangle's base size and height.
/// [] Compute the area of a triangle by turning the above equation into code.
/// [] Write the result of the computation.
/// </summary>
void TheTriangleFarmer()
{
  WriteTitle(nameof(TheTriangleFarmer));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 7: Math
/// Challenge 2/3: The Four Sisters and the Duckbear
/// TODO
/// 
/// **Objectives:**
/// [] Create a program that lets the user enter the number of chocolate eggs gathered that day.
/// [] Using `/` and `%`, compute how many eggs each sister should get and how many are left over for the duckbear.
/// [] Answer this question: What are three total egg counts where the duckbear gets more than each sister does? Use the program you created to help you find the answer. 
/// </summary>
void TheFourSistersAndTheDuckbear()
{
  WriteTitle(nameof(TheFourSistersAndTheDuckbear));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 7: Math
/// Challenge 3/3: The Dominion of Kings
/// Three kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest kingdom among them. Each king rules an assortment of provinces, duchies, and estates. Collectively, they agree to a point system that helps them judge whose kingdom is greatest: Every estate is worth 1 point, every duchy is worth 3 points, and every province is worth 6 points. They just need a program that will allow them to enter their current holdings and compute a point total.
/// 
/// **Objectives:** 
/// [] Create a program that allows the user to enter how many provinces, duchies, and estates they have.
/// [] Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province.
/// [] Display the point total to the user.
/// </summary>
void TheDominionOfKings()
{
  WriteTitle(nameof(TheDominionOfKings));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 8: Console 2.0
/// Challenge 1/1: The Defense of Consolas
/// The Uncoded One has begun an assault on the city of Consolas; the situation is dire. From a moving airship called the Manticore, massive fireballs capable of destroying city blocks are being catapulted into the city. 
/// 
/// The city is arranged in blocks numbered like a chess board. The city's only defense is a immovable magical barrier, operated by squad of four that can protect a single city block by putting themselves in each of the target's for adjacent blocks as shown in the picture to the right (no pic sorry).
/// 
/// For example, to protect the city block at (Row 6, Column 5), the crew deploys themselves to (Row 6, Column 4). (Row 5, Column 5), (Row 6, Column 6), and (Row 7, Column 5).
/// 
/// The good news is that if we can compute the deployment locations fast enough, the crew could be deployed around the target in time to prevent catastrophic damage to the city for as long as the seige lasts. The City of Consolas needs a program to tell the squad where to deploy, given the anticipated target. Something like this:
/// 
/// **Sample Program:**
///   Target Row? 6
///   Target Column? 5
///   Deploy to:
///   (6, 4)
///   (5, 5)
///   (6, 6)
///   (7, 5)
///   
/// **Objectives:**
/// [] Ask the user for the target row and columns.
/// [] Compute the neighboring rows and columns of where to deploy the squad.
/// [] Display the deployment instructions in a different color of your choosing.
/// [] Change the window title to be "Defense of Consolas".
/// [] Play a sound with `Console.Beep` when the results have been computed and displayed.
/// </summary>
void TheDefenseOfConsolas()
{
  WriteTitle(nameof(TheDefenseOfConsolas));
  

}

// *************************************************************************************************

/// <summary>
/// LEVEL 9: Decision Making
/// Challenge 1/2: Repairing the Clocktower
/// The recent attacks damaged the great Clocktower of Consolas. The citizens of Consolas have repaired most of it, except one piece that requires the steady hand of a Programmer. It is the part that makes the clock tick and tock. Numbers flow into the clock to make it go, and if the number is even, the clock's pendulum should stick to the left. If the number is odd, the pendulum should tock to the right. Only a Programmer can recreate this critical element of the clock to make it work again.
/// [] Take a number as input from the console.
/// [] Display the word "Tick" if the number is even. Display the word "Tock" if the number is odd.
/// Hint: Remember that you can use the remainder operator to determine if a number is even or odd.
/// </summary>
void RepairingTheClockTower()
{
  WriteTitle(nameof(RepairingTheClockTower));

  Console.Write("What time is it? ");
  int number = Convert.ToInt32(Console.ReadLine());
  if (number % 2 == 0)
    Console.WriteLine("Tick");
  else
    Console.WriteLine("Tock");
}

// *************************************************************************************************

/// <summary>
/// LEVEL 9: Decision Making
/// Challenge 2/2: Watchtower
/// There are watchtowers in the region around Consolas that can alert you when an enemy is spotted. With some help from you, they can tell you which direction the enemy is from the watchtower.
/// 
/// **Image:**
///       x< 0  x= 0  x> 0
///      |----|-----|----|
/// y> 0 | NW |  N  | NE |
/// y= 0 | W  |  !  |  E |
/// y< 0 | SW |  S  | SE |
///      |----|-----|----|
///     
/// **Objectives:**
/// [] Ask the user for an `x` value and a `y` value. These are coordinates of the enemy relative to the watchtower's location.
/// [] Using the image above, `if` statements, and relational operators, display a message about what direction the enemy is coming from. For example, "The enemy is to the northwest!" or "The enemy is here!"
/// </summary>
void Watchtower()
{
  WriteTitle(nameof(Watchtower));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 10: Switches
/// Challenge 1/2: Buying Inventory
/// It is time to resupply. A nearby outfitter shop has the supplies you need, but it is so disorganized that they cannot sell things to you. "Can't sell if I can't find the price list," Tortuga, the owner, tells you as he turns over and attempts to go back to sleep.
/// 
/// There's a simple solution: use your programming powers to build something to report the prices of various pieces of equipment, based on the user selection:
/// 
/// **Sample Program:**
///   The following items are available:
///   1 - Rope
///   2 - Torches
///   3 - Climbing Equipment
///   4 - Clean Water
///   5 - Machete
///   6 - Canoe
///   7 - Food Supplies
///   What number do you want to see the price of? 2
///   Torches cost 15 gold.
///   
/// You search around the shop and find ledgers that show the following prices for these items: Rope: 10 gold, Torches: 15 gold, Climbing Equipment: 25 gold, Clean Water: 1 gold, Machete: 20 gold, Canoe: 200 gold, Food Supplies: 1 gold.
/// 
/// **Objectives:**
/// [] Build a program that will show the menu illustrated above.
/// [] Ask the user to enter a number from the menu.
/// [] Using the information above, use a switch (either type) to show the item's cost.
/// </summary>
void BuyingInventory()
{
  WriteTitle(nameof(BuyingInventory));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 10: Switches
/// Challenge 2/2: Discounting Inventory
/// After sorting through tortugas outfitter shop and making it viable again, Tortuga realizes you've put him back in business. He wants to repay the favor by giving you a 50% discount on anything you buy from him and he wants you to modify your program to reflect that.
/// 
/// After asking the user for a number, the program should also ask the user for their name. If the name supplied is your name then cut the price in half before reporting it to the user
/// 
/// **Objectives:** 
/// [] Modify your program from before to also ask the user for their name.
/// [] If their name equals your name, divide the cost in half.
/// </summary>
void DiscountingInventory()
{
  WriteTitle(nameof(DiscountingInventory));

  
}

// *************************************************************************************************

/// <summary>
/// LEVEL 11: Looping
/// Challenge 1/2: The Prototype
/// Mylara, the captain of the Guard of Consolas, has approached you with the beginnings of a plan to hunt down the Uncoded One's airship. "If we're going to be able to track this thing down," she says, "we need you to make us a program that can help us home in on a location." She lays out a plan for a program to help with the hunt. One user representing the pilot of the airship picks a number between zero and 100. Another user, the Hunter, will then attempt to guess the number. The program will tell the hunter that they guess correctly or that the number was too high or too low. The program repeats until the hunter guesses the number correctly. Mylar claims "If we can build this program, we can use what we learn to build a better version to hunt down the Uncoded One's airship".
/// 
/// **Sample Program:** 
///   User 1, enter a number between 0 and 100: 27
///   <clear the screen>
///   User 2, guess the number.
///   What is your next guess? 50
///   50 is too high.
///   What is your next guess? 25
///   25 is too low.
///   What is your next guess? 27
///   You guessed the number!
///
/// **Objectives:** 
/// [] Build a program that will allow a user, the pilot, to enter a number.
/// [] If the number is above 100 or less than 0, keep asking.
/// [] Clear the screen once the program has collected a good number.
/// [] Ask a second user, the hunter, to guess numbers.
/// [] Indicate whether the user guessed too high, too low, or guessed right.
/// [] Loop until they get it right, then end the program.
/// </summary>
void ThePrototype()
{
  WriteTitle(nameof(ThePrototype));

  
}

// *************************************************************************************************

/// <summary>
/// LEVEL 11: Looping
/// Challenge 2/2: The Magic Cannon
/// Skorin, a member of Consolas's wall guard, has constructed a magic cannon that draws power from two gems: a fire gem and an electric gem. Every third turn of the crank, the fire gem activates, and the cannon produces a fire blast. Every fifth turn of the crank, the electric gem activates, and the cannon makes an electric blast. When the two line up, it generates a potent combined blast. Skorin would like your help to produce a program that can give the crew a warning about which turns of the crank will produce the different blasts before they do it.
/// 
/// A partial output of the desired program looks like this:
/// **Sample Program:**
///   1: Normal
///   2: Normal
///   3: Fire
///   4: Normal
///   5: Electric
///   6: Fire
///   7: Normal
/// 
/// **Objectives:**
/// [] Write a program that will loop through the values between 1 and 100 and display what kind of blast the crew should expect. (The % operator may be of use.)
// [] Change the color of the output based on the the type of blast. (For example, red for Fire, yellow for Electric, and blue for Electric and Fire).
/// </summary>
void TheMagicCannon()
{
  WriteTitle(nameof(TheMagicCannon));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 12: Arrays
/// Challenge 1/2: The Replicator of D'To
/// Along with the new-found tool of arrays, you have managed to uncover the ancient Replicator of the D'To. This can replicate the contents of any `int` array into another array, but it appears broken and needs a Programmer to reforge the magic that allows it to replicate once again.
/// 
/// **Objectives:** 
/// [] Make a program that creates an array of length 5.
/// [] Ask the user for five numbers and put them in the array.
/// [] Make a second array of length 5.
/// [] Use a loop to copy the values out of the original array and into the new one.
/// [] Display the contents of both arrays one at a time to illustrate that the Replicator of D'To works again.
/// </summary>
void TheReplicatorOfDTo()
{
  WriteTitle(nameof(TheReplicatorOfDTo));


}

// *************************************************************************************************

/// <summary>
/// LEVEL 12: Arrays
/// Challenge 2/2: The Laws of Freach
/// The town of  Freach recently had an awful looping disaster. The lead investigator found that it was a faulty `++` operator in an old `for` loop, but the town council has chosen to ban all loops but the `foreach` loop. Yet Freach uses the code presented earlier in this level to compute the minimum and the average value in an `int` array. They have hired you to rework their existing `for`-based code to use `foreach` loops instead.
/// 
/// **Objectives:**
/// [] Start with the code for computing an array's minimum and average values in the section *Some Examples with Arrays*, starting on page 90 (see provided code below in TheLawsOfFreach).
/// [] Modify the code to use `foreach` loops instead of `for` loops.
/// </summary>
void TheLawsOfFreach()
{
  WriteTitle(nameof(TheLawsOfFreach));

  
}

// *************************************************************************************************

/// <summary>
/// LEVEL 13: Methods
/// Challenge 1/2: Taking a Number
/// Many previous tasks have required getting a number from a user. To save time writing out this code over and over, you have decided to make a method to do this common task.
/// 
/// **Objectives:**
/// [] Make a method with the signature `int AskForNumber(string text)`. Display the `text` parameter on the command line. Retrieve a response from the user, convert it to an `int`, and return it. Sample usage: `int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");`
/// [] Make a method with the signature `int AskForNumberInRange(string text, int min, int max)`. Only return if the entered number is between `min` and `max` values. Otherwise, ask again.
/// [] Place this method in at least one of your previous programs to improve it.
/// </summary>
void TakingANumber()
{
  WriteTitle(nameof(TakingANumber));

  
}

// *************************************************************************************************

/// <summary>
/// LEVEL 13: Methods
/// Challenge 2/2: Countdown
/// Note: this challenge requires that you have read *The Basics of Recursion* sidequest to attempt. (it's just a section explaining recursion concept)
/// 
/// The Council of Freach has summoned you. New writing has appeared on the Tomb of Algol the Wise, the last True Programmer to wander this land. The writing strikes fear and awe into the hearts of the loop-loving people of Freach: "The next True Programmer shall be able to write any looping code with a method call instead." The Senior Counselor, scared of a world without loops, asks you to put your skill to the test and rewrite the following code, which counts down from 10 to 1, with no loops:
/// 
/// **Sample Code:**
///   for (int x = 10; x > 0; x--)
///     Console.WriteLine(x);
/// 
/// As you consider the words on the Tomb of Algol the Wise, you begin to think that with recursion, you might be able to rewrite code to countdown from 10 to 1 using recursion instead of a loop.
/// 
/// **Objectives:**
/// [] Write code that counts down from 10 to 1 using a recursive method.
/// [] **Hint:** Remember that you must have a base case that ends the recursion and that every time you call the method recursively, you must be getting closer and closer to that base case.
/// </summary>
void Countdown()
{
  WriteTitle(nameof(Countdown));

  
}

// *************************************************************************************************

///<summary>
/// LEVEL 14: Memory Management 
/// Knowledge Check: Memory 
/// </summary>
void KnowledgeCheckMemory()
{
  WriteTitle("Knowledge Check - Memory");
  
  
}

// *************************************************************************************************

/// <summary>
/// LEVEL 14: Memory Management
/// Boss Battle: Hunting the Manticore
/// The Uncoded One's airship, the *Manticore*, has begun an all-out attack on the city of Consolas. It must be destroyed, or the city will fall. Only by combining Mylara's prototype, Skorin's cannon, and your programming skills will you have the chance to win this fight. You must build a program that allows one user--the pilot of the *Manticore*--to enter the airship's range from the city and a second user--the city's defenses--to attempt to find what distance the airship is at and destroy it before it can lay waste to the town.
/// 
/// The first user begins by secretly establishing how far the *Manticore* is from the city, in the range 0 to 100. The program then allows a second player to repeatedly attempt to destroy the airship by picking the range to target until either the city of Consolas or the Manticore is destroyed. In each attempt, the player is told if they overshot (too far), fell short (not far enough), or hit the *Manticore*. The damage dealt to the *Manticore* depends on the turn number. For most turns, 1point of damage is dealt, but if the turn number is a multiple of 3, a fire blast deals 3 points of damage; a multiple of 5, an electric blast deals 3 points of damage, and if it is a multiple of both 3 and 5, a mighty fire-electric blast steals 10 points of damage. The *Manticore* has 10 points of damage it can take and is destroyed after being dealt 10 points of damage.
/// However, if the *Manticore* survives a turn, it will deal a guaranteed 1 point of damage to the city of Consolas. The city can only take 15 points of damage before being annihilated.
/// 
/// Before a round begins, the user should see the current status: the current round number, the city's health, and the *Manticore*'s health.
/// 
/// The sample run of the program is shown below. The first player gets a chance to place the Manticore. Then, the display is cleared and the second player gets their chance:
/// 
/// **Sample Program:**
///   Player 1, how far away from the city do you want to station the Manticore? 32
///
///   Player 2, it is your turn.
///   --------------------------------------------------------------------
///   STATUS: Round: 1  City: 15/15  Manticore: 10/10
///   The cannon is expected to deal 1 damage this round.
///   Enter desired cannon range: 50
///   That round OVERSHOT the target.
///   --------------------------------------------------------------------
///   STATUS: Round: 2  City: 14/15  Manticore: 10/10
///   The cannon is expected to deal 1 damage this round.
///   Enter desired cannon range: 25
///   That round FELL SHORT of the target.
///   --------------------------------------------------------------------
///   STATUS: Round: 3  City: 13/15  Manticore: 10/10
///   The cannon is expected to deal 3 damage this round.
///   Enter desired cannon range: 32
///   That round was a DIRECT HIT!
///   --------------------------------------------------------------------
///   STATUS: Round: 4  City: 12/15  Manticore: 7/10
///   The cannon is expected to deal 1 damage this round.
///   Enter desired cannon range: 32
///   That round was a DIRECT HIT!
///   --------------------------------------------------------------------
///   STATUS: Round: 5  City: 11/15  Manticore: 6/10
///   The cannon is expected to deal 3 damage this round.
///   Enter desired cannon range: 32
///   That round was a DIRECT HIT!
///   --------------------------------------------------------------------
///   STATUS: Round: 6  City: 10/15  Manticore: 3/10
///   The cannon is expected to deal 3 damage this round.
///   Enter desired cannon range: 32
///   That round was a DIRECT HIT!
///   The Manticore has been destroyed! The city of Consolas has been saved!
///
/// **Objectives:**
/// [] Establish the game's starting state: the *Manticore* begins with 10 health points and the city with 15. The game starts at round 1.
/// [] Ask the first player to choose the *Manticore's* distance from the city (0 to 100). Clear the screen afterward.
/// [] Run the game in a loop until either the *Manticore's* or city's health reaches 0.
/// [] Before the second player's turn, display the round number, the city's health, and the *Manticore's* health.
/// [] Compute how much damage the cannon will deal this round: 10 points if the round number is a multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to the player.
/// [] Get a target range from the second player, and resolve its effect. Tell the user if they overshot (too far), fell short, or hit the *Manticore*. If it was a hit, reduce the *Manticore's* health by the expected amount.
/// [] If the *Manticore* is still alive, reduce the city's health by 1.
/// [] Advance to the next round.
/// [] When the *Manticore* of the city's health reaches 0, end the game and display the outcome.
/// [] Use different colors for different types of messages.
/// [] Note: This is the largest program you have made so far. Expect it to take some time!
/// [] Note: Use methods to focus on solving one problem at a time.
/// [] Note: This version requires two players, but in the future, we will modify it to allow the computer to randomly place the *Manticore* so that it can be a single-player game.
/// </summary>
void HuntingTheManticore()
{
  WriteTitle(nameof(HuntingTheManticore));
  

}