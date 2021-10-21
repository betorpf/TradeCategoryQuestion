using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using TradeCategoryQuestionConsole.Business;
using TradeCategoryQuestionConsole.Configuration;
using TradeCategoryQuestionConsole.Interfaces;
using TradeCategoryQuestionConsole.Models;

namespace TradeCategoryQuestionConsole
{
    static class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {

            _serviceProvider = DependencyInjection.RegisterServices();

            IValidateTrade _validateTrade = _serviceProvider.GetRequiredService<IValidateTrade>();

            DateTime ReferenceDate;
            int QtdTrades = 0;
            List<Trade> ListTrades = new List<Trade>();

            try
            {

                Console.WriteLine("Welcome");
                string inputConsole = null;
                inputConsole = Console.ReadLine();

                if (!DateTime.TryParse(inputConsole, out ReferenceDate))
                    Console.WriteLine("Reference Date Invalid!");

                inputConsole = Console.ReadLine();
                if (!Int32.TryParse(inputConsole, out QtdTrades))
                    Console.WriteLine("Number of trades is invalid.");

                for(int i = 0; i < QtdTrades; i++)
                {
                    inputConsole = Console.ReadLine();
                    ListTrades.Add(new Trade(ReferenceDate.ToString("yyyy/MM/dd") + ' ' + inputConsole));
                }

                foreach (Trade t in ListTrades)
                {
                    string result = _validateTrade.ReturnCategory(t);
                    Console.WriteLine(result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred. Please open the application again.");
            }
            finally
            {
                DisposeServices();
            }
                
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
                return;
            if (_serviceProvider is IDisposable)
                ((IDisposable)_serviceProvider).Dispose();
        }
    }
}
