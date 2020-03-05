using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgLeadershipCore.ViewModels;

namespace IgLeadershipCore.Services
{
    public interface IReportService
    {
        Task<List<IgniteReport>> GetEmployeesWithApplications();
        Task<List<IgniteReport>> GetEmployeesWithApplications(int off, int lim);
        Task<List<IgniteReport>> GetManagerEmployeesWithNoApplications();
        Task<List<IgniteReport>> GetManagerEmployeesWithCompletePrequalificationApplications();
        Task<List<IgniteReport>> GetEmployeesWithHoldStatusApplications();
        Task<List<IgniteReport>> GetNameAndDepartmentOfUsersThatClickedTheLink(int id);
        Task<List<IgniteReport>> GetMGTSEmployeesWithTwoDifferentApplicationStatuses(int statIdOne, int statIdTwo);
    }
}
