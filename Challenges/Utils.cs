using System;

public static class Utils
  {

  public static void WriteTitle(string title, bool isUpper = false)
  {
    string divider = "";
    for (int i = 0; i < title.Length; i++)
      divider += "-";

    Console.WriteLine("");
    Console.WriteLine(isUpper ? title.ToUpper(): title);
    Console.WriteLine(divider);
  }
  }