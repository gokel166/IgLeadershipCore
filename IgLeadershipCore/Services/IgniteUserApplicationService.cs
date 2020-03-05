using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using IgLeadershipCore.Data;
using IgLeadershipCore.Models;

namespace IgLeadershipCore.Services
{
    public class IgniteUserApplicationService : IIgniteUserApplicationService
    {
        private readonly SqlConnectionConfiguration _configuration;

        public IgniteUserApplicationService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Gives new Application to user to their assigned MGTSEmployeeCode if they do not have a pre-existing application
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public async Task<bool> IgniteApplicationAddNewApplication(IgniteUserApplication application)
        {
            int newApplicationStatusId = 1;
            application.IgniteApplicationStatusId = newApplicationStatusId;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("MGTSEmployeeCode", application.MgtsemployeeCode, DbType.Int32);

                const string query = @"insert into ibs.IgniteUserApplication (MGTSEmployeeCode) values (@MGTSEmployeeCode);";


                const string stored_proc = "ibs.MGTSIgniteUserApplication_Insert";

                conn.Open();
                await conn.ExecuteAsync(stored_proc, parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        /// <summary>
        /// Add All the PreQualification Questions for the application
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public async Task<bool> IgniteApplicationInsertPrequalificationQuestions(IgniteUserApplication application)
        {
            const string stored_proc = "ibs.IgniteUserApplication_InsertPrequalification";
            var parameters = new DynamicParameters();
            parameters.Add("ManagerName", application.ManagerName, dbType: DbType.String);
            parameters.Add("BuName", application.BuName, dbType: DbType.String);
            parameters.Add("LocationName", application.LocationName, dbType: DbType.String);
            parameters.Add("EmployementOverOneYear", application.EmployementOverOneYear, dbType: DbType.Boolean);
            parameters.Add("BachelorDegreeQualifier", application.BachelorDegreeQualifier, dbType: DbType.Boolean);
            parameters.Add("BachelorDegreePursuing", application.BachelorDegreePursuing, dbType: DbType.Boolean);
            parameters.Add("PreQualificationQuestionsCompletionDate", application.PreQualificationQuestionsCompletionDate, dbType: DbType.DateTime2);
            parameters.Add("ArePrequalificationQuestionComplete", application.ArePrequalificationQuestionComplete, dbType: DbType.Boolean);
            parameters.Add("ManagerStatusChangeDate", application.ManagerStatusChangeDate, dbType: DbType.DateTime2);
            parameters.Add("AreQualificationQuestionsComplete", application.AreQualificationQuestionsComplete, dbType: DbType.Boolean);
            parameters.Add("IgniteApplicationStatusId", application.IgniteApplicationStatusId, dbType: DbType.Int32);

            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    conn.Open();
                    await conn.ExecuteAsync(stored_proc, parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }

        /// <summary>
        /// Add Application to user if they have a pre-existing application
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public async Task<bool> IgniteApplicationProvideNewApplicationToUserWithPreviousApplication(IgniteUserApplication application)
        {
            throw new NotImplementedException();
        }
    }
}
