using OnlineSurvey.Persistence.Entities;
using OnlineSurvey.Persistence.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace OnlineSurvey.Persistence.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly SurveyDbContext _context;

        public QuestionRepository(SurveyDbContext context)
        {
            _context = context;
        }

        public async Task<QuestionEntity> GetQuestion(int questionId)
        {
            var question = await _context.Questions
                .Include(q => q.Answers)
                .FirstOrDefaultAsync(q => q.Id == questionId) 
                ?? throw new ArgumentException("The question does not exist");

            return question;
        }
    }
}
