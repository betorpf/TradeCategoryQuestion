using TradeCategoryQuestionConsole.Interfaces;
using TradeCategoryQuestionConsole.Models;

namespace TradeCategoryQuestionConsole.Business
{
    public class PEPValidation : IValidationCategory
    {
        public string ValidateCategory(Trade trade)
        {
            string result = null;

            //if (trade.IsPoliticallyExposed)
            //    result = "POLITICALLY EXPOSED PERSON";

            return result;
        }
    }
}
