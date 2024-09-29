using OnlineSurvey.Core.Models;

namespace OnlineSurvey.Application.Interfaces.Repositories
{
    public interface IAnswerRepository
    {
        Task<Guid> SaveAnswer(int AnswerId, Guid InterviewId, Guid QuestionId);
    }
}
