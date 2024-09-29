

namespace OnlineSurvey.Persistence.Entities
{
    public class ResultEntity
    {
        public Guid Id { get; set; }
        public Guid InterviewId { get; set; }
        public InterviewEntity Interview { get; set; }
        public Guid QuestionId { get; set; }
        public QuestionEntity Question { get; set; }
        public int AnswerId { get; set; }
        public AnswerEntity Answer { get; set; }
    }
}
