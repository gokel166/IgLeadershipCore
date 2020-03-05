using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgLeadershipCore.Models;

namespace IgLeadershipCore.Services
{
    public interface IIgniteUserApplicationService
    {
        Task<bool> IgniteApplicationAddNewApplication(IgniteUserApplication application);
        Task<bool> IgniteApplicationProvideNewApplicationToUserWithPreviousApplication(IgniteUserApplication application);
        Task<bool> IgniteApplicationInsertPrequalificationQuestions(IgniteUserApplication application);
    }
}
