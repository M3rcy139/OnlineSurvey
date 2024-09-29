namespace OnlineSurvey.Contracts
{
    public record SaveAnswerRequest
    (
        Guid InterviewId,
        Guid QuestionId,
        int AnswerId
    );
}
