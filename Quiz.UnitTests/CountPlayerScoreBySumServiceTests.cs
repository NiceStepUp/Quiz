using Moq;
using NUnit.Framework;
using Quiz.Core.Models;
using Quiz.Services;
using System;
using System.Collections.Generic;

namespace Quiz.UnitTests
{
    [TestFixture]
    public class CountPlayerScoreBySumServiceTests
    {
        private CountPlayerScoreBySumService _countPlayerScoreBySumService;
        private IEnumerable<Answer> _playerAnswers;
        private IEnumerable<QuestionAnswer> _correctAnswers;

        [SetUp]
        public void SetUp()
        {
            _countPlayerScoreBySumService = new CountPlayerScoreBySumService();
            _playerAnswers = new List<Answer>()
            {
                new Answer(1, 1, "a"),
                new Answer(2, 2, "b"),
                new Answer(3, 3, "c"),
                new Answer(4, 4, "d")
            };

            _correctAnswers = new List<QuestionAnswer>()
            {
                new QuestionAnswer(1, 1),
                new QuestionAnswer(2, 2),
                new QuestionAnswer(3, 3),
                new QuestionAnswer(4, 4),
            };

        }

        [Test]
        public void CountPlayerScoreBySum_AllAnswersAreCorrect_ReturnsFour()
        {
            var result = _countPlayerScoreBySumService.CountPlayerScoreBySum(_playerAnswers, _correctAnswers);

            Assert.That(result, Is.EqualTo(4));
        }
    }
}
