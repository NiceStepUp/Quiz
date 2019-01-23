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
        public int CountPlayerScoreBySum(IEnumerable<Answer> playerAnswers)
        {
            var sum = 0;
            foreach (var userAnswer in playerAnswers)
            {
                if (userAnswer.IsCorrect == true)
                    sum += 1;
            }

            return sum;
        }
    }
}
