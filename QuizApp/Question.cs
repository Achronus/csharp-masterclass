namespace QuizApp
{
    public class Question(string text, Enum answer)
    {
        public string Text { get; } = text;
        public string[] Answers { get; } = EnumValuesToString(answer);
        public Enum CorrectAnswer { get; } = answer;

        private static string[] EnumValuesToString(Enum values)
        {
            Type enumType = values.GetType();
            return Enum.GetNames(enumType);
        }

        public bool IsCorrectAnswer(int choice)
        {
            int correctAnswerIdx = Convert.ToInt32(CorrectAnswer);
            return correctAnswerIdx == choice;
        }
    }
}
