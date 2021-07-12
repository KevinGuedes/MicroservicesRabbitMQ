﻿using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Banking.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroservicesRabbitMQ.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly ILogger<BankingController> _logger;
        private readonly IAccountService _accountService;
        private static readonly string service = "Banking";

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

        [HttpPost("transfer")]
        public IActionResult Transfer([FromBody] Transfer transfer)
        {
            _logger.LogInformation($"[{service}] Transfer method accessed");
            _accountService.Transfer(transfer);
            return Ok();
        }
    }
}