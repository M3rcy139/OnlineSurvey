using Microsoft.EntityFrameworkCore;
using OnlineSurvey.Persistence.Entities;
using OnlineSurvey.Persistence.Interfaces.Repositories;

namespace OnlineSurvey.Persistence.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly SurveyDbContext _context;

        public AnswerRepository(SurveyDbContext surveyContext)
        {
            _context = surveyContext;
        }
        public async Task<int> SaveAnswer(int AnswerId, Guid InterviewId, int QuestionId)
        {
            var interview = await _context.Interviews
                .Include(i => i.Survey)
                .ThenInclude(s => s.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(i => i.Id == InterviewId) 
                ?? throw new ArgumentException("Interview not found");

            var question = interview.Survey.Questions.FirstOrDefault(q => q.Id == QuestionId) 
                ?? throw new ArgumentException("Question not found");


            var answerExists = question.Answers.FirstOrDefault(a => a.Id == AnswerId) 
                ?? throw new InvalidOperationException("Answer does not belong to the specified question");

            var result = new ResultEntity
            {
                InterviewId = InterviewId,
                QuestionId = QuestionId,
                AnswerId = AnswerId
            };

            _context.Results.Add(result);
            await _context.SaveChangesAsync();

            var currentQuestionIndex = interview.Survey.Questions
                .OrderBy(q => q.Id)
                .ToList()
                .FindIndex(q => q.Id == QuestionId);

            var nextQuestion = interview.Survey.Questions
                .OrderBy(q => q.Id)
                .Skip(currentQuestionIndex + 1)
                .FirstOrDefault();

            if (nextQuestion == null)
            {
                interview.CompletedAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                return 0;
            }

            return nextQuestion.Id;
        }
    }
}
