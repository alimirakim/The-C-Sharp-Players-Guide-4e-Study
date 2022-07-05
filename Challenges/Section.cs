using System;

public abstract class Section
{
  protected string Title { get; init; }
  public SectionType Type { get; init; }

  public Section(string title, SectionType type)
  {
    Title = title;
    Type = type;
  }

  public void WriteTitle(bool isUpper = false) => Utils.WriteTitle(Title, isUpper); // What if I don't want to create these default-value-chains for params?

  public abstract void Run();
}