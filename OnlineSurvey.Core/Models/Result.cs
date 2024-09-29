
namespace OnlineSurvey.Core.Models
{
    public class Result
    {
        public Guid Id { get; set; }
        public Guid InterviewId { get; set; }
        public Interview Interview { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }

}
