namespace OnlineSurvey.Core.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public Guid SurveyId { get; set; }
        public Survey? Survey { get; set; }
        public ICollection<Answer>? Answers { get; set; }
    }

}
