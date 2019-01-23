using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.ViewModels
{
    public class PlayerAnswerViewModel
    {
        public int IdAnswer { get; set; }

        public string Content { get; set; }

        public int IdQuestion { get; set; }

        public string PlayerKey { get; set; }

        public bool IsCorrect { get; set; }
    }
}
