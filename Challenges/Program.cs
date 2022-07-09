
using System;
using Template;

// Instructions:
// cd into Challenges/ folder.
// Run `dotnet run` on command line.
// You should see the titles of each challenge. Fill out the empty methods to fulfill each challenge's objectives and see the results.
// Comment out levels that you don't need to see anymore.

Book book = new Book();

book.Part1.Sections = new SectionGroup[] {
  new Level1(),
  new Level2(),
  new Level3(),
  new Level4(),
  new Level5(),
  new Level6(),
  // new Level7(),
  // new Level8(),
  // new Level9(),
  // new Level10(),
  // new Level11(),
  // new Level12(),
  // new Level13(),
  // new Level14(),
};

// book.Part2.Sections = new SectionGroup[] {
//   new Level10(),
//   new Level11(),
//   new Level12(),
//   new Level13(),
//   new Level14(),
//   new Level15(),
//   new Level16(),
//   new Level17(),
//   new Level18(),
//   new Level19(),
//   new Level20(),
//   new Level21(),
//   new Level22(),
//   new Level23(),
//   new Level24(),
//   new Level25(),
//   new Level26(),
//   new Level27(),
//   new Level28(),
//   new Level29(),
//   new Level30(),
//   new Level31(),
//   new Level32(),
// };

// book.Part3.Sections = new SectionGroup[] {
//   new Level33(),
//   new Level34(),
//   new Level35(),
//   new Level36(),
//   new Level37(),
//   new Level38(),
//   new Level39(),
//   new Level40(),
//   new Level41(),
//   new Level42(),
//   new Level43(),
//   new Level44(),
//   new Level45(),
//   new Level46(),
//   new Level47(),
//   new Level48(),
//   new Level49(),
//   new Level50(),
//   new Level51(),
// };

// book.Part4.Sections = new SectionGroup[] {
//   new Level52(),
//   new Level53(),
// };

// book.Part5.Sections = new SectionGroup[] {
//   new BonusLevelA(),
//   new BonusLevelB(),
//   new BonusLevelC(),
// };

book.WriteTitle(true);
book.Run();



// CallPart1();
// CallPart2();

// TODO Add Part 3-5 challenges
// CallPart3();
// CallPart4();
// CallPart5();

// Complete.PartTwoA.CallAll();
// Complete.PartTwoB.CallAll();

// void CallPart1()
// {
// Level1.CallAll();
// Level2.CallAll();
// Level3.CallAll();
// Level5.CallAll();
// Level6.CallAll();
// Level7.CallAll();
// Level8.CallAll();
// Level9.CallAll();
// Level10.CallAll();
// Level11.CallAll();
// Level12.CallAll();
// Level13.CallAll();
// Level14.CallAll();
// }

// void CallPart2()
// {
// Part2Level15.CallAll();
//   Level16.CallAll();
//   Level17.CallAll();
//   Level18.CallAll();
//   Level19.CallAll();
//   Level20.CallAll();
//   Level21.CallAll();
//   Level24.CallAll();
//   Level25.CallAll();
//   Level26.CallAll();
//   Level27.CallAll();
//   Level28.CallAll();
//   Level29.CallAll();
//   Level30.CallAll();
//   Level31.CallAll();
//   Level32.CallAll();
// }

// void CallPart3()
// {
//   Part3Level33.CallAll();
//   Part3Level34.CallAll();
//   Part3Level35.CallAll();
//   Part3Level36.CallAll();
//   Part3Level37.CallAll();
//   Part3Level38.CallAll();
//   Part3Level39.CallAll();
//   Part3Level40.CallAll();
//   Part3Level41.CallAll();
//   Part3Level44.CallAll();
//   Part3Level45.CallAll();
//   Part3Level46.CallAll();
//   Part3Level47.CallAll();
//   Part3Level48.CallAll();
//   Part3Level49.CallAll();
//   Part3Level50.CallAll();
//   Part3Level51.CallAll();
// }

// void CallPart4()
// {
//   Part4Level52.CallAll();
// }

// void CallPart5()
// {
//   Part5BonusLevelA.CallAll();
//   Part5BonusLevelB.CallAll();
//   Part5BonusLevelC.CallAll();
// }

public enum SectionGroupType
{
  Book,
  Part,
  Level,
}

public enum SectionType
{
  Group,
  Challenge,
  BossBattle,
  KnowledgeCheck,
  SpeedrunCheck,
  GlossaryCheck,
  Snippet,
  Experiment
}