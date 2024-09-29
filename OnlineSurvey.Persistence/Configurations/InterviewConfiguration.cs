using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSurvey.Persistence.Entities;

namespace OnlineSurvey.Persistence.Configurations
{
    public class InterviewConfiguration
    {
        public void Configure(EntityTypeBuilder<InterviewEntity> builder)
        {
            builder.ToTable("Interviews");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.UserId)
                .IsRequired();

            builder.Property(i => i.StartedAt);

            builder.Property(i => i.CompletedAt);

            builder.HasOne(i => i.Survey)
                .WithMany(s => s.Interviews)
                .HasForeignKey(i => i.SurveyId);

            builder.HasIndex(i => new { i.SurveyId, i.UserId });
        }
    }
}
