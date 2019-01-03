using Quiz.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Core.Models;

namespace Quiz.Services
{
    public class CountPlayerScoreBySumService : ICountPlayerScoreBySum
    {
        public int CountPlayerScoreBySum(IEnumerable<Answer> userAnswers, IEnumerable<QuestionAnswer> correctAnswers)
        {
            var sum = 0;
            foreach (var userAnswer in userAnswers)
            {
                var correctAnswer = correctAnswers.Where(a => a.IdQuestion == userAnswer.IdQuestion).FirstOrDefault();
                
                if (correctAnswer != null) {
                    if (userAnswer.IdAnswer == correctAnswer.IdAnswer)
                        sum += 1;
                }
            }

            return sum;
        }
    }
}
