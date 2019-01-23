using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Models
{
    public class Question
    {
        public Question(int idQuestion, string content, IEnumerable<Answer> answers)
        {
            IdQuestion = idQuestion;
            Content = content;
            AvailableAnswers = AvailableAnswers ?? new ReadOnlyCollection<Answer>(answers.ToList());
        }

        public int IdQuestion { get; }

        public string Content { get; }

        public IReadOnlyCollection<Answer> AvailableAnswers { get; }
    }
}
