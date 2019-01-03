using Quiz.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Core.Models;

namespace Quiz.Persistence.Repositories
{
    public class QuestionAnswerRepository : IQuestionAnswerRepository
    {
        public IEnumerable<QuestionAnswer> GetCorrectAnswers(IEnumerable<Question> questions)
        {
            return new List<QuestionAnswer>() {
                new QuestionAnswer(1, 1),
                new QuestionAnswer(2, 2),
                new QuestionAnswer(3, 3),
                new QuestionAnswer(4, 4),
                new QuestionAnswer(5, 1),
                new QuestionAnswer(6, 1),
                new QuestionAnswer(7, 1),
                new QuestionAnswer(8, 1),
                new QuestionAnswer(9, 1),
                new QuestionAnswer(10, 1)
            }            
            .Where(qa => questions
                .Select(q=>q.IdQuestion)
                .Contains(qa.IdQuestion)
            );
        }
    }
}
