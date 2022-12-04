using QuestPDF.Infrastructure;

namespace QuestPDFDemo
{
    public static class QuestExtention
    {
        public static IServiceProvider serviceProvider;

        public static IServiceCollection AddQuestService(this IServiceCollection services)
        {       
            serviceProvider = services.BuildServiceProvider();

            return services;
        }
    }
}
