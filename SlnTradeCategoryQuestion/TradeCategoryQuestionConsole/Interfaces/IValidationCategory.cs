using TradeCategoryQuestionConsole.Models;

namespace TradeCategoryQuestionConsole.Interfaces
{
    public interface IValidationCategory
    {
        string ValidateCategory(Trade trade);
    }
}
