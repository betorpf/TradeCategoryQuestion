using TradeCategoryQuestionConsole.Interfaces;
using TradeCategoryQuestionConsole.Models;

namespace TradeCategoryQuestionConsole.Business
{
    public class ExpiredValidation : IValidationCategory
    {
        public string ValidateCategory(Trade trade)
        {
            string result = null;

            if ((trade.ReferenceDate - trade.NextPaymentDate).Days > 30)
                result = "EXPIRED";

            return result;
        }
    }
}
