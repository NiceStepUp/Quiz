using Quiz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Dtos
{
    public class PlayerAnswerDTO
    {
        public Question Question { get; set; }
        public string PlayerAnswer { get; set; }
        public Answer Answer { get; set; }
    }
}
