using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineSurvey.Application.Interfaces.Repositories;
using OnlineSurvey.Persistence.Repositories;

namespace OnlineSurvey.Persistence
{
    public static class PersistenceExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services
            , IConfiguration configuration)
        {
            services.AddDbContext<SurveyDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString(nameof(SurveyDbContext)));
            });

            services.AddScoped<IAnswerRepository, AnswerRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();

            return services;
        }
    }
}

