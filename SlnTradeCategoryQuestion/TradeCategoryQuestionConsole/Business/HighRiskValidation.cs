using TradeCategoryQuestionConsole.Interfaces;
using TradeCategoryQuestionConsole.Models;

namespace TradeCategoryQuestionConsole.Business
{
    public class HighRiskValidation : IValidationCategory
    {
        public string ValidateCategory(Trade trade)
        {
            string result = null;

            if (trade.Value > 1000000 && trade.ClientSector.ToUpper() == "PRIVATE")
                result = "HIGHRISK";

            return result;
        }
    }
}
