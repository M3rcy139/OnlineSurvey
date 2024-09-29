using Microsoft.AspNetCore.Mvc;
using OnlineSurvey.Application.Interfaces.Repositories;
using OnlineSurvey.Contracts;
using OnlineSurvey.Persistence;


namespace OnlineSurvey.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InterviewController : ControllerBase
    {
        private readonly SurveyDbContext _context;

        public InterviewController(SurveyDbContext context)
        {
            _context = context;
        }

        // POST: api/interview/save-answer
        [HttpPost("save-answer")]
        public async Task<IActionResult> SaveAnswer([FromBody] SaveAnswerRequest request, IAnswerRepository answerRepository)
        {
            var questionId = await answerRepository.SaveAnswer(request.AnswerId, request.InterviewId, request.QuestionId);

            if (questionId == Guid.Empty) return Ok(new { message = "Survey completed." });
            return Ok(new { nextQuestionId = questionId });
        }
    }
}
