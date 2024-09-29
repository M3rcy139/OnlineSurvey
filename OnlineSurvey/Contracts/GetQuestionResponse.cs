
namespace OnlineSurvey.Contracts
{
    public record GetQuestionResponse
    (
        int Id,
        string Text,
        IEnumerable<AnswerDto> Answers
    );
    
    public record AnswerDto
    (
            int Id,
            string Text
    );
}
