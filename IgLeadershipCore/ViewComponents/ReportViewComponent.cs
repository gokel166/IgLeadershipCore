using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgLeadershipCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace IgLeadershipCore.ViewComponents
{
    public class ReportViewComponent : ViewComponent
    {
        private IReportService _reportService;

        public ReportViewComponent(IReportService reportService)
        {
            _reportService = reportService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var report = await _reportService.GetEmployeesWithApplications();
        }
    }
}
