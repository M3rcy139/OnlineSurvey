

namespace OnlineSurvey.Core.Models
{
    public class Interview
    {
        public Guid Id { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public Guid UserId { get; set; }
        public Guid SurveyId { get; set; }
        public Survey Survey { get; set; }
        public ICollection<Result> Results { get; set; }
    }

}
