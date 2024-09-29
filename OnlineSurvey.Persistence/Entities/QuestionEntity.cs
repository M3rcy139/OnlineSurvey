
namespace OnlineSurvey.Persistence.Entities
{
    public class QuestionEntity
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid SurveyId { get; set; }
        public SurveyEntity Survey { get; set; }
        public ICollection<AnswerEntity> Answers { get; set; }
        public int Order { get; set; }
    }
}
