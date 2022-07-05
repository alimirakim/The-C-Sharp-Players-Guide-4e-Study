public class Book : SectionGroup
{
  public SectionGroup Part1 { get; set; }
  public SectionGroup Part2 { get; set; }
  public SectionGroup Part3 { get; set; }
  public SectionGroup Part4 { get; set; }
  public SectionGroup Part5 { get; set; }

  public Book() : base ("The C# Player's Guide (4th Edition)", SectionGroupType.Book)
  {
    Part1 = new SectionGroup("Part 1: The Basics", SectionGroupType.Part);
    Part2 = new SectionGroup("Part 2: Object-Oriented Programming", SectionGroupType.Part);
    Part3 = new SectionGroup("Part 3: Advanced Topics", SectionGroupType.Part);
    Part4 = new SectionGroup("Part 4: The Endgame", SectionGroupType.Part);
    Part5 = new SectionGroup("Part 5: Bonus Levels", SectionGroupType.Part);
    
    Sections = new SectionGroup[] { Part1, Part2, Part3, Part4, Part5 };
  }

  public static SectionGroup[] MakeSectionGroups((string partTitle, string[] levelTitles)[] sectionTitles)
  {
    SectionGroup[] parts = new SectionGroup[sectionTitles.Length];
    for (int pi = 0; pi < sectionTitles.Length; pi++)
    {
      string[] levelTitles = sectionTitles[pi].levelTitles;
      SectionGroup[] partLevels = new SectionGroup[levelTitles.Length];

      for (int li = 0; li < levelTitles.Length; li++)
        partLevels[li] = new SectionGroup(levelTitles[li], SectionGroupType.Level);

      parts[pi] = new SectionGroup(
        sectionTitles[pi].partTitle,
        SectionGroupType.Part,
        partLevels
      );
    }

    return parts;
  }
}
