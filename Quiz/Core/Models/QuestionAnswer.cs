using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Models
{
    public class QuestionAnswer
    {
        public QuestionAnswer(int idQuestion, int idAnswer)
        {
            IdQuestion = idQuestion;
            IdAnswer = idAnswer;
        }
        public int IdQuestion { get; set; }
        public int IdAnswer { get; set; }
    }
}
