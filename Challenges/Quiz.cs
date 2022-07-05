using System;

public class Quiz : Section
{
  public (string question, string answer)[] _questionsAndAnswers;

  public Quiz(string title, SectionType type, (string question, string answer)[] questionsAndAnswers) : base(title, type)
  {
    _questionsAndAnswers = questionsAndAnswers;
  }

  public override void Run() // How to handle shared method names with different params like this?
  {
    Console.WriteLine("Check your knowledge with the following questions: ");

    foreach ((string question, string answer) qa in _questionsAndAnswers)
    {
      Console.Write("\n" + qa.question + " ");
      string? reply = Console.ReadLine();
      Console.WriteLine("ANSWER: " + qa.answer);
      if (reply?.ToLower() == qa.answer.ToLower()) Console.WriteLine("⭐ Nice! ");
    }
  }
}
