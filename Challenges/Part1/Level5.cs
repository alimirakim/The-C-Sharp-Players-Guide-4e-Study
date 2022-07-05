using System;
namespace Template;

/// <summary>
/// LEVEL 5: Variables
/// </summary>
public class Level5 : Level
{
  /// <summary>
  /// Knowledge Check: Variables 
  /// </summary>
  private Section knowledgeCheckVariables = new Quiz(
    "Knowledge Check - Variables",
    SectionType.KnowledgeCheck,
    new (string question, string answer)[] {
      (
        question: "1. Name the three things all variables have.",
        answer: "name, type, value"
      ),
      (
        question: "2. True/False. Variables must always be declared before being used.",
        answer: "True"
      ),
      (
        question: "3. Can you redeclare a variable?",
        answer: "No"
      ),
      (
        question: "4. Which of the following are legal C# variable names? answer,1stValue,value1,$message,delete-me,delete_me,PI",
        answer: "answer, value1, delete_me, PI"
      )
    }
  );

  public Level5() : base("Level 5: Variables")
  {
    Sections = new Section[] {
      knowledgeCheckVariables,
    };
  }
}