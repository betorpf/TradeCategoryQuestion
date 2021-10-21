using TradeCategoryQuestionConsole.Interfaces;
using TradeCategoryQuestionConsole.Models;

namespace TradeCategoryQuestionConsole.Business
{
    public class MediumRiskValidation : IValidationCategory
    {
        public string ValidateCategory(Trade trade)
        {
            string result = null;

            if (trade.Value > 1000000 && trade.ClientSector.ToUpper() == "PUBLIC")
                result = "MEDIUMRISK";

            return result;
        }
    }
}
