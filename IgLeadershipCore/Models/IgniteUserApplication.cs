using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgLeadershipCore.Models
{
    public class IgniteUserApplication
    {
        public int IgniteApplicationId { get; set; }
        public DateTime ApplicationCreationDate { get; set; }
        public string ManagerName { get; set; }
        public string BuName { get; set; }
        public string DepartmentName { get; set; }
        public string LocationName { get; set; }
        public bool EmployementOverOneYear { get; set; }
        public bool BachelorDegreeQualifier { get; set; }
        public bool BachelorDegreePursuing { get; set; }
        public DateTime? PreQualificationQuestionsCompletionDate { get; set; }
        public bool ArePrequalificationQuestionComplete { get; set; }
        public DateTime? ManagerStatusChangeDate { get; set; }
        public bool AreQualificationQuestionsComplete { get; set; }
        public int IgniteApplicationStatusId { get; set; }
        public int MgtsemployeeCode { get; set; }
    }
}
