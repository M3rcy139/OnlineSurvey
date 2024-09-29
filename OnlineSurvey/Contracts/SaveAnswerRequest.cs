namespace OnlineSurvey.Contracts
{
    public record SaveAnswerRequest
    (
        Guid InterviewId,
        int QuestionId,
        int AnswerId
    );
}
