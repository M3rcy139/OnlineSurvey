using OnlineSurvey.Core.Models;
using OnlineSurvey.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace OnlineSurvey.Persistence.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly SurveyDbContext _context;
        private IMapper _mapper;

        public QuestionRepository(SurveyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Question> GetQuestion(Guid questionId)
        {
            var question = await _context.Questions
                .Include(q => q.Answers)
                .FirstOrDefaultAsync(q => q.Id == questionId) ?? throw new Exception("The question does not exist");

            return _mapper.Map<Question>(question);
        }
    }
}
