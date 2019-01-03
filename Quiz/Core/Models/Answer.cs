using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Models
{
    public class Answer
    {
        public int IdAnswer { get; }
        public string Content { get; }

        public int IdQuestion { get; }

        public Answer(int idAnswer, int idQuestion, string content)
        {
            IdAnswer = idAnswer;            
            IdQuestion = idQuestion;
            Content = content;
        }
    }
}
