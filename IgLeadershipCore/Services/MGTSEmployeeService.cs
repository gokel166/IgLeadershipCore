using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgLeadershipCore.Data;
using IgLeadershipCore.Models;

namespace IgLeadershipCore.Services
{
    public class MGTSEmployeeService : IMGTSEmployeeService
    {
        private readonly SqlConnectionConfiguration _configuration;

        public MGTSEmployeeService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<List<MGTSEmployee>> GetEmployees(int offset, int limit)
        {
            throw new NotImplementedException();
        }
    }
}
