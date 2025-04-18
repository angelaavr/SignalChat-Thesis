using Microsoft.AspNetCore.Mvc;
using SignalChat.Server.Services;

namespace SignalChat.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        public PingController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }


        [HttpGet("PingClients")]
        public async Task<IActionResult> PingClients()
        {
            await _notificationService.PingAllClients();
            return Ok();
        }
    }
}
