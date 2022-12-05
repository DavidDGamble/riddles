namespace Riddles
{
  class Question
  {
    string[] questions = File.ReadAllText("./data/questions.txt").Split("\n");
    string[] answers = File.ReadAllText("./data/answers.txt").Split("\n");
    int index = 0;

    public string GetQuestion() {
      return questions[index];
    }

    public bool IsCorrect(string userAnswer) {
      return userAnswer == answers[index];
    }

    public void NextQuestion() {
      index++;
    }

    public bool CheckIndex() 
    {
      return index <= 5;
    }
  }
}