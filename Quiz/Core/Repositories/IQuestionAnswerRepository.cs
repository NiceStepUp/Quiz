using Quiz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Repositories
{
    interface IQuestionAnswerRepository
    {
        IEnumerable<QuestionAnswer> GetCorrectAnswers(IEnumerable<Question> questions);
    }
}
