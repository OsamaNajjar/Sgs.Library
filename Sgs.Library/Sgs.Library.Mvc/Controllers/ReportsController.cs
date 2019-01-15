using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Sameer.Shared.Data;
using Sgs.Library.BusinessLogic;
using Sgs.Library.Model;
using Sgs.Library.Mvc.ViewModels;

namespace Sgs.Library.Mvc.Controllers
{
    public class ReportsController : GeneralMvcController<Report, ReportViewModel>
    {
        private readonly GeneralManager<ReportType> _allTypesManager;

        public ReportsController(GeneralManager<ReportType> allTypesManager ,GeneralManager<Report> dataManager, IMapper mapper, ILogger<ReportsController> logger) 
            : base("Report", dataManager, mapper, logger)
        {
            this._allTypesManager = allTypesManager;
        }

        protected override async Task<ReportViewModel> createObject()
        {
            var allTypes = await _allTypesManager.GetAllAsNoTrackingListAsync();
            return new ReportViewModel { AllReportsTypes = allTypes };
        }

       
    }
}
