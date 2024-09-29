using Microsoft.AspNetCore.Mvc;
using OnlineSurvey.Persistence.Interfaces.Repositories;
using OnlineSurvey.Contracts;
using OnlineSurvey.Persistence;

namespace OnlineSurvey.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly SurveyDbContext _context;

        public QuestionController(SurveyDbContext context)
        {
            _context = context;
        }

        [HttpGet("{questionId}")]
        public async Task<IActionResult> GetQuestion(int questionId, IQuestionRepository questionRepository)
        {
            try
            {
                var question = await questionRepository.GetQuestion(questionId);

                var response = new GetQuestionResponse
                (
                    question.Id,
                    question.Text,
                    question.Answers.Select(a => new AnswerDto(a.Id, a.Text))
                );

                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An unexpected error occurred.", details = ex.Message }); 
            }
        }
    }
}
