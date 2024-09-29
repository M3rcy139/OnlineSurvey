
namespace OnlineSurvey.Persistence.Entities
{
    public class SurveyEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<QuestionEntity> Questions { get; set; }
        public ICollection<InterviewEntity> Interviews { get; set; }
    }
}
