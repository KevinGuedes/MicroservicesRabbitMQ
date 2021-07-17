using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Banking.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroservicesRabbitMQ.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly ILogger<BankingController> _logger;
        private readonly IAccountService _accountService;
        private readonly string service = "Banking";

        public BankingController(ILogger<BankingController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpGet("accounts")]
        public IActionResult GetAccounts()
        {
            _logger.LogInformation($"[{service}] Get Accounts method accessed");
            return Ok(_accountService.GetAccounts());
        }

        [HttpGet("accounts/{id:int}")]
        public IActionResult GetAccountById([FromRoute] int id)
        {
            _logger.LogInformation($"[{service}] Get Account By Id method accessed");
            return Ok(_accountService.GetAccountById(id));
        }

        [HttpPost("transfer")]
        public IActionResult Transfer([FromBody] Transfer transfer)
        {
            _logger.LogInformation($"[{service}] Transfer method accessed");
            _accountService.Transfer(transfer);
            return Ok();
        }
    }
}
