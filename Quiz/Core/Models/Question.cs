using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Models
{
    public class Question
    {
        public Question(int idQuestion, string content)
        {
            IdQuestion = idQuestion;
            Content = content;
        }

        public int IdQuestion { get; }
        public string Content { get; }
    }
}
