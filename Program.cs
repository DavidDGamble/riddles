namespace Riddles
{
  class Riddle
  {
    static void Main()
    {
      Question QandAs = new Question();
      bool correct = true;

      void sendQuestion()
      {
        Console.WriteLine(QandAs.GetQuestion());
        string curAnswer = Console.ReadLine();
        if (QandAs.IsCorrect(curAnswer.ToLower()))
        {
          QandAs.NextQuestion();
          Console.WriteLine("CORRECT!");
        } else {
          Console.WriteLine("YOU LOSE!");
          correct = false;
        }
      }

      while (correct && QandAs.CheckIndex()) {
        sendQuestion();
      }
    }
  }
}