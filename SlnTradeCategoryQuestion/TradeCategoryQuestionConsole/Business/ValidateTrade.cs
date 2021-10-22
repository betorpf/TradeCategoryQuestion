using System.Collections.Generic;
using TradeCategoryQuestionConsole.Interfaces;
using TradeCategoryQuestionConsole.Models;

namespace TradeCategoryQuestionConsole.Business
{
    public class ValidateTrade : IValidateTrade
    {
        protected static List<IValidationCategory> _rules = new List<IValidationCategory>();

        public ValidateTrade()
        {
            //_rules.Add(new PEPValidation());
            _rules.Add(new ExpiredValidation());
            _rules.Add(new HighRiskValidation());
            _rules.Add(new MediumRiskValidation());
        }

        public string ReturnCategory(Trade trade)
        {
            string result = "";
            foreach (var rule in _rules)
            {
                result = rule.ValidateCategory(trade);
                if (result != null)
                    break;
            }
            return result;
        }
        

    }
}
