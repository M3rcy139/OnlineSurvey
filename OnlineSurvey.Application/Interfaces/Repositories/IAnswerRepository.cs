﻿using OnlineSurvey.Core.Models;

namespace OnlineSurvey.Application.Interfaces.Repositories
{
    public interface IAnswerRepository
    {
        Task<int> SaveAnswer(int AnswerId, Guid InterviewId, int QuestionId);
    }
}
