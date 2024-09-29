using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSurvey.Persistence.Entities;

namespace OnlineSurvey.Persistence.Configurations
{
    public class SurveyConfiguration
    {
        public void Configure(EntityTypeBuilder<SurveyEntity> builder)
        {
            builder.ToTable("Survey");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Title);

            builder.HasMany(s => s.Questions)
                .WithOne(q => q.Survey)
                .HasForeignKey(q => q.SurveyId);

            builder.HasIndex(s => s.Title);
        }
    }
}
