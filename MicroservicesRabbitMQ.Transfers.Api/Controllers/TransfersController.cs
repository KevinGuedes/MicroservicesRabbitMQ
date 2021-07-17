using MicroservicesRabbitMQ.Transfers.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroservicesRabbitMQ.Transfers.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransfersController : ControllerBase
    {
        private readonly ILogger<TransfersController> _logger;
        private readonly ITransferService _transferService;
        private readonly string service = "Transfers";

        public TransfersController(ILogger<TransfersController> logger, ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        }

        [HttpGet("transfers")]
        public IActionResult GetTransfers()
        {
            _logger.LogInformation($"[{service}] Get Transfers method accessed");
            return Ok(_transferService.GetTransfers());
        }
    }
}
