
namespace OnlineSurvey.Persistence.Interfaces.Repositories
{
    public interface IAnswerRepository
    {
        Task<int> SaveAnswer(int AnswerId, Guid InterviewId, int QuestionId);
    }
}
