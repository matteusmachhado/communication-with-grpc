using Microsoft.AspNetCore.Mvc;
using Projetct.WMS.Core.Interfaces;

namespace Project.WMS.WebAPI.Core.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public MainController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        protected ActionResult CreateResponse(object result = null)
        {
            if (IsValid())
            {
                return Ok(result);
            }

            return BadRequest(new
            {
                errors = _notificationService.Notifications().Select(n => n.Message)
            });
        }

        protected bool IsValid()
        {
            return !_notificationService.Has();
        }
    }
}
