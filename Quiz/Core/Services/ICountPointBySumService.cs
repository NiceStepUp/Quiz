using Quiz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Core.Services
{
    interface ICountPointBySumService
    {
        int CountPointBySumService(IEnumerable<Answer> userAnswers, IEnumerable<QuestionAnswer> correctAnswers);
    }
}
