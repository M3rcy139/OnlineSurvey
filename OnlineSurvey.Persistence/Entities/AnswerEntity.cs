using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSurvey.Persistence.Entities
{
    public class AnswerEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Guid QuestionId { get; set; }
        public QuestionEntity Question { get; set; }
    }
}
