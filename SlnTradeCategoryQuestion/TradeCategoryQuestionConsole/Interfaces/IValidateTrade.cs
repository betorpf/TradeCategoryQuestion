using TradeCategoryQuestionConsole.Models;

namespace TradeCategoryQuestionConsole.Interfaces
{
    public interface IValidateTrade
    {
        string ReturnCategory(Trade trade);
    }
}
