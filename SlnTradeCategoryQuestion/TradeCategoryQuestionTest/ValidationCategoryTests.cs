
using NUnit.Framework;
using TradeCategoryQuestionConsole.Business;
using TradeCategoryQuestionConsole.Models;

namespace TradeCategoryQuestionTest
{
    [TestFixture]
    public class ValidationCategoryTests
    {
        private ExpiredValidation expiredValidation;
        private HighRiskValidation highRiskValidation;
        private MediumRiskValidation mediumRiskValidation;

        [SetUp]
        public void SetUp()
        {
            expiredValidation = new ExpiredValidation();
            highRiskValidation = new HighRiskValidation();
            mediumRiskValidation = new MediumRiskValidation();
        }

        [Test]
        public void ValidateCategoryExpired()
        {
            Trade trade = new Trade("12/11/2020 400000 Public 07/01/2020");
            var result = expiredValidation.ValidateCategory(trade);
            Assert.That(result, Is.EqualTo("EXPIRED"));
        }

        [Test]
        public void ValidateCategoryHighRisk()
        {
            Trade trade = new Trade("12/11/2020 2000000 Private 12/29/2025");
            var result = highRiskValidation.ValidateCategory(trade);
            Assert.That(result, Is.EqualTo("HIGHRISK"));
        }

        [Test]
        public void ValidateCategoryMediumRisk()
        {
            Trade trade = new Trade("12/11/2020 3000000 Public 10/26/2023");
            var result = mediumRiskValidation.ValidateCategory(trade);
            Assert.That(result, Is.EqualTo("MEDIUMRISK"));
        }


    }
}
