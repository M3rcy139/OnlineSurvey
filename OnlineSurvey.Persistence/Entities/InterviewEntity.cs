
namespace OnlineSurvey.Persistence.Entities
{
    public class InterviewEntity
    {
        public Guid Id { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public Guid UserId { get; set; }
        public Guid SurveyId { get; set; }
        public SurveyEntity Survey { get; set; }
        public ICollection<ResultEntity> Results { get; set; }
    }
}
