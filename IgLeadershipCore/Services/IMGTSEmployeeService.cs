using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgLeadershipCore.Models;

namespace IgLeadershipCore.Services
{
    public interface IMGTSEmployeeService
    {
        Task<List<MGTSEmployee>> GetEmployees(int offset, int limit);
    }
}
