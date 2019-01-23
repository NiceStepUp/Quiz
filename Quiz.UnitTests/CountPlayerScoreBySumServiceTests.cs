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

        [SetUp]
        public void SetUp()
        {
            _countPlayerScoreBySumService = new CountPlayerScoreBySumService();

            _playerAnswers = new List<Answer>()
            {
                new Answer(4, 1, "6", true),
                new Answer(10, 2, "More than 6", true),
                new Answer(11, 3, "Sequoia", true),
                new Answer(15, 4, "yes, I do!", true)
            };
        }


        [Test]
        public void CountPlayerScoreBySum_AllAnswersAreCorrect_ReturnsFour()
        {
            var result = _countPlayerScoreBySumService.CountPlayerScoreBySum(_playerAnswers);

            Assert.That(result, Is.EqualTo(4));
        }
    }
}
