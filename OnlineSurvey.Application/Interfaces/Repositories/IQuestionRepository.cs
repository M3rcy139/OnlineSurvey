using OnlineSurvey.Core.Models;

namespace OnlineSurvey.Application.Interfaces.Repositories
{
    public interface IQuestionRepository
    {
        Task<Question> GetQuestion(Guid questionId);
    }
}
