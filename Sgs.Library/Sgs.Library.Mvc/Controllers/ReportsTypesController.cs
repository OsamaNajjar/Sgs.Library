using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sameer.Shared.Data;
using Sgs.Library.BusinessLogic;
using Sgs.Library.Model;
using Sgs.Library.Mvc.ViewModels;
using System.Threading.Tasks;

namespace Sgs.Library.Mvc.Controllers
{
    public class ReportsTypesController : GeneralMvcController<ReportType, ReportTypeViewModel>
    {
        public ReportsTypesController(GeneralManager<ReportType> dataManager, IMapper mapper, ILogger<ReportsController> logger)
            : base("ReportType", dataManager, mapper, logger)
        {
        }

    }
}