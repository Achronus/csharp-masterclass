namespace QuizApp
{
    public class Quiz(Question[] questions)
    {
        private Question[] Questions { get; } = questions;
        private int Score { get; set; } = 0;

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!\n");

            int questionNumber = 1;

            foreach (Question question in Questions)
            {
                DisplayQuestion(question, questionNumber++);

                int choice = GetUserChoice(question);

                if (question.IsCorrectAnswer(choice))
                {
                    Console.WriteLine("Correct!\n");
                    Score++;
                    continue;
                }
        
                Console.WriteLine($"Wrong! The correct answer is: {question.CorrectAnswer}\n");
            }

            Heading("Results", ConsoleColor.Cyan);
            DisplayResults();
        }

        private void DisplayResults()
        {
            double scorePercent = ((double)Score / Questions.Length) * 100;
            Console.WriteLine($"Quiz finished. Your score is: {Score} out of {Questions.Length} ({Math.Round(scorePercent, 0)}%)");
        }

        private static void Heading(string title, ConsoleColor color)
        {
            string lineBreak = "----------------------------------";
            int spacing = lineBreak.Length - title.Length;

            Console.ForegroundColor = color;
            Console.WriteLine(lineBreak);
            Console.WriteLine(title.PadLeft(title.Length + spacing / 2).PadRight(spacing / 2));
            Console.WriteLine(lineBreak);
            Console.ResetColor();
        }

        private static void DisplayQuestion(Question question, int idx)
        {
            Heading($"Question {idx}", ConsoleColor.Yellow);
            Console.WriteLine($"{question.Text}?");

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"  {i + 1}");
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }
        }

        private static int GetUserChoice(Question question)
        {
            int choice = 0;
            int numAnswers = question.Answers.Length;

            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();

            while (!int.TryParse(input, out choice) || choice < 1 || choice > numAnswers)
            {
                Console.Write($"Invalid choice. Please enter a number between 1 and {numAnswers}: ");
            }

            return choice - 1;
        }
    }
}
