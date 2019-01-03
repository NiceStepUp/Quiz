using Quiz.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Core.Models;

namespace Quiz.Persistence.Repositories
{
    class AnswerRepository : IAnswerRepository
    {
        public IEnumerable<Answer> GetPossibleAnswers(IEnumerable<Question> questions)
        {
            return new List<Answer>() {
                new Answer(11, 3, "Sequoia"), new Answer(12, 3, "Berch"), new Answer(13, 3, "Lindens"), new Answer(14, 3, "Alder"),
                new Answer(1, 1, "1"), new Answer(2, 1, "2"), new Answer(3, 1, "5"), new Answer(4, 1, "6"),
                new Answer(7, 2, "More than 1"), new Answer(8, 2, "More than 2"), new Answer(9, 2, "More than 5"), new Answer(10, 2, "More than 6"),
                new Answer(15, 4, "yes, I do!"), new Answer(16, 4, "Sure!"), new Answer(17, 4, "Exactly"), new Answer(18, 4, "Yeap!"),
                new Answer(19, 5, "yes, I do!"), new Answer(20, 5, "Sure!"), new Answer(21, 5, "Exactly"), new Answer(22, 5, "Yeap!"),
                new Answer(23, 6, "yes, I do!"), new Answer(24, 6, "Sure!"), new Answer(25, 6, "Exactly"), new Answer(26, 6, "Yeap!"),
                new Answer(27, 7, "yes, I do!"), new Answer(28, 7, "Sure!"), new Answer(29, 7, "Exactly"), new Answer(30, 7, "Yeap!")
            }.Where(qa => questions
                .Select(q => q.IdQuestion)
                .Contains(qa.IdQuestion)
            );
        }
    }
}
