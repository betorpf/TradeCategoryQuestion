using System;

namespace TradeCategoryQuestionConsole.Interfaces
{
    public interface ITrade
    {
        DateTime ReferenceDate { get; } //indicates the reference date to calculate expired trades
        double Value { get; } //indicates the transaction amount in dollars
        string ClientSector { get; } //indicates the client´s sector which can be "Public" or "Private"
    }
}
