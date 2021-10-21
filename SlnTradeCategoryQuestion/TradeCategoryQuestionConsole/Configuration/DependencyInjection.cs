using Microsoft.Extensions.DependencyInjection;
using TradeCategoryQuestionConsole.Business;
using TradeCategoryQuestionConsole.Interfaces;

namespace TradeCategoryQuestionConsole.Configuration
{
    public static class DependencyInjection
    {
        public static ServiceProvider RegisterServices()
        {
            ServiceCollection collection = new ServiceCollection();
            collection.AddScoped<IValidateTrade, ValidateTrade>();
            ServiceProvider _serviceProvider = collection.BuildServiceProvider();
            return _serviceProvider;
        }
    }
}
