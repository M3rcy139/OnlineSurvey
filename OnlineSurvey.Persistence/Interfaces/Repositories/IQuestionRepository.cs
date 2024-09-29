using OnlineSurvey.Persistence.Entities;

namespace OnlineSurvey.Persistence.Interfaces.Repositories
{
    public interface IQuestionRepository
    {
        Task<QuestionEntity> GetQuestion(int questionId);
    }
}
