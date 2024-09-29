using Microsoft.EntityFrameworkCore;
using OnlineSurvey.Persistence.Entities;

namespace OnlineSurvey.Persistence
{
    public class SurveyDbContext(DbContextOptions<SurveyDbContext> options) : DbContext(options)
    {
        public DbSet<AnswerEntity> Answers { get; set; }
        public DbSet<InterviewEntity> Interviews { get; set; }
        public DbSet<QuestionEntity> Questions { get; set; }
        public DbSet<ResultEntity> Results { get; set; }
        public DbSet<SurveyEntity> Survey { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SurveyDbContext).Assembly);
        }

    }
}
