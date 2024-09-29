
namespace OnlineSurvey.Persistence.Entities
{
    public class QuestionEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Guid SurveyId { get; set; }
        public SurveyEntity Survey { get; set; }
        public ICollection<AnswerEntity> Answers { get; set; }
    }
}
