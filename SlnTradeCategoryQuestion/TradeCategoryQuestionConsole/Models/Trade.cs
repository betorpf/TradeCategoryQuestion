using System;
using System.Globalization;
using System.Reflection;
using TradeCategoryQuestionConsole.Interfaces;

namespace TradeCategoryQuestionConsole.Models
{
    public class Trade : ITrade
    {
        public DateTime ReferenceDate { get; } //indicates when the next payment from the client to the bank is expected
        public double Value { get; }
        public string ClientSector { get; }
        public DateTime NextPaymentDate { get; }
        //public bool IsPoliticallyExposed { get; }

        public Trade(string inputConsole)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string[] input = inputConsole.Split(' ');

            this.ReferenceDate = Convert.ToDateTime(input[0], culture);
            this.Value = Double.Parse(input[1]);
            this.ClientSector = input[2];
            this.NextPaymentDate = Convert.ToDateTime(input[3], culture);
            //this.IsPoliticallyExposed = input[4].ToUpper() == "TRUE";
        }

    }
}
