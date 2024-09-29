using OnlineSurvey.Core.Models;
using OnlineSurvey.Persistence.Entities;
using AutoMapper;

namespace OnlineSurvey.Persistence.Mappings
{
    public class DataBaseMappings : Profile
    {
        public DataBaseMappings()
        {
            CreateMap<AnswerEntity, Answer>();
            CreateMap<QuestionEntity, Question>();
            CreateMap<InterviewEntity, Interview>();
            CreateMap<ResultEntity, Result>();
            CreateMap<SurveyEntity, Survey>();
        }
    }
}
