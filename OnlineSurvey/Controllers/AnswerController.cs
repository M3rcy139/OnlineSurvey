using Microsoft.AspNetCore.Mvc;
using OnlineSurvey.Persistence.Interfaces.Repositories;
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

        [HttpPost("save-answer")]
        public async Task<IActionResult> SaveAnswer([FromBody] SaveAnswerRequest request, IAnswerRepository answerRepository)
        {
            try
            {
                var questionId = await answerRepository.SaveAnswer(request.AnswerId, request.InterviewId, request.QuestionId);

                if (questionId == 0) return Ok(new { message = "Survey completed." });
                return Ok(new { nextQuestionId = questionId });
            }
            catch (ArgumentException ex) 
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An unexpected error occurred.", details = ex.Message });
            }
        }
    }
}
