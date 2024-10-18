namespace QuizApp
{
    public enum GermanyOptions
    {
        Paris,
        London,
        Madrid,
        Berlin
    }

    public enum SumOptions
    {
        Three,
        Four,
        Five,
        Six
    }

    public enum HambletOptions
    {
        Goethe,
        Austen,
        Shakespeare,
        Dickens,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = [
                new Question(
                    "What is the capital of Germany",
                    GermanyOptions.Berlin
                ),
                new Question(
                    "What is 2+2",
                    SumOptions.Four
                ),
                new Question(
                    "Who wrote 'Hamblet'",
                    HambletOptions.Shakespeare
                ),
            ];

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();
        }
    }
}
