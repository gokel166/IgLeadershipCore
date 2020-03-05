using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgLeadershipCore.Data;
using IgLeadershipCore.ViewModels;

namespace IgLeadershipCore.Services
{
    public class ReportService : IReportService
    {
        private readonly SqlConnectionConfiguration _configuration;

        public ReportService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<List<IgniteReport>> GetEmployeesWithApplications()
        {
            throw new NotImplementedException();
        }

        public Task<List<IgniteReport>> GetEmployeesWithApplications(int off, int lim)
        {
            throw new NotImplementedException();
        }

        public Task<List<IgniteReport>> GetManagerEmployeesWithNoApplications()
        {
            throw new NotImplementedException();
        }

        public Task<List<IgniteReport>> GetManagerEmployeesWithCompletePrequalificationApplications()
        {
            throw new NotImplementedException();
        }

        public Task<List<IgniteReport>> GetEmployeesWithHoldStatusApplications()
        {
            throw new NotImplementedException();
        }

        public Task<List<IgniteReport>> GetNameAndDepartmentOfUsersThatClickedTheLink(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IgniteReport>> GetMGTSEmployeesWithTwoDifferentApplicationStatuses(int statIdOne, int statIdTwo)
        {
            throw new NotImplementedException();
        }
    }
}
