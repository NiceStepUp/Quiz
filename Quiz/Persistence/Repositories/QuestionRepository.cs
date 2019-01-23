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
                new Question(1, "How many are there contintents?",
                    new List<Answer>
                        {
                            new Answer(1, 1, "1", false), new Answer(2, 1, "2", false), new Answer(3, 1, "5", false), new Answer(4, 1, "6", true)
                        }),
                new Question(2, "How many are there colours?",
                    new List<Answer>
                        {
                            new Answer(7, 2, "More than 1", false), new Answer(8, 2, "More than 2", false), new Answer(9, 2, "More than 5", false), new Answer(10, 2, "More than 6", true)
                        }),
                new Question(3, "What is the tallest tree?",
                    new List<Answer>
                        {
                            new Answer(11, 3, "Sequoia", true), new Answer(12, 3, "Berch", false), new Answer(13, 3, "Lindens", false), new Answer(14, 3, "Alder", false)
                        }),
                new Question(4, "Do you like dolphins?",
                    new List<Answer>
                        {
                            new Answer(15, 4, "yes, I do!", true), new Answer(16, 4, "Sure!", false), new Answer(17, 4, "Exactly", false), new Answer(18, 4, "Yeap!", false)
                        })
            };
        }
    }
}
