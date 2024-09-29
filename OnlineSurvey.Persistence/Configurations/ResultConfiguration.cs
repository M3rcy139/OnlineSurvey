using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineSurvey.Persistence.Entities;

namespace OnlineSurvey.Persistence.Configurations
{
    public class ResultConfiguration
    {
        public void Configure(EntityTypeBuilder<ResultEntity> builder)
        {
            builder.ToTable("Results");

            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.Interview)
                .WithMany(i => i.Results)
                .HasForeignKey(r => r.InterviewId);

            builder.HasOne(r => r.Question)
                .WithMany()
                .HasForeignKey(r => r.QuestionId);

            builder.HasOne(r => r.Answer)
                .WithMany()
                .HasForeignKey(r => r.AnswerId);

            builder.HasIndex(r => new { r.InterviewId, r.QuestionId }).IsUnique();
        }
    }
}
