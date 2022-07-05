
public class SectionGroup : Section
{
  // private string Title { get; init; } // We have to repeat this for Section even if duplicate? Only if we use the Title in the child's other code?
  public SectionGroupType GroupType { get; }
  public Section[] Sections { get; set; }

  public SectionGroup(string title, SectionGroupType groupType, Section[]? sections = null) : base(title, SectionType.Group)
  {
    GroupType = groupType;
    Sections = sections ?? new Section[] { };
  }

  public override void Run() => RunSectionType(null);
  public void RunSectionType(SectionType? filter = null)
  {
    foreach (Section section in Sections)
    {
      if (section.GetType() == typeof(SectionGroup))
      {
        section.WriteTitle(true);
        ((SectionGroup)section).RunSectionType(filter);
      }
      else if (filter == null | section.Type == filter)
      {
        section.WriteTitle();
        section.Run();
      }
    }
  }

  public void RunChallenges() => RunSectionType(SectionType.Challenge);
  public void RunKnowledgeChecks() => RunSectionType(SectionType.KnowledgeCheck);
}
