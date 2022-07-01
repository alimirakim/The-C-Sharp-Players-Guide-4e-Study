  // UTILITY

  public static class Utils
  {

  public static void WriteTitle(string title)
  {
    string divider = "";
    for (int i = 0; i < title.Length; i++)
      divider += "-";

    Console.WriteLine("");
    Console.WriteLine(title);
    Console.WriteLine(divider);
  }
  }