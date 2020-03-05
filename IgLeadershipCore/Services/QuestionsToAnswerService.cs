using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgLeadershipCore.Data;
using IgLeadershipCore.Models;

namespace IgLeadershipCore.Services
{
    public class QuestionsToAnswerService : IQuestionsToAnswerService
    {
        private readonly SqlConnectionConfiguration _configuration;

        public QuestionsToAnswerService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }


        public Task<bool> AddQualificationAnswersToQuestions(IgniteQuestionsToAnswer questionsToAnswer)
        {
            throw new NotImplementedException();
        }
    }
}
