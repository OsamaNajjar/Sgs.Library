using AutoMapper;
using Microsoft.Extensions.Logging;
using Sgs.Library.BusinessLogic;
using Sgs.Library.Model;
using Sgs.Library.Mvc.ViewModels;

namespace Sgs.Library.Mvc.Controllers
{
    public class MapsController : GeneralMvcController<Map, MapViewModel>
    {
        public MapsController(MapsManager dataManager, IMapper mapper, ILogger logger) : base("Map", dataManager, mapper, logger)
        {
        }
    }
}
