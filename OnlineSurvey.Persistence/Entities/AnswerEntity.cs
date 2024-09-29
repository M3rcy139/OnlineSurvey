
namespace OnlineSurvey.Persistence.Entities
{
    public class AnswerEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int QuestionId { get; set; }
        public QuestionEntity Question { get; set; }
    }
}
