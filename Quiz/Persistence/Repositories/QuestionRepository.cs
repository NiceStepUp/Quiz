using Quiz.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Core.Models;

namespace Quiz.Persistence.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public IEnumerable<Question> GetQuestions()
        {
            return new List<Question>() {
                new Question(1, "How many are there contintents?"),
                new Question(2, "How many are there colours?"),
                new Question(3, "What is the tallest tree?"),
                new Question(4, "Do you like dolphins?"),
            };
        }
    }
}
