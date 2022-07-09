public class Level : SectionGroup
{
  private string _speedrun;
  public Level(string title, Section[]? sections = null, string speedrun="") 
  : base(title, SectionGroupType.Level, sections ?? new Section[] { })
  {
    _speedrun = speedrun;
  }
}
