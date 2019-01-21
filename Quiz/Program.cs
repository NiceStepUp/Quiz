using Quiz.Core.Dtos;
using Quiz.Core.Models;
using Quiz.Core.Repositories;
using Quiz.Core.Services;
using Quiz.Persistence.Repositories;
using Quiz.Services;
using Quiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuestionRepository questionService = Factory.CreateInstance<QuestionRepository>();
            var questions = questionService.GetQuestions();

            IAnswerRepository answerService = Factory.CreateInstance<AnswerRepository>();
            var possibleAnswers = answerService.GetPossibleAnswers(questions);

            var playerAnswers = GetPlayerAnswers(questions, possibleAnswers);
            IQuestionAnswerRepository questionAnswerRepository = Factory.CreateInstance<QuestionAnswerRepository>();
            var correctAnswers = questionAnswerRepository.GetCorrectAnswers(questions);

            ICountPlayerScoreBySum playerScores = Factory.CreateInstance<CountPlayerScoreBySumService>();
            var playerScore = playerScores.CountPlayerScoreBySum(playerAnswers, correctAnswers);

            var winScoreString = ConfigurationManager.AppSettings.Get("WinScore");
            int winScore = 0;
            int.TryParse(winScoreString, out winScore);

            Console.WriteLine( playerScore == winScore ? 
                $"Wow! You are a winner! Your score is {playerScore}" 
                : $"Try again! It is just the lesson to win! Your score is {playerScore}");
        }


        private static IEnumerable<Answer> GetPlayerAnswers(IEnumerable<Question> questions, IEnumerable<Answer> possibleAnswers)
        {
            List<string> allowedAnswers = new List<string>()
                {
                    Constants.Constants.Answers.A,
                    Constants.Constants.Answers.B,
                    Constants.Constants.Answers.C,
                    Constants.Constants.Answers.D,
                };
            
            var playerAnswers = new List<Answer>();

            foreach (var question in questions)
            {
                var possibleAnswersViewModel = possibleAnswers.Where(a => a.IdQuestion == question.IdQuestion)
                    .OrderBy(a=>a.IdAnswer)
                    .Select((a, i) => new PlayerAnswerViewModel { Content = $"{ IntToLetters(i)}. {a.Content}", IdAnswer = a.IdAnswer, IdQuestion = a.IdQuestion, PlayerKey = IntToLetters(i) });                

                AskQuestion(question, possibleAnswersViewModel);

                while (true)
                {
                    var playerKey = Console.ReadKey().KeyChar.ToString().ToUpper();
                    Console.WriteLine();
                    if (!allowedAnswers.Contains(playerKey))
                    {
                        AskQuestion(question, possibleAnswersViewModel, true);
                    }
                    else
                    {
                        var answer = possibleAnswersViewModel.Where(a => a.PlayerKey == playerKey).FirstOrDefault();
                        if(answer != null)
                            playerAnswers.Add(new Answer(answer.IdAnswer, question.IdQuestion, playerKey));
                        break;
                    }
                }
            }

            return playerAnswers;
        }

        private static void AskQuestion(Question question, IEnumerable<PlayerAnswerViewModel> possibleAnswers, bool showPossibleKeys = false)
        {
            if (showPossibleKeys)
            {
                Console.WriteLine();
                Console.WriteLine("Possible keys are A, B, C or D");
            }

            Console.WriteLine(question.Content);
            possibleAnswers
                .ToList()
                .ForEach(a => Console.WriteLine(a.Content));
        }

        public static string IntToLetters(int value)
        {
            string result = string.Empty;
            result = (char)('A' + value % 26) + result;
            return result;
        }
    }
}
